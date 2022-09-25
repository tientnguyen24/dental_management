using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKhoa.DAO
{
    class ProductCategoryDAO
    {
        private static ProductCategoryDAO instance;
        public static ProductCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductCategoryDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private ProductCategoryDAO() { }
    }
}
