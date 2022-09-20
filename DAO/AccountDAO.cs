using System;
using System.Collections.Generic;
using System.Data;
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

        // kiểm tra userName có tồn tại hay không
        public bool isLogin(string userName, string passWord)
        {
            // trả về true nếu có dòng record sau khi chạy query
            //sử dụng query trực tiếp
            //string query = "SELECT * FROM dbo.Account WHERE userName = '" + userName + "' AND passWord = '" + passWord+"'";
            //DataTable result = DataProvider.Instance.ExecuteQuery(query);

            // sử dụng proc để truyền parameter vào hàm ExecuteQuery
            string query = "EXEC dbo.USP_GetAccountByUserNameAndPassWord @userName , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { "" + userName + "", "" + passWord + "" });
            return result.Rows.Count > 0;
        }
    }
}
