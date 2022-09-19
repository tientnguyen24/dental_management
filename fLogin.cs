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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLoginAccept_Click(object sender, EventArgs e)
        {
            string userName = txbLoginUserName.Text;
            string passWord = txbLoginPassWord.Text;
            if (AccountDAO.Instance.isEmpty(userName, passWord))
            {
                if (AccountDAO.Instance.isLogin(userName, passWord))
                {
                    fStaff fStaff = new fStaff();
                    this.Hide();
                    fStaff.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !!!", "Thông báo");
                }
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống !!!", "Thông báo");
            }

        }

        // thoát ứng dụng thông qua nút Thoát
        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // thoát ứng dụng thông qua nút X
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ứng dụng", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
