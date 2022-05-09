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
    
    public partial class AddGoodForm : Form
    {
        GoodContext gcx;
        #region Attributes
        private readonly Good _good;
        #endregion
        public AddGoodForm(Good good)
        {
            InitializeComponent();
            _good = good;
            ctrlName.Text = good.nameGood;
            ctrlPrice.Text = good.pricePerGood.ToString();
            //gcx = new GoodContext();
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _good.nameGood = ctrlName.Text;
            if (String.IsNullOrEmpty(ctrlPrice.Text))
            {
                MessageBox.Show("You can't let the price empty");
                this.DialogResult = DialogResult.None;
            }else
            {
                _good.pricePerGood = Convert.ToInt32(ctrlPrice.Text);
            }
           
        }

        private void AddGoodForm_Load(object sender, EventArgs e)
        {
            ctrlName.Text = _good.nameGood;
            ctrlPrice.Text = _good.pricePerGood.ToString();
        }

        private void ctrlPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
