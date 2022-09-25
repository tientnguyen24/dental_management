using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DTO
{
    public class Product
    {
        public Product(string id, string productCategoryId, string name, int price)
        {
            this.Id = id;
            this.ProductCategoryId = productCategoryId;
            this.Name = name;
            this.Price = price;
        }

        public Product(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.ProductCategoryId = row["productCategoryId"].ToString();
            this.Name = row["name"].ToString();
            this.Price = (int)row["price"];
        }

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string productCategoryId;
        public string ProductCategoryId
        {
            get { return productCategoryId; }
            set { productCategoryId = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
