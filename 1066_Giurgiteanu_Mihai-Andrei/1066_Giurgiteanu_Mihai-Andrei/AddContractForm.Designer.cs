namespace _1066_Giurgiteanu_Mihai_Andrei
{
    partial class AddContractForm
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
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGood = new System.Windows.Forms.ComboBox();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Good: ";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DataSource = this.supplierBindingSource;
            this.cbSupplier.DisplayMember = "nameSupplier";
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(12, 25);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(156, 21);
            this.cbSupplier.TabIndex = 2;
            this.cbSupplier.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(_1066_Giurgiteanu_Mihai_Andrei.Entities.Supplier);
            // 
            // cbGood
            // 
            this.cbGood.DataSource = this.goodBindingSource;
            this.cbGood.DisplayMember = "nameGood";
            this.cbGood.FormattingEnabled = true;
            this.cbGood.Location = new System.Drawing.Point(12, 65);
            this.cbGood.Name = "cbGood";
            this.cbGood.Size = new System.Drawing.Size(156, 21);
            this.cbGood.TabIndex = 3;
            this.cbGood.ValueMember = "Id";
            this.cbGood.SelectedIndexChanged += new System.EventHandler(this.cbGood_SelectedIndexChanged);
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataSource = typeof(_1066_Giurgiteanu_Mihai_Andrei.Entities.Good);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(93, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price per item:";
            // 
            // tbPrice
            // 
            this.tbPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodBindingSource, "pricePerGood", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPrice.Location = new System.Drawing.Point(12, 105);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(156, 20);
            this.tbPrice.TabIndex = 9;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 213);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGood);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContractForm";
            this.Text = "AddContractForm";
            this.Load += new System.EventHandler(this.AddContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbGood;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrice;
    }
}