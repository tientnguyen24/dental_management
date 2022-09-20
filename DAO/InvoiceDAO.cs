using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DAO
{
    class InvoiceDAO
    {
        private static InvoiceDAO instance;
        public static InvoiceDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
    }
}
