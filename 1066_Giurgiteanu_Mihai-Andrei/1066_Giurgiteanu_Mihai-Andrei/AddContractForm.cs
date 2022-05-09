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
    
    public partial class AddContractForm : Form
    {
        ContractContext ccx;
        GoodContext dcx;
        SupplierContext scx;
        #region Attributes
        private readonly Contract _contract;
        #endregion
        public AddContractForm(Contract contract)
        {
            InitializeComponent();
            ccx = new ContractContext();
            dcx = new GoodContext();
            scx = new SupplierContext();
            _contract = contract;
            textBox1.Text= contract.quantity.ToString();
        }

        private void AddContractForm_Load(object sender, EventArgs e)
        {
            goodBindingSource.DataSource = dcx.Goods.ToList();
            supplierBindingSource.DataSource=scx.Suppliers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _contract.SupplierId = (int)cbSupplier.SelectedValue;
            _contract.GoodId=(int)cbGood.SelectedValue;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You can't let the quantity field empty");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                _contract.quantity = Convert.ToInt32(textBox1.Text);
                _contract.finalPrice = _contract.quantity * Convert.ToInt32(tbPrice.Text);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbGood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
