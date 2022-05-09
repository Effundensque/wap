namespace _1066_Giurgiteanu_Mihai_Andrei
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.csmRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introduDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introduGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introduContracteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introduSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.csmRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameGoodDataGridViewTextBoxColumn,
            this.pricePerGoodDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.csmRightClick;
            this.dataGridView1.DataSource = this.goodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 120);
            this.dataGridView1.TabIndex = 0;
            // 
            // csmRightClick
            // 
            this.csmRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.csmRightClick.Name = "contextMenuStrip1";
            this.csmRightClick.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.csmRightClick.ShowImageMargin = false;
            this.csmRightClick.Size = new System.Drawing.Size(84, 48);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.serializeToolStripMenuItem.Text = "Binary";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.binaryToolStripMenuItem.Text = "Serialize";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asTextToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // asTextToolStripMenuItem
            // 
            this.asTextToolStripMenuItem.Name = "asTextToolStripMenuItem";
            this.asTextToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.asTextToolStripMenuItem.Text = "Text File";
            this.asTextToolStripMenuItem.Click += new System.EventHandler(this.asTextToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.goodIdDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.finalPriceDataGridViewTextBoxColumn});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.DataSource = this.contractBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 120);
            this.dataGridView2.TabIndex = 1;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.exportToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip2.ShowImageMargin = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(84, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem3.Text = "Binary";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem4.Text = "Serialize";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(83, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.textFileToolStripMenuItem.Text = "Text File";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameSupplierDataGridViewTextBoxColumn});
            this.dataGridView3.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView3.DataSource = this.supplierBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 322);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(776, 120);
            this.dataGridView3.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exportToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(84, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem1.Text = "Binary";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem2.Text = "Serialize";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // exportToolStripMenuItem2
            // 
            this.exportToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem1});
            this.exportToolStripMenuItem2.Name = "exportToolStripMenuItem2";
            this.exportToolStripMenuItem2.Size = new System.Drawing.Size(83, 22);
            this.exportToolStripMenuItem2.Text = "Export";
            // 
            // textFileToolStripMenuItem1
            // 
            this.textFileToolStripMenuItem1.Name = "textFileToolStripMenuItem1";
            this.textFileToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.textFileToolStripMenuItem1.Text = "Text File";
            this.textFileToolStripMenuItem1.Click += new System.EventHandler(this.textFileToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.introduDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // introduDateToolStripMenuItem
            // 
            this.introduDateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.introduDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.introduGoodsToolStripMenuItem,
            this.introduContracteToolStripMenuItem,
            this.introduSuppliersToolStripMenuItem});
            this.introduDateToolStripMenuItem.Name = "introduDateToolStripMenuItem";
            this.introduDateToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.introduDateToolStripMenuItem.Text = "Introdu / Editeaza Date";
            // 
            // introduGoodsToolStripMenuItem
            // 
            this.introduGoodsToolStripMenuItem.Name = "introduGoodsToolStripMenuItem";
            this.introduGoodsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.introduGoodsToolStripMenuItem.Text = "Introdu Goods";
            this.introduGoodsToolStripMenuItem.Click += new System.EventHandler(this.introduGoodsToolStripMenuItem_Click);
            // 
            // introduContracteToolStripMenuItem
            // 
            this.introduContracteToolStripMenuItem.Name = "introduContracteToolStripMenuItem";
            this.introduContracteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.introduContracteToolStripMenuItem.Text = "Introdu Contracte";
            this.introduContracteToolStripMenuItem.Click += new System.EventHandler(this.introduContracteToolStripMenuItem_Click);
            // 
            // introduSuppliersToolStripMenuItem
            // 
            this.introduSuppliersToolStripMenuItem.Name = "introduSuppliersToolStripMenuItem";
            this.introduSuppliersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.introduSuppliersToolStripMenuItem.Text = "Introdu Suppliers";
            this.introduSuppliersToolStripMenuItem.Click += new System.EventHandler(this.introduSuppliersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Goods:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contracts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suppliers:";
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameSupplierDataGridViewTextBoxColumn
            // 
            this.nameSupplierDataGridViewTextBoxColumn.DataPropertyName = "nameSupplier";
            this.nameSupplierDataGridViewTextBoxColumn.HeaderText = "nameSupplier";
            this.nameSupplierDataGridViewTextBoxColumn.Name = "nameSupplierDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(_1066_Giurgiteanu_Mihai_Andrei.Entities.Supplier);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // goodIdDataGridViewTextBoxColumn
            // 
            this.goodIdDataGridViewTextBoxColumn.DataPropertyName = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.HeaderText = "GoodId";
            this.goodIdDataGridViewTextBoxColumn.Name = "goodIdDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // finalPriceDataGridViewTextBoxColumn
            // 
            this.finalPriceDataGridViewTextBoxColumn.DataPropertyName = "finalPrice";
            this.finalPriceDataGridViewTextBoxColumn.HeaderText = "finalPrice";
            this.finalPriceDataGridViewTextBoxColumn.Name = "finalPriceDataGridViewTextBoxColumn";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(_1066_Giurgiteanu_Mihai_Andrei.Entities.Contract);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.csmRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem introduDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introduGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introduContracteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introduSuppliersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip csmRightClick;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}