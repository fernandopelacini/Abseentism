using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abseentism.Clases.Repository;
using Abseentism.Clases;

namespace Abseentism.Shared
{
    public partial class _Country : UserControl
    {

        private string selectedCountry = string.Empty;
        private int rowIndice = 0;
        public _Country()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCountries.Rows.Clear();
            CountryRepository countryrepo = new CountryRepository();

            IEnumerable<Data.Countries> listcountries =await countryrepo.GetAll(txtSearch.Text);

            foreach (var country in listcountries)
            {
                dgvCountries.Rows.Add(new object[] { country.id,Helpers.GetFlag(country.country) ,country.country });
            }

        }

        private void dgvCountries_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgvCountries.Rows.Count.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnableEditing()
        {
            dgvCountries.Columns["colCountry"].ReadOnly = false;
        }

        private void dgvCountries_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedCountry = dgvCountries.Rows[e.RowIndex].Cells["colCountry"].Value.ToString();
        }

        private async void dgvCountries_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvCountries.Rows[e.RowIndex].Cells["colCountry"].Value.ToString()))
            {
                if (dgvCountries.Rows[e.RowIndex].Cells["colCountry"].Value.ToString() !=selectedCountry)
                {
                    var country = new CountryRepository();

                    Country editedCountry = new Country();
                    editedCountry.Pais = dgvCountries.Rows[e.RowIndex].Cells["colCountry"].Value.ToString();
                    editedCountry.Id = (int)dgvCountries.Rows[e.RowIndex].Cells["colId"].Value;

                    if (await country.EditCountry(editedCountry))
                    {
                        MessageBox.Show(Constants.DATA_UPDATE_OK, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCountries.Rows[e.RowIndex].Cells["colFlag"].Value = Helpers.GetFlag(editedCountry.Pais);
                    }
                    else
                    {
                        MessageBox.Show(Constants.DUPLICATED_DATA, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        RestoreCellValue(e.RowIndex);
                    }
                }
            }
            else
            {
                RestoreCellValue(e.RowIndex);
            }
        }

        private void RestoreCellValue(int rowIndex)
        {
            dgvCountries.Rows[rowIndex].Cells["colCountry"].Value = selectedCountry;
        }

        public int GetCountryID()
        {
            if (dgvCountries.Rows.Count > 0 && rowIndice != 0)
            {
                return rowIndice;
            }
            else
            {
                MessageBox.Show(Constants.SELECT_COUNTRY_TO_PROCEED, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
        }

        private void dgvCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && (int)dgvCountries.CurrentRow.Cells["colId"].Value > 0)  //El Null value de colID es 0
            {
                rowIndice = (int)dgvCountries.CurrentRow.Cells["colId"].Value;
            }
        }
    }
}
