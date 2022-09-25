using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
		
		private AccountDAO() { }
		
		public bool isEmpty(string userName, string passWord)
        {
            if (userName == "" || passWord == "")
            {
                return false;
            }
            return true;
        }

        public bool isLogin(string userName, string passWord)
        {
<<<<<<< Updated upstream
            if (userName == "admin" && passWord == "12345")
            {
                return true;
            }
            return false;
=======
            // trả về true nếu có dòng record sau khi chạy query
            //sử dụng query trực tiếp nhưng có thể bị lỗi SQL Injection nên dùng stored procedure sẽ bảo mật hơn
            //string query = "SELECT * FROM dbo.Account WHERE userName = '" + userName + "' AND passWord = '" + passWord+"'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);

            // sử dụng proc để truyền parameter vào hàm ExecuteQuery
            string query = "USP_GetAccountByUserNameAndPassWord @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { "" + userName + "", "" + passWord + "" });
            return result.Rows.Count > 0;
>>>>>>> Stashed changes
        }
    }
}
