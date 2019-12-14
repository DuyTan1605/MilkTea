namespace QuanLyQuanTraSua
{
    partial class fThemNguyenLieu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.lbAccumulatedPoints = new System.Windows.Forms.Label();
            this.dtpDateImport = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.txtbAddressImport = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1345, 63);
            this.panel3.TabIndex = 37;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Location = new System.Drawing.Point(9, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 49);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtbStatus);
            this.panel4.Controls.Add(this.lbAccumulatedPoints);
            this.panel4.Controls.Add(this.dtpDateImport);
            this.panel4.Controls.Add(this.lbDateOfBirth);
            this.panel4.Controls.Add(this.txtbAddressImport);
            this.panel4.Controls.Add(this.lbPhone);
            this.panel4.Controls.Add(this.txtbName);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Location = new System.Drawing.Point(5, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1343, 524);
            this.panel4.TabIndex = 38;
            // 
            // txtbStatus
            // 
            this.txtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbStatus.Location = new System.Drawing.Point(231, 390);
            this.txtbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbStatus.Multiline = true;
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.Size = new System.Drawing.Size(1035, 40);
            this.txtbStatus.TabIndex = 27;
            // 
            // lbAccumulatedPoints
            // 
            this.lbAccumulatedPoints.AutoSize = true;
            this.lbAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccumulatedPoints.Location = new System.Drawing.Point(23, 398);
            this.lbAccumulatedPoints.Name = "lbAccumulatedPoints";
            this.lbAccumulatedPoints.Size = new System.Drawing.Size(143, 32);
            this.lbAccumulatedPoints.TabIndex = 26;
            this.lbAccumulatedPoints.Text = "Tình trạng";
            // 
            // dtpDateImport
            // 
            this.dtpDateImport.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDateImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDateImport.Location = new System.Drawing.Point(231, 295);
            this.dtpDateImport.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateImport.Name = "dtpDateImport";
            this.dtpDateImport.Size = new System.Drawing.Size(1035, 38);
            this.dtpDateImport.TabIndex = 25;
            this.dtpDateImport.Value = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(25, 302);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(160, 32);
            this.lbDateOfBirth.TabIndex = 24;
            this.lbDateOfBirth.Text = "Ngày nhập:";
            this.lbDateOfBirth.Click += new System.EventHandler(this.LbDateOfBirth_Click);
            // 
            // txtbAddressImport
            // 
            this.txtbAddressImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbAddressImport.Location = new System.Drawing.Point(231, 182);
            this.txtbAddressImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbAddressImport.Multiline = true;
            this.txtbAddressImport.Name = "txtbAddressImport";
            this.txtbAddressImport.Size = new System.Drawing.Size(1035, 41);
            this.txtbAddressImport.TabIndex = 21;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(25, 192);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(124, 32);
            this.lbPhone.TabIndex = 20;
            this.lbPhone.Text = "Xuất Xứ:";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbName.Location = new System.Drawing.Point(231, 78);
            this.txtbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbName.Multiline = true;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(1035, 41);
            this.txtbName.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(25, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 32);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Tên:";
            this.lbName.Click += new System.EventHandler(this.LbName_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Location = new System.Drawing.Point(3, 603);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 68);
            this.panel2.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(3, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 49);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDone.FlatAppearance.BorderSize = 5;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDone.Location = new System.Drawing.Point(1177, 16);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(165, 49);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Xong";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // fThemNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fThemNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThemNguyenLieu";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbStatus;
        private System.Windows.Forms.Label lbAccumulatedPoints;
        private System.Windows.Forms.DateTimePicker dtpDateImport;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.TextBox txtbAddressImport;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
    }
}