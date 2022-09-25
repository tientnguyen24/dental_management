
namespace QuanLyNhaKhoa
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassWord = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedicalSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.listViewInvoice = new System.Windows.Forms.ListView();
            this.pnlInvoiceList = new System.Windows.Forms.Panel();
            this.dtgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.pnlCustomerList = new System.Windows.Forms.Panel();
            this.dtgvCustomerList = new System.Windows.Forms.DataGridView();
            this.tabPageMedicalSchedule = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.tabPageStatistical = new System.Windows.Forms.TabPage();
            this.menuMain.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.pnlInvoiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceList)).BeginInit();
            this.pnlCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnMedicalSchedule,
            this.btnCustomer,
            this.btnReport});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1350, 27);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStripMain";
            // 
            // btnAccount
            // 
            this.btnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePassWord,
            this.btnLogout});
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(78, 23);
            this.btnAccount.Text = "Tài khoản";
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(161, 24);
            this.btnChangePassWord.Text = "Đổi mật khẩu";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 24);
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMedicalSchedule
            // 
            this.btnMedicalSchedule.Name = "btnMedicalSchedule";
            this.btnMedicalSchedule.Size = new System.Drawing.Size(72, 23);
            this.btnMedicalSchedule.Text = "Lịch hẹn";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(93, 23);
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 23);
            this.btnReport.Text = "Báo cáo - Thống kê";
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPageCustomer);
            this.tabCtrlMain.Controls.Add(this.tabPageMedicalSchedule);
            this.tabCtrlMain.Controls.Add(this.tabPageReport);
            this.tabCtrlMain.Controls.Add(this.tabPageStatistical);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 27);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1350, 702);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.listViewInvoice);
            this.tabPageCustomer.Controls.Add(this.pnlInvoiceList);
            this.tabPageCustomer.Controls.Add(this.pnlCustomerList);
            this.tabPageCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Size = new System.Drawing.Size(1342, 676);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Khách hàng";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // listViewInvoice
            // 
            this.listViewInvoice.HideSelection = false;
            this.listViewInvoice.Location = new System.Drawing.Point(822, 307);
            this.listViewInvoice.Name = "listViewInvoice";
            this.listViewInvoice.Size = new System.Drawing.Size(517, 366);
            this.listViewInvoice.TabIndex = 2;
            this.listViewInvoice.UseCompatibleStateImageBehavior = false;
            // 
            // pnlInvoiceList
            // 
            this.pnlInvoiceList.Controls.Add(this.dtgvInvoiceList);
            this.pnlInvoiceList.Location = new System.Drawing.Point(822, 0);
            this.pnlInvoiceList.Name = "pnlInvoiceList";
            this.pnlInvoiceList.Size = new System.Drawing.Size(524, 300);
            this.pnlInvoiceList.TabIndex = 1;
            // 
            // dtgvInvoiceList
            // 
            this.dtgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.dtgvInvoiceList.Name = "dtgvInvoiceList";
            this.dtgvInvoiceList.Size = new System.Drawing.Size(524, 300);
            this.dtgvInvoiceList.TabIndex = 0;
            // 
            // pnlCustomerList
            // 
            this.pnlCustomerList.Controls.Add(this.dtgvCustomerList);
            this.pnlCustomerList.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerList.Name = "pnlCustomerList";
            this.pnlCustomerList.Size = new System.Drawing.Size(815, 674);
            this.pnlCustomerList.TabIndex = 0;
            // 
            // dtgvCustomerList
            // 
            this.dtgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCustomerList.Location = new System.Drawing.Point(0, 0);
            this.dtgvCustomerList.Name = "dtgvCustomerList";
            this.dtgvCustomerList.Size = new System.Drawing.Size(815, 674);
            this.dtgvCustomerList.TabIndex = 0;
            this.dtgvCustomerList.SelectionChanged += new System.EventHandler(this.dtgvCustomerList_SelectionChanged);
            // 
            // tabPageMedicalSchedule
            // 
            this.tabPageMedicalSchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMedicalSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedicalSchedule.Name = "tabPageMedicalSchedule";
            this.tabPageMedicalSchedule.Size = new System.Drawing.Size(1342, 676);
            this.tabPageMedicalSchedule.TabIndex = 1;
            this.tabPageMedicalSchedule.Text = "Lịch hẹn";
            this.tabPageMedicalSchedule.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(1342, 676);
            this.tabPageReport.TabIndex = 2;
            this.tabPageReport.Text = "Báo cáo";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // tabPageStatistical
            // 
            this.tabPageStatistical.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStatistical.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistical.Name = "tabPageStatistical";
            this.tabPageStatistical.Size = new System.Drawing.Size(1342, 676);
            this.tabPageStatistical.TabIndex = 3;
            this.tabPageStatistical.Text = "Thống kê";
            this.tabPageStatistical.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.menuMain);
            this.Name = "fMain";
            this.Text = "Nha Khoa Thuần Việt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.pnlInvoiceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoiceList)).EndInit();
            this.pnlCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassWord;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnMedicalSchedule;
        private System.Windows.Forms.ToolStripMenuItem btnCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageMedicalSchedule;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.TabPage tabPageStatistical;
        private System.Windows.Forms.Panel pnlCustomerList;
        private System.Windows.Forms.DataGridView dtgvCustomerList;
        private System.Windows.Forms.Panel pnlInvoiceList;
        private System.Windows.Forms.DataGridView dtgvInvoiceList;
        private System.Windows.Forms.ListView listViewInvoice;
    }
}