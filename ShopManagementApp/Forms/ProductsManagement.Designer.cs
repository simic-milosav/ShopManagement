
namespace ShopManagementApp
{
    partial class ProductsManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbKids = new System.Windows.Forms.RadioButton();
            this.rbFootwear = new System.Windows.Forms.RadioButton();
            this.rbClothing = new System.Windows.Forms.RadioButton();
            this.gb_Type = new System.Windows.Forms.GroupBox();
            this.gb_Subtype = new System.Windows.Forms.GroupBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_Type.SuspendLayout();
            this.gb_Subtype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subtype:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Discount %:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stock:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(687, 44);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 61);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(823, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 61);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(952, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 61);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(901, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(761, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 15;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "NIKE",
            "ADIDAS",
            "REEBOK",
            "PUMA",
            "UNDER ARMOUR",
            "NEW BALANCE"});
            this.cbBrand.Location = new System.Drawing.Point(391, 21);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(188, 24);
            this.cbBrand.TabIndex = 16;
            this.cbBrand.Validating += new System.ComponentModel.CancelEventHandler(this.cbBrand_Validating);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(16, 17);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 17;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(81, 17);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbKids
            // 
            this.rbKids.AutoSize = true;
            this.rbKids.Location = new System.Drawing.Point(162, 17);
            this.rbKids.Name = "rbKids";
            this.rbKids.Size = new System.Drawing.Size(56, 21);
            this.rbKids.TabIndex = 19;
            this.rbKids.TabStop = true;
            this.rbKids.Text = "Kids";
            this.rbKids.UseVisualStyleBackColor = true;
            this.rbKids.CheckedChanged += new System.EventHandler(this.rbKids_CheckedChanged);
            // 
            // rbFootwear
            // 
            this.rbFootwear.AutoSize = true;
            this.rbFootwear.Location = new System.Drawing.Point(10, 12);
            this.rbFootwear.Name = "rbFootwear";
            this.rbFootwear.Size = new System.Drawing.Size(87, 21);
            this.rbFootwear.TabIndex = 20;
            this.rbFootwear.TabStop = true;
            this.rbFootwear.Text = "Footwear";
            this.rbFootwear.UseVisualStyleBackColor = true;
            this.rbFootwear.CheckedChanged += new System.EventHandler(this.rbFootwear_CheckedChanged);
            // 
            // rbClothing
            // 
            this.rbClothing.AutoSize = true;
            this.rbClothing.Location = new System.Drawing.Point(114, 12);
            this.rbClothing.Name = "rbClothing";
            this.rbClothing.Size = new System.Drawing.Size(80, 21);
            this.rbClothing.TabIndex = 21;
            this.rbClothing.TabStop = true;
            this.rbClothing.Text = "Clothing";
            this.rbClothing.UseVisualStyleBackColor = true;
            this.rbClothing.CheckedChanged += new System.EventHandler(this.rbClothing_CheckedChanged);
            // 
            // gb_Type
            // 
            this.gb_Type.Controls.Add(this.rbKids);
            this.gb_Type.Controls.Add(this.rbFemale);
            this.gb_Type.Controls.Add(this.rbMale);
            this.gb_Type.Location = new System.Drawing.Point(67, 77);
            this.gb_Type.Name = "gb_Type";
            this.gb_Type.Size = new System.Drawing.Size(231, 46);
            this.gb_Type.TabIndex = 23;
            this.gb_Type.TabStop = false;
            this.gb_Type.Validating += new System.ComponentModel.CancelEventHandler(this.gb_Type_Validating);
            // 
            // gb_Subtype
            // 
            this.gb_Subtype.Controls.Add(this.rbFootwear);
            this.gb_Subtype.Controls.Add(this.rbClothing);
            this.gb_Subtype.Location = new System.Drawing.Point(82, 125);
            this.gb_Subtype.Name = "gb_Subtype";
            this.gb_Subtype.Size = new System.Drawing.Size(200, 40);
            this.gb_Subtype.TabIndex = 24;
            this.gb_Subtype.TabStop = false;
            this.gb_Subtype.Validating += new System.ComponentModel.CancelEventHandler(this.gb_Subtype_Validating);
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "WHITE",
            "BLACK",
            "YELLOW",
            "RED",
            "BLUE",
            "GREEN",
            "ORANGE",
            "PURPLE",
            "PINK"});
            this.cbColor.Location = new System.Drawing.Point(391, 53);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(188, 24);
            this.cbColor.TabIndex = 25;
            this.cbColor.Validating += new System.ComponentModel.CancelEventHandler(this.cbColor_Validating);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(67, 171);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(188, 24);
            this.cbSize.TabIndex = 26;
            this.cbSize.Validating += new System.ComponentModel.CancelEventHandler(this.cbSize_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(391, 90);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(188, 22);
            this.txtPrice.TabIndex = 27;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(416, 122);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(163, 22);
            this.txtDiscount.TabIndex = 28;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(391, 164);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(188, 22);
            this.txtStock.TabIndex = 29;
            this.txtStock.Validating += new System.ComponentModel.CancelEventHandler(this.txtStock_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(229, 287);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(645, 22);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(12, 327);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 24;
            this.dgv_Product.Size = new System.Drawing.Size(1056, 435);
            this.dgv_Product.TabIndex = 32;
            this.dgv_Product.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Product_MouseClick);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(94, 18);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(188, 22);
            this.txtProductId.TabIndex = 34;
            this.txtProductId.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductId_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Product ID:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 774);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.gb_Subtype);
            this.Controls.Add(this.gb_Type);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsManagement";
            this.Text = "ProductsManagement";
            this.Load += new System.EventHandler(this.ProductsManagement_Load);
            this.gb_Type.ResumeLayout(false);
            this.gb_Type.PerformLayout();
            this.gb_Subtype.ResumeLayout(false);
            this.gb_Subtype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbKids;
        private System.Windows.Forms.RadioButton rbFootwear;
        private System.Windows.Forms.RadioButton rbClothing;
        private System.Windows.Forms.GroupBox gb_Type;
        private System.Windows.Forms.GroupBox gb_Subtype;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}