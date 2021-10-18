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

namespace Abseentism.Shared
{
    public partial class _Usuario : UserControl
    {
        public _Usuario()
        {
            InitializeComponent();
            LoadCountries();
        }
        private void LoadCountries()
        {
            CountryRepository country = new CountryRepository();
            var countries = country.GetCountries();

            cmbCountry.DataSource = countries;
            cmbCountry.ValueMember = "Id";
            cmbCountry.DisplayMember = "Pais";

        }

    }
}
