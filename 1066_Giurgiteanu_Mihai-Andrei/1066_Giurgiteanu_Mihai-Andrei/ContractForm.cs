using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using _1066_Giurgiteanu_Mihai_Andrei.Entities;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1066_Giurgiteanu_Mihai_Andrei
{
    public partial class ContractForm : Form
    {
        ContractContext ccx;
        public ContractForm()
        {
            InitializeComponent();
            ccx = new ContractContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contract contract=new Contract();
            if (dgvContract.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvContract.SelectedRows[0];
                contract.GoodId = Convert.ToInt32(row.Cells[1].Value);
                contract.SupplierId = Convert.ToInt32(row.Cells[2].Value);
                contract.quantity= Convert.ToInt32(row.Cells[3].Value);
                contract.finalPrice= Convert.ToInt32(row.Cells[4].Value);
                
            }
            Form form = new AddContractForm(contract);
            if (form.ShowDialog() == DialogResult.OK)
            {

                if (dgvContract.SelectedRows.Count != 0)
                {
                    Contract target = contractBindingSource.Current as Contract;

                    target.GoodId = contract.GoodId;
                    target.SupplierId = contract.SupplierId;
                    target.quantity = contract.quantity;
                    target.finalPrice = contract.finalPrice;
                    ccx.Contracts.Update(target);
                }
                else
                {
                    ccx.Contracts.Add(new Contract() { GoodId = contract.GoodId, SupplierId=contract.SupplierId, quantity=contract.quantity, finalPrice=contract.finalPrice });
                }
                ccx.SaveChanges();

                contractBindingSource.DataSource = ccx.Contracts.ToList();
            }
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            contractBindingSource.DataSource = ccx.Contracts.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ccx.Contracts.Remove(contractBindingSource.Current as Contract);
                    ccx.SaveChanges();

                    contractBindingSource.DataSource = ccx.Contracts.ToList();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form form= new MainForm();
            form.Show();
            this.Close();

        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Close();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new GoodsForm();
            form.Show();
            this.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SupplierForm();
            form.Show();
            this.Close();
        }
    }
}
