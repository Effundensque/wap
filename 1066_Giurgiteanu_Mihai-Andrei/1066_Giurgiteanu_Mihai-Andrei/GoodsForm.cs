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
    public partial class GoodsForm : Form
    {
        GoodContext dcx;
        public GoodsForm()
        {
            InitializeComponent();
            dcx=new GoodContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Good good = new Good();
            
            if (dgvGood.SelectedRows.Count > 0)
            {
                //MessageBox.Show(dgvGood.SelectedRows.Count.ToString());
                DataGridViewRow row = dgvGood.SelectedRows[0];
                good.nameGood = row.Cells[1].Value.ToString();
                good.pricePerGood = Convert.ToInt32(row.Cells[2].Value);
                //good = dgvGood.SelectedRows[0].Tag as Good;
            }
            Form form = new AddGoodForm(good);
            if (form.ShowDialog() == DialogResult.OK)
            {

                if (dgvGood.SelectedRows.Count != 0)
                {
                    Good target = goodBindingSource.Current as Good;
                    
                    target.nameGood = good.nameGood;
                    target.pricePerGood = good.pricePerGood;
                    dcx.Goods.Update(target);
                }
                else
                {
                    dcx.Goods.Add(new Good() { nameGood = good.nameGood,pricePerGood=good.pricePerGood });
                }
                dcx.SaveChanges();

                goodBindingSource.DataSource = dcx.Goods.ToList();
            }
        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            goodBindingSource.DataSource = dcx.Goods.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGood.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dcx.Goods.Remove(goodBindingSource.Current as Good);
                    dcx.SaveChanges();

                    goodBindingSource.DataSource = dcx.Goods.ToList();
                }
            }
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ContractForm();
            form.Show();
            this.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SupplierForm();
            form.Show();
            this.Close();
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
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
