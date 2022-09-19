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
            if (userName == "admin" && passWord == "12345")
            {
                return true;
            }
            return false;
        }
    }
}
