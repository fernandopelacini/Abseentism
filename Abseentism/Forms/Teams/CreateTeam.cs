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

namespace Abseentism.Forms.Teams
{
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            int countryId = _Country1.GetCountryID();
            if (countryId != 0)
            {
                if (!string.IsNullOrEmpty(txtTeam.Text))
                {
                    var teamRepo = new TeamRepository();
                    var team = new Clases.Teams();

                    team.TeamName = txtTeam.Text;
                    team.CountryId = countryId;

                    if (await teamRepo.AddTeam(team))
                    {
                        MessageBox.Show(Constants.DATA_SAVE_OK, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTeam.Clear();
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
}
