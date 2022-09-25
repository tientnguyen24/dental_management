using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DTO
{
    public class ProductCategory
    {
        public ProductCategory(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ProductCategory(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
