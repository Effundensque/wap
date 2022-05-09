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
    public partial class AddSupplyForm : Form
    {
        SupplierContext scx;
        #region Attributes
        private readonly Supplier _supplier;
        #endregion
        public AddSupplyForm(Supplier supplier)
        {
            InitializeComponent();
            _supplier = supplier;
            ctrlName.Text = supplier.nameSupplier;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _supplier.nameSupplier = ctrlName.Text;
        }

        private void AddSupplyForm_Load(object sender, EventArgs e)
        {
            ctrlName.Text = _supplier.nameSupplier;
        }
    }
}
