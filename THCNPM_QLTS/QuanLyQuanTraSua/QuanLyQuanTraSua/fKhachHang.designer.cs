namespace QuanLyQuanTraSua
{
    partial class fKhachHang
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbListCLoseCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCloseCustomer = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtbSeach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 632);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbListCLoseCustomer);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(11, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 64);
            this.panel3.TabIndex = 37;
            // 
            // lbListCLoseCustomer
            // 
            this.lbListCLoseCustomer.AutoSize = true;
            this.lbListCLoseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListCLoseCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbListCLoseCustomer.Location = new System.Drawing.Point(440, 10);
            this.lbListCLoseCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListCLoseCustomer.Name = "lbListCLoseCustomer";
            this.lbListCLoseCustomer.Size = new System.Drawing.Size(525, 39);
            this.lbListCLoseCustomer.TabIndex = 20;
            this.lbListCLoseCustomer.Text = "Danh sách thành viên thân thiết";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Location = new System.Drawing.Point(-2, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 59);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddCloseCustomer);
            this.panel2.Controls.Add(this.lbSearch);
            this.panel2.Controls.Add(this.txtbSeach);
            this.panel2.Location = new System.Drawing.Point(2, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 70);
            this.panel2.TabIndex = 36;
            // 
            // btnAddCloseCustomer
            // 
            this.btnAddCloseCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCloseCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCloseCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCloseCustomer.FlatAppearance.BorderSize = 5;
            this.btnAddCloseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCloseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCloseCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddCloseCustomer.Location = new System.Drawing.Point(601, 3);
            this.btnAddCloseCustomer.Name = "btnAddCloseCustomer";
            this.btnAddCloseCustomer.Size = new System.Drawing.Size(136, 55);
            this.btnAddCloseCustomer.TabIndex = 0;
            this.btnAddCloseCustomer.Text = "thêm";
            this.btnAddCloseCustomer.UseVisualStyleBackColor = true;
            this.btnAddCloseCustomer.Click += new System.EventHandler(this.btnAddCloseCustomer_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbSearch.Location = new System.Drawing.Point(3, 11);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(137, 32);
            this.lbSearch.TabIndex = 20;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // txtbSeach
            // 
            this.txtbSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbSeach.Location = new System.Drawing.Point(154, 11);
            this.txtbSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSeach.Multiline = true;
            this.txtbSeach.Name = "txtbSeach";
            this.txtbSeach.Size = new System.Drawing.Size(338, 44);
            this.txtbSeach.TabIndex = 21;
            this.txtbSeach.TextChanged += new System.EventHandler(this.TxtbSeach_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCustomerID,
            this.txtCustomerName,
            this.txtCustomerAddress,
            this.txtCustomerBirthday,
            this.txtCustomerPhone,
            this.txtCustomerType,
            this.txtCustomerEmail,
            this.txtCustomerPoint,
            this.Xóa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 407);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataPropertyName = "CustomerID";
            this.txtCustomerID.HeaderText = "ID";
            this.txtCustomerID.MinimumWidth = 6;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Width = 50;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.DataPropertyName = "CustomerName";
            this.txtCustomerName.HeaderText = "Họ tên";
            this.txtCustomerName.MinimumWidth = 6;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Width = 125;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.DataPropertyName = "CustomerAddress";
            this.txtCustomerAddress.HeaderText = "Địa Chỉ";
            this.txtCustomerAddress.MinimumWidth = 6;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Width = 125;
            // 
            // txtCustomerBirthday
            // 
            this.txtCustomerBirthday.DataPropertyName = "CustomerBirthday";
            this.txtCustomerBirthday.HeaderText = "Ngày sinh";
            this.txtCustomerBirthday.MinimumWidth = 6;
            this.txtCustomerBirthday.Name = "txtCustomerBirthday";
            this.txtCustomerBirthday.Width = 125;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.DataPropertyName = "CustomerPhone";
            this.txtCustomerPhone.HeaderText = "SĐT";
            this.txtCustomerPhone.MinimumWidth = 6;
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Width = 125;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.DataPropertyName = "CustomerType";
            this.txtCustomerType.HeaderText = "Loại khách hàng";
            this.txtCustomerType.MinimumWidth = 6;
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Width = 125;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.DataPropertyName = "CustomerEmail";
            this.txtCustomerEmail.HeaderText = "Email";
            this.txtCustomerEmail.MinimumWidth = 6;
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Width = 125;
            // 
            // txtCustomerPoint
            // 
            this.txtCustomerPoint.DataPropertyName = "CustomerPoint";
            this.txtCustomerPoint.HeaderText = "Điểm tích lũy";
            this.txtCustomerPoint.MinimumWidth = 6;
            this.txtCustomerPoint.Name = "txtCustomerPoint";
            this.txtCustomerPoint.Width = 125;
            // 
            // Xóa
            // 
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.MinimumWidth = 6;
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Width = 125;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 632);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhachHang";
            this.Activated += new System.EventHandler(this.fKhachHang_Activated);
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbListCLoseCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCloseCustomer;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtbSeach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerPoint;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}