namespace QuanLyQuanTraSua
{
    partial class fTinhTrangKho
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDayImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(313, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm/ nguyên liệu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 84);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(1143, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtbSearch.Location = new System.Drawing.Point(253, 11);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(717, 38);
            this.txtbSearch.TabIndex = 1;
            this.txtbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIDMaterial,
            this.txtNameMaterial,
            this.txtComeFrom,
            this.txtDayImport,
            this.txtStatus,
            this.Xóa});
            this.dataGridView1.Location = new System.Drawing.Point(16, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 612);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // txtIDMaterial
            // 
            this.txtIDMaterial.DataPropertyName = "IDMaterial";
            this.txtIDMaterial.HeaderText = "Mã nguyên liệu";
            this.txtIDMaterial.MinimumWidth = 6;
            this.txtIDMaterial.Name = "txtIDMaterial";
            this.txtIDMaterial.Width = 150;
            // 
            // txtNameMaterial
            // 
            this.txtNameMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNameMaterial.DataPropertyName = "NameMaterial";
            this.txtNameMaterial.HeaderText = "Tên nguyên liệu";
            this.txtNameMaterial.MinimumWidth = 8;
            this.txtNameMaterial.Name = "txtNameMaterial";
            // 
            // txtComeFrom
            // 
            this.txtComeFrom.DataPropertyName = "ComeFrom";
            this.txtComeFrom.HeaderText = "Xuất xứ";
            this.txtComeFrom.MinimumWidth = 6;
            this.txtComeFrom.Name = "txtComeFrom";
            this.txtComeFrom.Width = 200;
            // 
            // txtDayImport
            // 
            this.txtDayImport.DataPropertyName = "DayImport";
            this.txtDayImport.HeaderText = "Ngày nhập gần nhất";
            this.txtDayImport.MinimumWidth = 6;
            this.txtDayImport.Name = "txtDayImport";
            this.txtDayImport.Width = 175;
            // 
            // txtStatus
            // 
            this.txtStatus.DataPropertyName = "Status";
            this.txtStatus.HeaderText = "Tình trạng";
            this.txtStatus.MinimumWidth = 6;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Width = 175;
            // 
            // Xóa
            // 
            this.Xóa.DataPropertyName = "delete";
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.MinimumWidth = 6;
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xóa";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Width = 125;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 5;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(16, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 66);
            this.button7.TabIndex = 8;
            this.button7.Text = "QUAY LẠI";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // fTinhTrangKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 882);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTinhTrangKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTinhTrangKho";
            this.Activated += new System.EventHandler(this.fTinhTrangKho_Activated);
            this.Load += new System.EventHandler(this.FTinhTrangKho_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIDMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNameMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDayImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}