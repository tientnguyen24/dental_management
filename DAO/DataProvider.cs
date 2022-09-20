using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DAO
{
    public class DataProvider
    {
        //tạo kết nối database 1 lần duy nhất và chạy xuyên xuốt chương trình
        private static DataProvider instance;

        // đóng gói DataProvider
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance; 
            }
            private set { DataProvider.instance = value; }
        }
        //tao constructor không tham số cho DataProvider
        private DataProvider() { }

        // chuỗi xác định kết nối tới database
        private string connectionStr = "Data Source=DICTIENTNGUYEN;Initial Catalog=DB_DentalManagement;Integrated Security=True";

        // query trả về dữ liệu khi thực thi câu query với tham số truyền vào, mặc định null
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            // hiển thị dữ liệu qua data table
            DataTable data = new DataTable();

            // kết thúc khối lệnh sẽ tự được giải phóng qua using()
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // kết nối connection
                connection.Open();

                // thực thi câu query với database
                SqlCommand command = new SqlCommand(query, connection);

                // hàm truyền vào n parameter để thực thi proc
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //trung gian thực thi câu truy vấn ở command
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // fill dữ liệu vào từ câu truy vấn tới biến data
                adapter.Fill(data);

                // đóng kết nối database
                connection.Close();
            }
            return data;
        }

        // non query trả về số dòng record được thực thi với tham số truyền vào
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            // biến đếm số lượng record khi chạy câu query
            int data = 0;

            // kết thúc khối lệnh sẽ tự được giải phóng qua using()
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // kết nối connection
                connection.Open();

                // thực thi câu query với database
                SqlCommand command = new SqlCommand(query, connection);

                // hàm truyền vào n parameter để thực thi proc
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                // thực thi hàm nonquery và trả kết quả về data
                data = command.ExecuteNonQuery();

                // đóng kết nối database
                connection.Close();
            }
            return data;
        }

        // scalar trả về ô đầu tiên của cột và dòng
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            // biến đếm số lượng record khi chạy câu query
            object data = 0;

            // kết thúc khối lệnh sẽ tự được giải phóng qua using()
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                // kết nối connection
                connection.Open();

                // thực thi câu query với database
                SqlCommand command = new SqlCommand(query, connection);

                // hàm truyền vào n parameter để thực thi proc
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                // thực thi hàm scalar và trả kết quả về data (giống select count *)
                data = command.ExecuteScalar();

                // đóng kết nối database
                connection.Close();
            }
            return data;
        }
    }
}
