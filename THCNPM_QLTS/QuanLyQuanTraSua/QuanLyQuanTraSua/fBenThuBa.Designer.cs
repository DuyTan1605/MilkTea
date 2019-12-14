namespace QuanLyQuanTraSua
{
    partial class fBenThuBa
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbMoney = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(4, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 68);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Số hóa đơn:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbTotal.Location = new System.Drawing.Point(292, 90);
            this.txtbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbTotal.Multiline = true;
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.ReadOnly = true;
            this.txtbTotal.Size = new System.Drawing.Size(582, 41);
            this.txtbTotal.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tổng Doanh Thu:";
            // 
            // txtbMoney
            // 
            this.txtbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMoney.Location = new System.Drawing.Point(292, 172);
            this.txtbMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbMoney.Multiline = true;
            this.txtbMoney.Name = "txtbMoney";
            this.txtbMoney.ReadOnly = true;
            this.txtbMoney.Size = new System.Drawing.Size(582, 41);
            this.txtbMoney.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 360);
            this.dataGridView1.TabIndex = 41;
            // 
            // fBenThuBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Name = "fBenThuBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBenThuBa";
            this.Load += new System.EventHandler(this.FBenThuBa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMoney;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}