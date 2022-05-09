namespace _1066_Giurgiteanu_Mihai_Andrei
{
    partial class GoodsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.dgvGood = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGood
            // 
            this.dgvGood.AutoGenerateColumns = false;
            this.dgvGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameGoodDataGridViewTextBoxColumn,
            this.pricePerGoodDataGridViewTextBoxColumn});
            this.dgvGood.DataSource = this.goodBindingSource;
            this.dgvGood.Location = new System.Drawing.Point(12, 57);
            this.dgvGood.Name = "dgvGood";
            this.dgvGood.Size = new System.Drawing.Size(775, 366);
            this.dgvGood.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameGoodDataGridViewTextBoxColumn
            // 
            this.nameGoodDataGridViewTextBoxColumn.DataPropertyName = "nameGood";
            this.nameGoodDataGridViewTextBoxColumn.HeaderText = "nameGood";
            this.nameGoodDataGridViewTextBoxColumn.Name = "nameGoodDataGridViewTextBoxColumn";
            // 
            // pricePerGoodDataGridViewTextBoxColumn
            // 
            this.pricePerGoodDataGridViewTextBoxColumn.DataPropertyName = "pricePerGood";
            this.pricePerGoodDataGridViewTextBoxColumn.HeaderText = "pricePerGood";
            this.pricePerGoodDataGridViewTextBoxColumn.Name = "pricePerGoodDataGridViewTextBoxColumn";
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataSource = typeof(_1066_Giurgiteanu_Mihai_Andrei.Entities.Good);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(712, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add / Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Goods:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(631, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(87, 20);
            this.toolStripSplitButton1.Text = "Other Pages";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mainPageToolStripMenuItem.Text = "Main Page";
            this.mainPageToolStripMenuItem.Click += new System.EventHandler(this.mainPageToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.goodsToolStripMenuItem.Text = "Contracts";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "Back";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGood);
            this.Name = "GoodsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}