using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TimoninaIA.Sprint7.V10.Lib;

namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    public partial class AddOrderForm_TIA : Form
    {
        public Order Order { get; private set; }

        public AddOrderForm_TIA()
        {
            InitializeComponent();
        }

        private void buttonSaveOrder_TIA_Click(object sender, EventArgs e)
        {
            Order = new Order
            {
                OrderNumber = textBoxOrderNumber_TIA.Text,
                LastName = textBoxLastName_TIA.Text,
                FirstName = textBoxFirstName_TIA.Text,
                MiddleName = textBoxMiddleName_TIA.Text,
                Index = textBoxIndex_TIA.Text,
                City = textBoxCity_TIA.Text,
                Address = textBoxAddress_TIA.Text,
                PhoneNumber = textBoxPhoneNumber_TIA.Text,
                OrderDate = dateTimePickerOrderDate_TIA.Value,
                OrderName = textBoxOrderName_TIA.Text,
                Price = decimal.Parse(textBoxPrice_TIA.Text),
                Quantity = int.Parse(textBoxQuantity_TIA.Text),
                AccountNumber = textBoxAccountNumber_TIA.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}