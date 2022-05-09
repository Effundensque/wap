using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1066_Giurgiteanu_Mihai_Andrei
{
    public partial class MainForm : Form
    {
        ContractContext ccx;
        GoodContext gcx;
        SupplierContext scx;
        public MainForm()
        {
            InitializeComponent();
            ccx = new ContractContext();
            gcx = new GoodContext();
            scx = new SupplierContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            contractBindingSource.DataSource = ccx.Contracts.ToList();
            goodBindingSource.DataSource = gcx.Goods.ToList();
            supplierBindingSource.DataSource = scx.Suppliers.ToList();
        }

        private void introduGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new GoodsForm();
            form.Show();
            this.Hide();
            

        }

        private void introduContracteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ContractForm();
            form.Show();
            this.Hide();
            
        }

        private void introduSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SupplierForm();
            form.Show();
            this.Hide();
            
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    formatter.Serialize(fs, goodBindingSource.DataSource);
                }
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    formatter.Serialize(fs, contractBindingSource.DataSource);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = File.Create(dialog.FileName))
                {
                    
                    formatter.Serialize(fs, supplierBindingSource.DataSource);
                }
            }
        }

        private void asTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Id,NameGood,PricePerGood");

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i=0; i<row.Cells.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value + "|");
                        }
                        sw.WriteLine("");
                    }
                }
            }
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Id,NameGood,PricePerGood");

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value + "|");
                        }
                        sw.WriteLine("");
                    }
                }
            }
        }

        private void textFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Id,NameGood,PricePerGood");

                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value + "|");
                        }
                        sw.WriteLine("");
                    }
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.G)
            {
                csmRightClick.Show();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                contextMenuStrip2.Show();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.S)
            {
                contextMenuStrip1.Show();
            }
        }

       

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can serialize by right-clicking on each data grid view.\n" +
                "You can also export data to text file from that menu.\n" +
                "Shortcuts:\n" +
                "ALT + G - for the goods view\n" +
                "ALT + C - for the contracts view\n" +
                "ALT + S - for the suppliers view");
        }

       
    }
}
