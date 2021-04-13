
namespace ShopManagementApp
{
    partial class ShopManagement
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
            this.btn_CusMng = new System.Windows.Forms.Button();
            this.btn_OrdMng = new System.Windows.Forms.Button();
            this.btn_ProMng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CusMng
            // 
            this.btn_CusMng.Location = new System.Drawing.Point(370, 81);
            this.btn_CusMng.Name = "btn_CusMng";
            this.btn_CusMng.Size = new System.Drawing.Size(329, 485);
            this.btn_CusMng.TabIndex = 1;
            this.btn_CusMng.Text = "CUSTOMERS MANAGEMENT";
            this.btn_CusMng.UseVisualStyleBackColor = true;
            this.btn_CusMng.Click += new System.EventHandler(this.btn_CusMng_Click);
            // 
            // btn_OrdMng
            // 
            this.btn_OrdMng.Location = new System.Drawing.Point(724, 81);
            this.btn_OrdMng.Name = "btn_OrdMng";
            this.btn_OrdMng.Size = new System.Drawing.Size(329, 485);
            this.btn_OrdMng.TabIndex = 2;
            this.btn_OrdMng.Text = "ORDERS MANAGEMENT";
            this.btn_OrdMng.UseVisualStyleBackColor = true;
            this.btn_OrdMng.Click += new System.EventHandler(this.btn_OrdMan_Click);
            // 
            // btn_ProMng
            // 
            this.btn_ProMng.Location = new System.Drawing.Point(12, 81);
            this.btn_ProMng.Name = "btn_ProMng";
            this.btn_ProMng.Size = new System.Drawing.Size(329, 485);
            this.btn_ProMng.TabIndex = 0;
            this.btn_ProMng.Text = "PRODUCTS MANAGEMENT";
            this.btn_ProMng.UseVisualStyleBackColor = true;
            this.btn_ProMng.Click += new System.EventHandler(this.btn_ProMng_Click);
            // 
            // ShopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 656);
            this.Controls.Add(this.btn_ProMng);
            this.Controls.Add(this.btn_OrdMng);
            this.Controls.Add(this.btn_CusMng);
            this.Name = "ShopManagement";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShopManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CusMng;
        private System.Windows.Forms.Button btn_OrdMng;
        private System.Windows.Forms.Button btn_ProMng;
    }
}

