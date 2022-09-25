using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DTO
{
    public class Invoice
    {
        public Invoice(string id, string invoiceNo, DateTime invoiceDate, string customerId)
        {
            this.Id = id;
            this.InvoiceNo = invoiceNo;
            this.InvoiceDate = invoiceDate;
            this.CustomerId = customerId;
        }

        public Invoice(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.InvoiceNo = row["invoiceNo"].ToString();
            this.InvoiceDate = (DateTime)row["invoiceDate"];
            this.CustomerId = row["customerId"].ToString();
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string invoiceNo;
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        private DateTime invoiceDate;
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        private string customerId;
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
