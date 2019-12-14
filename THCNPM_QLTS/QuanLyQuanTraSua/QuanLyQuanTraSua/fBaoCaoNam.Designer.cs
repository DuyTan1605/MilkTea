namespace QuanLyQuanTraSua
{
    partial class fBaoCaoNam
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbYear = new System.Windows.Forms.TextBox();
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
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 68);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(593, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 54);
            this.button1.TabIndex = 43;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Năm:";
            // 
            // txtbYear
            // 
            this.txtbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbYear.Location = new System.Drawing.Point(315, 97);
            this.txtbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbYear.Multiline = true;
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.Size = new System.Drawing.Size(232, 41);
            this.txtbYear.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Số hóa đơn:";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbTotal.Location = new System.Drawing.Point(315, 159);
            this.txtbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbTotal.Multiline = true;
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.ReadOnly = true;
            this.txtbTotal.Size = new System.Drawing.Size(582, 41);
            this.txtbTotal.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tổng Doanh Thu:";
            // 
            // txtbMoney
            // 
            this.txtbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMoney.Location = new System.Drawing.Point(315, 225);
            this.txtbMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbMoney.Multiline = true;
            this.txtbMoney.Name = "txtbMoney";
            this.txtbMoney.ReadOnly = true;
            this.txtbMoney.Size = new System.Drawing.Size(582, 41);
            this.txtbMoney.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 360);
            this.dataGridView1.TabIndex = 50;
            // 
            // fBaoCaoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Name = "fBaoCaoNam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBaoCaoNam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbMoney;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}