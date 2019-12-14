namespace QuanLyQuanTraSua
{
    partial class fBaoCaoNgay
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDate.Location = new System.Drawing.Point(286, 86);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(582, 38);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.Value = new System.DateTime(2019, 12, 14, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDateOfBirth_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBack.Location = new System.Drawing.Point(3, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 68);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(28, 92);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(164, 32);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Chọn Ngày:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 360);
            this.dataGridView1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tổng Doanh Thu:";
            // 
            // txtbMoney
            // 
            this.txtbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMoney.Location = new System.Drawing.Point(286, 198);
            this.txtbMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbMoney.Multiline = true;
            this.txtbMoney.Name = "txtbMoney";
            this.txtbMoney.ReadOnly = true;
            this.txtbMoney.Size = new System.Drawing.Size(582, 41);
            this.txtbMoney.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Số hóa đơn:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbTotal.Location = new System.Drawing.Point(286, 142);
            this.txtbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbTotal.Multiline = true;
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.ReadOnly = true;
            this.txtbTotal.Size = new System.Drawing.Size(582, 41);
            this.txtbTotal.TabIndex = 33;
            // 
            // fBaoCaoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 623);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpDate);
            this.Name = "fBaoCaoNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBaoCaoNgay";
            this.Load += new System.EventHandler(this.FBaoCaoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTotal;
    }
}