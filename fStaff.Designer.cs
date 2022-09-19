
namespace QuanLyNhaKhoa
{
    partial class fStaff
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pnlMainInfo = new System.Windows.Forms.Panel();
            this.pnlActionSchedule = new System.Windows.Forms.Panel();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.dtgvContent = new System.Windows.Forms.DataGridView();
            this.flwPnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnMedicalRecord = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlShortInfoStaff = new System.Windows.Forms.Panel();
            this.lbShortInfoStaff = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlMainInfo.SuspendLayout();
            this.pnlActionSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContent)).BeginInit();
            this.flwPnlMenu.SuspendLayout();
            this.pnlShortInfoStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txbSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(499, 42);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(411, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(5, 10);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(400, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // pnlMainInfo
            // 
            this.pnlMainInfo.Controls.Add(this.pnlActionSchedule);
            this.pnlMainInfo.Controls.Add(this.dtgvContent);
            this.pnlMainInfo.Controls.Add(this.pnlSearch);
            this.pnlMainInfo.Location = new System.Drawing.Point(219, 12);
            this.pnlMainInfo.Name = "pnlMainInfo";
            this.pnlMainInfo.Size = new System.Drawing.Size(1119, 705);
            this.pnlMainInfo.TabIndex = 2;
            // 
            // pnlActionSchedule
            // 
            this.pnlActionSchedule.Controls.Add(this.btnDeleteSchedule);
            this.pnlActionSchedule.Controls.Add(this.btnAddSchedule);
            this.pnlActionSchedule.Location = new System.Drawing.Point(844, 3);
            this.pnlActionSchedule.Name = "pnlActionSchedule";
            this.pnlActionSchedule.Size = new System.Drawing.Size(272, 42);
            this.pnlActionSchedule.TabIndex = 2;
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSchedule.Location = new System.Drawing.Point(180, 6);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(81, 29);
            this.btnDeleteSchedule.TabIndex = 5;
            this.btnDeleteSchedule.Text = "Xoá";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Location = new System.Drawing.Point(93, 6);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(81, 29);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "Thêm";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // dtgvContent
            // 
            this.dtgvContent.AllowUserToOrderColumns = true;
            this.dtgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvContent.Location = new System.Drawing.Point(8, 52);
            this.dtgvContent.Name = "dtgvContent";
            this.dtgvContent.Size = new System.Drawing.Size(1108, 650);
            this.dtgvContent.TabIndex = 0;
            // 
            // flwPnlMenu
            // 
            this.flwPnlMenu.Controls.Add(this.btnSchedule);
            this.flwPnlMenu.Controls.Add(this.btnMedicalRecord);
            this.flwPnlMenu.Controls.Add(this.btnCustomerSupport);
            this.flwPnlMenu.Controls.Add(this.btnStatistical);
            this.flwPnlMenu.Controls.Add(this.btnLogout);
            this.flwPnlMenu.Location = new System.Drawing.Point(13, 61);
            this.flwPnlMenu.Name = "flwPnlMenu";
            this.flwPnlMenu.Size = new System.Drawing.Size(200, 656);
            this.flwPnlMenu.TabIndex = 3;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(3, 3);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(190, 50);
            this.btnSchedule.TabIndex = 1;
            this.btnSchedule.Text = "Lịch khám bệnh";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnMedicalRecord
            // 
            this.btnMedicalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalRecord.Location = new System.Drawing.Point(3, 59);
            this.btnMedicalRecord.Name = "btnMedicalRecord";
            this.btnMedicalRecord.Size = new System.Drawing.Size(190, 50);
            this.btnMedicalRecord.TabIndex = 2;
            this.btnMedicalRecord.Text = "Hồ sơ bệnh án";
            this.btnMedicalRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSupport.Location = new System.Drawing.Point(3, 115);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(190, 50);
            this.btnCustomerSupport.TabIndex = 3;
            this.btnCustomerSupport.Text = "Chăm sóc khách hàng";
            this.btnCustomerSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerSupport.UseVisualStyleBackColor = true;
            this.btnCustomerSupport.Click += new System.EventHandler(this.btnCustomerSupport_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.Location = new System.Drawing.Point(3, 171);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(190, 50);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(3, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlShortInfoStaff
            // 
            this.pnlShortInfoStaff.Controls.Add(this.lbShortInfoStaff);
            this.pnlShortInfoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShortInfoStaff.Location = new System.Drawing.Point(13, 12);
            this.pnlShortInfoStaff.Name = "pnlShortInfoStaff";
            this.pnlShortInfoStaff.Size = new System.Drawing.Size(200, 43);
            this.pnlShortInfoStaff.TabIndex = 4;
            // 
            // lbShortInfoStaff
            // 
            this.lbShortInfoStaff.AutoSize = true;
            this.lbShortInfoStaff.Location = new System.Drawing.Point(5, 10);
            this.lbShortInfoStaff.Name = "lbShortInfoStaff";
            this.lbShortInfoStaff.Size = new System.Drawing.Size(77, 20);
            this.lbShortInfoStaff.TabIndex = 0;
            this.lbShortInfoStaff.Text = "Họ và tên";
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlShortInfoStaff);
            this.Controls.Add(this.flwPnlMenu);
            this.Controls.Add(this.pnlMainInfo);
            this.Name = "fStaff";
            this.Text = "Nha Khoa Thuần Việt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fStaff_FormClosing);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMainInfo.ResumeLayout(false);
            this.pnlActionSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvContent)).EndInit();
            this.flwPnlMenu.ResumeLayout(false);
            this.pnlShortInfoStaff.ResumeLayout(false);
            this.pnlShortInfoStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlMainInfo;
        private System.Windows.Forms.FlowLayoutPanel flwPnlMenu;
        private System.Windows.Forms.Panel pnlShortInfoStaff;
        private System.Windows.Forms.Label lbShortInfoStaff;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnMedicalRecord;
        private System.Windows.Forms.Button btnCustomerSupport;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.DataGridView dtgvContent;
        private System.Windows.Forms.Panel pnlActionSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnLogout;
    }
}