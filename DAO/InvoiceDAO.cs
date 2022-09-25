using QuanLyNhaKhoa.DTO;
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
        private InvoiceDAO() { }
        public List<Invoice> GetInvoiceListByCustomerId(string id)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            string query = "SELECT * FROM dbo.Invoice WHERE dbo.Invoice.customerId = N'" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Invoice invoice = new Invoice(item);
                invoiceList.Add(invoice);
            }
            return invoiceList;
        }
    }
}
