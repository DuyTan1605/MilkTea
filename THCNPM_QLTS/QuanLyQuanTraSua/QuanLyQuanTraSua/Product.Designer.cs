namespace QuanLyQuanTraSua
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbProductName);
            this.panel1.Controls.Add(this.picProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 168);
            this.panel1.TabIndex = 3;
            this.panel1.MouseEnter += new System.EventHandler(this.Product_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.Product_MouseLeave);
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.SystemColors.Control;
            this.tbProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProductName.Location = new System.Drawing.Point(0, 145);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(168, 15);
            this.tbProductName.TabIndex = 4;
            this.tbProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProductName.MouseEnter += new System.EventHandler(this.Product_MouseEnter);
            this.tbProductName.MouseLeave += new System.EventHandler(this.Product_MouseLeave);
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(8, 9);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(152, 128);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 3;
            this.picProduct.TabStop = false;
            this.picProduct.MouseEnter += new System.EventHandler(this.Product_MouseEnter);
            this.picProduct.MouseLeave += new System.EventHandler(this.Product_MouseLeave);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(168, 168);
            this.MouseEnter += new System.EventHandler(this.Product_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Product_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.PictureBox picProduct;
    }
}
