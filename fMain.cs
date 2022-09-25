using QuanLyNhaKhoa.DAO;
using QuanLyNhaKhoa.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKhoa
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            // tạo column cho dtgvCustomerList
            dtgvCustomerList.Columns.Add("id", "Mã khách hàng");
            dtgvCustomerList.Columns.Add("name", "Họ và tên");
            dtgvCustomerList.Columns.Add("gender", "Giới tính");
            dtgvCustomerList.Columns.Add("dayOfBirth", "Ngày sinh");
            dtgvCustomerList.Columns.Add("telephone", "Số điện thoại");
            dtgvCustomerList.Columns.Add("email", "Địa chỉ Email");
            dtgvCustomerList.Columns.Add("identifyCard", "CMND/CCCD");
            // tạo column cho dtgvInvoiceList
            dtgvInvoiceList.Columns.Add("invoiceNo", "Mã số hoá đơn");
            dtgvInvoiceList.Columns.Add("invoiceDate", "Ngày lập hoá đơn");
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (dtgvCustomerList.Rows.Count > 0)
            {
                dtgvCustomerList.Rows.Clear();
                List<Customer> customerList = CustomerDAO.Instance.LoadCustomerList();
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

                    dtgvCustomerList.Rows.Add(item.Id, item.Name, gender, item.DayOfBirth, item.Telephone, item.Email, item.IdentifyCard);
                }
            }
        }

        private void dtgvCustomerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvInvoiceList.Rows.Count > 0)
            {
                dtgvInvoiceList.Rows.Clear();
                foreach (DataGridViewRow row in dtgvCustomerList.SelectedRows)
                {
                    string customerId = row.Cells[0].Value.ToString();
                    List<Invoice> invoiceList = InvoiceDAO.Instance.GetInvoiceListByCustomerId(customerId);
                    foreach (Invoice item in invoiceList)
                    {
                        dtgvInvoiceList.Rows.Add(item.InvoiceNo, item.InvoiceDate);
                    }
                }
            }
        }
    }
}
