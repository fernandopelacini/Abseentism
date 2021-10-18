using Abseentism.Clases;
using Abseentism.Clases.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abseentism.Forms.Countries
{
    public partial class CreateCountry : Form
    {
        public CreateCountry()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCountry.Text))
            {
                var country = new CountryRepository();
                if (await country.AddCountry(txtCountry.Text))
                {
                    MessageBox.Show(Constants.DATA_SAVE_OK, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCountry.Clear();
                }
                else
                {
                    MessageBox.Show(Constants.DUPLICATED_DATA, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show(Constants.TYPE_VALUE, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

     
    }
}
