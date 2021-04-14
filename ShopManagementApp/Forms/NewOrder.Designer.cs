
namespace ShopManagementApp.Forms
{
    partial class NewOrder
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
            this.components = new System.ComponentModel.Container();
            this.gb_SelectCst = new System.Windows.Forms.GroupBox();
            this.rb_NewCst = new System.Windows.Forms.RadioButton();
            this.rb_ExCst = new System.Windows.Forms.RadioButton();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Products = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Free = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gb_ShpPrice = new System.Windows.Forms.GroupBox();
            this.txt_ShpPrice = new System.Windows.Forms.TextBox();
            this.rb_ChargeShp = new System.Windows.Forms.RadioButton();
            this.rb_FreeShp = new System.Windows.Forms.RadioButton();
            this.btn_PlaceOrd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.gb_NewCst = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SearchCst = new System.Windows.Forms.TextBox();
            this.btn_SelectCst = new System.Windows.Forms.Button();
            this.gb_SelectCst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).BeginInit();
            this.gb_ShpPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.gb_NewCst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SelectCst
            // 
            this.gb_SelectCst.Controls.Add(this.rb_NewCst);
            this.gb_SelectCst.Controls.Add(this.rb_ExCst);
            this.gb_SelectCst.Location = new System.Drawing.Point(179, 25);
            this.gb_SelectCst.Name = "gb_SelectCst";
            this.gb_SelectCst.Size = new System.Drawing.Size(694, 100);
            this.gb_SelectCst.TabIndex = 0;
            this.gb_SelectCst.TabStop = false;
            this.gb_SelectCst.Validating += new System.ComponentModel.CancelEventHandler(this.gb_SelectCst_Validating);
            // 
            // rb_NewCst
            // 
            this.rb_NewCst.AutoSize = true;
            this.rb_NewCst.Location = new System.Drawing.Point(528, 42);
            this.rb_NewCst.Name = "rb_NewCst";
            this.rb_NewCst.Size = new System.Drawing.Size(120, 21);
            this.rb_NewCst.TabIndex = 1;
            this.rb_NewCst.TabStop = true;
            this.rb_NewCst.Text = "New Customer";
            this.rb_NewCst.UseVisualStyleBackColor = true;
            this.rb_NewCst.CheckedChanged += new System.EventHandler(this.rb_ExCst_CheckedChanged);
            // 
            // rb_ExCst
            // 
            this.rb_ExCst.AutoSize = true;
            this.rb_ExCst.Location = new System.Drawing.Point(27, 42);
            this.rb_ExCst.Name = "rb_ExCst";
            this.rb_ExCst.Size = new System.Drawing.Size(141, 21);
            this.rb_ExCst.TabIndex = 0;
            this.rb_ExCst.TabStop = true;
            this.rb_ExCst.Text = "Existing Customer";
            this.rb_ExCst.UseVisualStyleBackColor = true;
            this.rb_ExCst.CheckedChanged += new System.EventHandler(this.rb_ExCst_CheckedChanged);
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "BRONZE",
            "SILVER",
            "GOLD"});
            this.cBoxType.Location = new System.Drawing.Point(153, 229);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(290, 24);
            this.cBoxType.TabIndex = 25;
            this.cBoxType.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxType_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(153, 150);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(290, 22);
            this.txtPhoneNum.TabIndex = 17;
            this.txtPhoneNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNum_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(153, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 22);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(153, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(290, 22);
            this.txtSurname.TabIndex = 15;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 22);
            this.txtName.TabIndex = 14;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(365, 444);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(478, 22);
            this.txt_Search.TabIndex = 26;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Search:";
            // 
            // dgv_Products
            // 
            this.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.Free});
            this.dgv_Products.Location = new System.Drawing.Point(302, 473);
            this.dgv_Products.Name = "dgv_Products";
            this.dgv_Products.RowHeadersWidth = 51;
            this.dgv_Products.RowTemplate.Height = 24;
            this.dgv_Products.Size = new System.Drawing.Size(584, 182);
            this.dgv_Products.TabIndex = 28;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // Free
            // 
            this.Free.HeaderText = "Free";
            this.Free.MinimumWidth = 6;
            this.Free.Name = "Free";
            this.Free.Width = 125;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(892, 513);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 94);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Add products to order";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gb_ShpPrice
            // 
            this.gb_ShpPrice.Controls.Add(this.txt_ShpPrice);
            this.gb_ShpPrice.Controls.Add(this.rb_ChargeShp);
            this.gb_ShpPrice.Controls.Add(this.rb_FreeShp);
            this.gb_ShpPrice.Location = new System.Drawing.Point(12, 507);
            this.gb_ShpPrice.Name = "gb_ShpPrice";
            this.gb_ShpPrice.Size = new System.Drawing.Size(283, 100);
            this.gb_ShpPrice.TabIndex = 30;
            this.gb_ShpPrice.TabStop = false;
            this.gb_ShpPrice.Text = "Shipping Price";
            this.gb_ShpPrice.Validating += new System.ComponentModel.CancelEventHandler(this.gb_ShpPrice_Validating);
            // 
            // txt_ShpPrice
            // 
            this.txt_ShpPrice.Location = new System.Drawing.Point(146, 60);
            this.txt_ShpPrice.Name = "txt_ShpPrice";
            this.txt_ShpPrice.Size = new System.Drawing.Size(127, 22);
            this.txt_ShpPrice.TabIndex = 2;
            this.txt_ShpPrice.Visible = false;
            // 
            // rb_ChargeShp
            // 
            this.rb_ChargeShp.AutoSize = true;
            this.rb_ChargeShp.Location = new System.Drawing.Point(31, 60);
            this.rb_ChargeShp.Name = "rb_ChargeShp";
            this.rb_ChargeShp.Size = new System.Drawing.Size(97, 21);
            this.rb_ChargeShp.TabIndex = 1;
            this.rb_ChargeShp.TabStop = true;
            this.rb_ChargeShp.Text = "Charge (€)";
            this.rb_ChargeShp.UseVisualStyleBackColor = true;
            this.rb_ChargeShp.CheckedChanged += new System.EventHandler(this.rb_FreeShp_CheckedChanged);
            // 
            // rb_FreeShp
            // 
            this.rb_FreeShp.AutoSize = true;
            this.rb_FreeShp.Location = new System.Drawing.Point(31, 32);
            this.rb_FreeShp.Name = "rb_FreeShp";
            this.rb_FreeShp.Size = new System.Drawing.Size(58, 21);
            this.rb_FreeShp.TabIndex = 0;
            this.rb_FreeShp.TabStop = true;
            this.rb_FreeShp.Text = "Free";
            this.rb_FreeShp.UseVisualStyleBackColor = true;
            this.rb_FreeShp.CheckedChanged += new System.EventHandler(this.rb_FreeShp_CheckedChanged);
            // 
            // btn_PlaceOrd
            // 
            this.btn_PlaceOrd.Location = new System.Drawing.Point(77, 703);
            this.btn_PlaceOrd.Name = "btn_PlaceOrd";
            this.btn_PlaceOrd.Size = new System.Drawing.Size(908, 94);
            this.btn_PlaceOrd.TabIndex = 31;
            this.btn_PlaceOrd.Text = "PLACE ORDER";
            this.btn_PlaceOrd.UseVisualStyleBackColor = true;
            this.btn_PlaceOrd.Click += new System.EventHandler(this.btn_PlaceOrd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 675);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "TOTAL AMOUNT (€):";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(637, 680);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(17, 17);
            this.lbl_Total.TabIndex = 33;
            this.lbl_Total.Text = "0";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Customers.Location = new System.Drawing.Point(12, 162);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.RowHeadersWidth = 51;
            this.dgv_Customers.RowTemplate.Height = 24;
            this.dgv_Customers.Size = new System.Drawing.Size(513, 228);
            this.dgv_Customers.TabIndex = 34;
            // 
            // gb_NewCst
            // 
            this.gb_NewCst.Controls.Add(this.label1);
            this.gb_NewCst.Controls.Add(this.label2);
            this.gb_NewCst.Controls.Add(this.label3);
            this.gb_NewCst.Controls.Add(this.label4);
            this.gb_NewCst.Controls.Add(this.label5);
            this.gb_NewCst.Controls.Add(this.label6);
            this.gb_NewCst.Controls.Add(this.txtName);
            this.gb_NewCst.Controls.Add(this.txtSurname);
            this.gb_NewCst.Controls.Add(this.txtAddress);
            this.gb_NewCst.Controls.Add(this.txtPhoneNum);
            this.gb_NewCst.Controls.Add(this.cBoxType);
            this.gb_NewCst.Controls.Add(this.txtEmail);
            this.gb_NewCst.Location = new System.Drawing.Point(566, 148);
            this.gb_NewCst.Name = "gb_NewCst";
            this.gb_NewCst.Size = new System.Drawing.Size(471, 273);
            this.gb_NewCst.TabIndex = 35;
            this.gb_NewCst.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Search:";
            // 
            // txt_SearchCst
            // 
            this.txt_SearchCst.Location = new System.Drawing.Point(77, 139);
            this.txt_SearchCst.Name = "txt_SearchCst";
            this.txt_SearchCst.Size = new System.Drawing.Size(396, 22);
            this.txt_SearchCst.TabIndex = 37;
            this.txt_SearchCst.TextChanged += new System.EventHandler(this.txt_SearchCst_TextChanged);
            this.txt_SearchCst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchCst_KeyDown);
            // 
            // btn_SelectCst
            // 
            this.btn_SelectCst.Location = new System.Drawing.Point(30, 396);
            this.btn_SelectCst.Name = "btn_SelectCst";
            this.btn_SelectCst.Size = new System.Drawing.Size(145, 41);
            this.btn_SelectCst.TabIndex = 38;
            this.btn_SelectCst.Text = "Select Customer";
            this.btn_SelectCst.UseVisualStyleBackColor = true;
            this.btn_SelectCst.Click += new System.EventHandler(this.btn_SelectCst_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 809);
            this.Controls.Add(this.btn_SelectCst);
            this.Controls.Add(this.txt_SearchCst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb_NewCst);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_PlaceOrd);
            this.Controls.Add(this.gb_ShpPrice);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Products);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.gb_SelectCst);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.gb_SelectCst.ResumeLayout(false);
            this.gb_SelectCst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Products)).EndInit();
            this.gb_ShpPrice.ResumeLayout(false);
            this.gb_ShpPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.gb_NewCst.ResumeLayout(false);
            this.gb_NewCst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectCst;
        private System.Windows.Forms.RadioButton rb_NewCst;
        private System.Windows.Forms.RadioButton rb_ExCst;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Products;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox gb_ShpPrice;
        private System.Windows.Forms.TextBox txt_ShpPrice;
        private System.Windows.Forms.RadioButton rb_ChargeShp;
        private System.Windows.Forms.RadioButton rb_FreeShp;
        private System.Windows.Forms.Button btn_PlaceOrd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.GroupBox gb_NewCst;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txt_SearchCst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_SelectCst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Free;
    }
}