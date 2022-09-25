using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DTO
{
    public class InvoiceDetail
    {

        public InvoiceDetail(string id, string invoiceId, string productId, float quantity, float amount)
        {
            this.Id = id;
            this.InvoiceId = invoiceId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Amount = amount;
        }

        public InvoiceDetail(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.InvoiceId = row["invoiceId"].ToString();
            this.ProductId = row["productId"].ToString();
            this.Quantity = (float)row["quantity"];
            this.Amount = (float)row["amount"];
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string invoiceId;

        public string InvoiceId
        {
            get { return invoiceId; }
            set { invoiceId = value; }
        }

        private string productId;

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private float quantity;
        public float Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private float amount;
        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

    }
}
