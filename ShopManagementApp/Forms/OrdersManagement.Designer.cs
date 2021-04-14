
namespace ShopManagementApp
{
    partial class OrdersManagement
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
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.rb_Preparing = new System.Windows.Forms.RadioButton();
            this.rb_Shipped = new System.Windows.Forms.RadioButton();
            this.rb_Delivered = new System.Windows.Forms.RadioButton();
            this.gb_Status = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_OrderDetails = new System.Windows.Forms.GroupBox();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.gb_Status.SuspendLayout();
            this.gb_OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToAddRows = false;
            this.dgv_Orders.AllowUserToDeleteRows = false;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Orders.Location = new System.Drawing.Point(242, 453);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.RowHeadersWidth = 51;
            this.dgv_Orders.RowTemplate.Height = 24;
            this.dgv_Orders.Size = new System.Drawing.Size(613, 261);
            this.dgv_Orders.TabIndex = 0;
            this.dgv_Orders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Orders_MouseClick);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(623, 12);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(113, 54);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "NEW";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(742, 12);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(113, 54);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(684, 72);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 25);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(803, 72);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 25);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(331, 420);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(474, 22);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // rb_Preparing
            // 
            this.rb_Preparing.AutoSize = true;
            this.rb_Preparing.Location = new System.Drawing.Point(48, 21);
            this.rb_Preparing.Name = "rb_Preparing";
            this.rb_Preparing.Size = new System.Drawing.Size(91, 21);
            this.rb_Preparing.TabIndex = 6;
            this.rb_Preparing.TabStop = true;
            this.rb_Preparing.Text = "Preparing";
            this.rb_Preparing.UseVisualStyleBackColor = true;
            // 
            // rb_Shipped
            // 
            this.rb_Shipped.AutoSize = true;
            this.rb_Shipped.Location = new System.Drawing.Point(48, 48);
            this.rb_Shipped.Name = "rb_Shipped";
            this.rb_Shipped.Size = new System.Drawing.Size(81, 21);
            this.rb_Shipped.TabIndex = 7;
            this.rb_Shipped.TabStop = true;
            this.rb_Shipped.Text = "Shipped";
            this.rb_Shipped.UseVisualStyleBackColor = true;
            // 
            // rb_Delivered
            // 
            this.rb_Delivered.AutoSize = true;
            this.rb_Delivered.Location = new System.Drawing.Point(48, 75);
            this.rb_Delivered.Name = "rb_Delivered";
            this.rb_Delivered.Size = new System.Drawing.Size(89, 21);
            this.rb_Delivered.TabIndex = 8;
            this.rb_Delivered.TabStop = true;
            this.rb_Delivered.Text = "Delivered";
            this.rb_Delivered.UseVisualStyleBackColor = true;
            // 
            // gb_Status
            // 
            this.gb_Status.Controls.Add(this.rb_Preparing);
            this.gb_Status.Controls.Add(this.rb_Delivered);
            this.gb_Status.Controls.Add(this.rb_Shipped);
            this.gb_Status.Location = new System.Drawing.Point(39, 12);
            this.gb_Status.Name = "gb_Status";
            this.gb_Status.Size = new System.Drawing.Size(200, 100);
            this.gb_Status.TabIndex = 9;
            this.gb_Status.TabStop = false;
            this.gb_Status.Text = "Status";
            this.gb_Status.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer:";
            this.label3.Visible = false;
            // 
            // gb_OrderDetails
            // 
            this.gb_OrderDetails.Controls.Add(this.dgv_Customer);
            this.gb_OrderDetails.Controls.Add(this.dgv_Products);
            this.gb_OrderDetails.Controls.Add(this.label2);
            this.gb_OrderDetails.Controls.Add(this.label3);
            this.gb_OrderDetails.Location = new System.Drawing.Point(12, 118);
            this.gb_OrderDetails.Name = "gb_OrderDetails";
            this.gb_OrderDetails.Size = new System.Drawing.Size(1043, 296);
            this.gb_OrderDetails.TabIndex = 15;
            this.gb_OrderDetails.TabStop = false;
            this.gb_OrderDetails.Visible = false;
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount});
            this.dgv_Products.Location = new System.Drawing.Point(6, 40);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 51;
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.Size = new System.Drawing.Size(1031, 132);
            this.dgv_Products.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Products:";
            this.label2.Visible = false;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(6, 204);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.ReadOnly = true;
            this.dgv_Customer.RowHeadersWidth = 51;
            this.dgv_Customer.RowTemplate.Height = 24;
            this.dgv_Customer.Size = new System.Drawing.Size(749, 86);
            this.dgv_Customer.TabIndex = 17;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(861, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(113, 54);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // OrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 726);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.gb_OrderDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Status);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.dgv_Orders);
            this.Name = "OrdersManagement";
            this.Text = "OrdersManagement";
            this.Load += new System.EventHandler(this.OrdersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.gb_Status.ResumeLayout(false);
            this.gb_Status.PerformLayout();
            this.gb_OrderDetails.ResumeLayout(false);
            this.gb_OrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.RadioButton rb_Preparing;
        private System.Windows.Forms.RadioButton rb_Shipped;
        private System.Windows.Forms.RadioButton rb_Delivered;
        private System.Windows.Forms.GroupBox gb_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_OrderDetails;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}