using QuanLyNhaKhoa.DAO;
using QuanLyNhaKhoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKhoa
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

        private void fStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ứng dụng", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< Updated upstream

        void LoadCustomerList()
        {
            // tạo câu query truy vấn dữ liệu
            string query = "SELECT id AS [Mã khách hàng], name AS [Họ và tên], dayOfBirth AS [Ngày sinh], telephone AS [Số điện thoại], email AS [Địa chỉ Email], gender AS [Giới tính], identifyCard AS [CMND/CCCD] from dbo.Customer;";
            // đổ dữ liệu ở query vào data griv view thông qua DataProvider - sử dụng singleton
            dtgvContent.DataSource = DataProvider.Instance.ExecuteQuery(query);

            //câu truy vấn tới proc USP_GetCustomerByID
            //string query = "EXEC dbo.USP_GetCustomerByID @id";
            //dtgvContent.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"M001"});
        }

        void LoadInvoiceList()
        {
            string query = "SELECT dbo.Customer.name AS [Họ và tên], dbo.Product.name AS [Tên dịch vụ],  dbo.Invoice.invoiceDate AS [Ngày lập hoá đơn], dbo.Invoice.invoiceNo AS [Số hoá đơn], dbo.InvoiceDetail.quantity AS [Số lượng], dbo.Product.price AS [Đơn giá], dbo.InvoiceDetail.amount AS [Thành tiền] FROM dbo.Customer JOIN dbo.Invoice ON dbo.Customer.id = dbo.Invoice.customerId JOIN dbo.InvoiceDetail ON dbo.Invoice.id = dbo.InvoiceDetail.invoiceId JOIN dbo.Product ON dbo.Product.id = dbo.InvoiceDetail.productId";

            dtgvContent.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
=======
        
>>>>>>> Stashed changes
        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            List<Customer> customerList = CustomerDAO.Instance.LoadCustomerList();
            dtgvContent.Columns.Add("name", "Họ và tên");
            dtgvContent.Columns.Add("gender", "Giới tính");
            dtgvContent.Columns.Add("dayOfBirth", "Ngày sinh");
            dtgvContent.Columns.Add("telephone", "Số điện thoại");
            dtgvContent.Columns.Add("email", "Địa chỉ Email");
            dtgvContent.Columns.Add("identifyCard", "CMND/CCCD");
            foreach (Customer item in customerList)
            {
                string gender = "";
                if (item.Gender == 1)
                {
                    gender = "Nam";
                }
                else
                {
                    gender = "Nữ";
                }

                dtgvContent.Rows.Add(item.Name, gender, item.DayOfBirth, item.Telephone, item.Email, item.IdentifyCard);

            }
            //btnCustomerSupport.Enabled = false;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            LoadInvoiceList();
=======
            string query = "SELECT " +
                "dbo.Customer.name AS [Họ và tên], " +
                "dbo.Product.name AS [Tên dịch vụ],  " +
                "dbo.Invoice.invoiceDate AS [Ngày lập hoá đơn], " +
                "dbo.Invoice.invoiceNo AS [Số hoá đơn], " +
                "dbo.InvoiceDetail.quantity AS [Số lượng], " +
                "dbo.Product.price AS [Đơn giá], " +
                "dbo.InvoiceDetail.amount AS [Thành tiền] " +
                "FROM dbo.Customer JOIN dbo.Invoice ON dbo.Customer.id = dbo.Invoice.customerId JOIN dbo.InvoiceDetail ON dbo.Invoice.id = dbo.InvoiceDetail.invoiceId JOIN dbo.Product ON dbo.Product.id = dbo.InvoiceDetail.productId";
            dtgvContent.DataSource = DataProvider.Instance.ExecuteQuery(query);
>>>>>>> Stashed changes
        }
    }
}
