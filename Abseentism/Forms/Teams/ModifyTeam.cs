using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abseentism.Forms.Teams
{
    public partial class ModifyTeam : Form
    {
        public ModifyTeam()
        {
            InitializeComponent();
        }

        private void ModifyTeam_Load(object sender, EventArgs e)
        {
            _Team1.EnableEditing();
        }
    }
}
