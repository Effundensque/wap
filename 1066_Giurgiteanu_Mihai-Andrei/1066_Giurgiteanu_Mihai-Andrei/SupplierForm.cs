using _1066_Giurgiteanu_Mihai_Andrei.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1066_Giurgiteanu_Mihai_Andrei
{
    public partial class SupplierForm : Form
    {
        SupplierContext scx;
        public SupplierForm()
        {
            InitializeComponent();
            scx = new SupplierContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSupplier.SelectedRows[0];
                supplier.nameSupplier = row.Cells[1].Value.ToString();
            }
            Form form = new AddSupplyForm(supplier);
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (dgvSupplier.SelectedRows.Count != 0)
                {
                    Supplier target = supplierBindingSource.Current as Supplier;

                    target.nameSupplier = supplier.nameSupplier;
                    scx.Suppliers.Update(target);
                }
                else
                {
                    scx.Suppliers.Add(new Supplier() { nameSupplier = supplier.nameSupplier });
                }
                scx.SaveChanges();

                supplierBindingSource.DataSource = scx.Suppliers.ToList();
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = scx.Suppliers.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scx.Suppliers.Remove(supplierBindingSource.Current as Supplier);
                    scx.SaveChanges();

                    supplierBindingSource.DataSource = scx.Suppliers.ToList();
                }
            }
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Close();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ContractForm();
            form.Show();
            this.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new GoodsForm();
            form.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Close();
        }
    }
}
