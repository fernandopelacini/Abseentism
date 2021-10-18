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
    public partial class ModifyCountry : Form
    {
        public ModifyCountry()
        {
            InitializeComponent();
        }

        private void ModifyCountry_Load(object sender, EventArgs e)
        {
            _Country1.EnableEditing();

        }
    }
}
