using QuanLyNhaKhoa.DAO;
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

        
        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            string query = "SELECT dbo.Customer.name AS [Họ và tên], dbo.Product.name AS [Tên dịch vụ],  dbo.Invoice.invoiceDate AS [Ngày lập hoá đơn], dbo.Invoice.invoiceNo AS [Số hoá đơn], dbo.InvoiceDetail.quantity AS [Số lượng], dbo.Product.price AS [Đơn giá], dbo.InvoiceDetail.amount AS [Thành tiền] FROM dbo.Customer JOIN dbo.Invoice ON dbo.Customer.id = dbo.Invoice.customerId JOIN dbo.InvoiceDetail ON dbo.Invoice.id = dbo.InvoiceDetail.invoiceId JOIN dbo.Product ON dbo.Product.id = dbo.InvoiceDetail.productId";
            dtgvContent.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
