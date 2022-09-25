using QuanLyNhaKhoa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DAO
{
    class InvoiceDetailDAO
    {
        private static InvoiceDetailDAO instance;
        public static InvoiceDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceDetailDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private InvoiceDetailDAO() { }

        public List<InvoiceDetail> GetInvoiceDetailList(string id)
        {
            List<InvoiceDetail> invoiceDetailList = new List<InvoiceDetail>();
            string query = "SELECT * FROM dbo.InvoiceDetail WHERE dbo.InvoiceDetail.invoiceId = N'" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                InvoiceDetail invoiceDetail = new InvoiceDetail(item);
                invoiceDetailList.Add(invoiceDetail);
            }
            return invoiceDetailList;
        }
    }
}
