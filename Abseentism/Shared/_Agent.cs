using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abseentism.Clases.Interfaces;
using Abseentism.Clases.Repository;
using Abseentism.Clases;
using Abseentism.Data;

namespace Abseentism.Shared
{
    public partial class _Agent : UserControl
    {
        private int _agentId = 0;
        public _Agent()
        {
            InitializeComponent();
            LoadCountries();
        }

        private async void LoadCountries()
        {
            CountryRepository country = new CountryRepository();
            var countries = await country.GetCountries();

            cmbCountry.DataSource = countries;
            cmbCountry.ValueMember = "Id";
            cmbCountry.DisplayMember = "Pais";

        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                //TODO Mensaje error
                return false;
            }
            if (string.IsNullOrEmpty(this.txtSurname.Text))
            {
                //TODO Mensaje error
                return false;
            }
            if (string.IsNullOrEmpty(this.txtAvaya.Text))
            {
                //TODO Mensaje error
                return false;
            }

            if (cmbCountry.SelectedIndex == 0)
            {
                //TODO Mensaje error
                return false;
            }
            if (cmbTeam.SelectedValue == null)
            {
                //TODO Mensaje error
                return false;
            }

            return true;
        }

        public void CleanUpFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtAvaya.Clear();
        }

        private async void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int idCountry = 0;
            //if (int.TryParse(cmbCountry.SelectedValue.ToString(),out idCountry))
            if (cmbCountry.SelectedIndex > 0)
            {
                TeamRepository teams = new TeamRepository();

                var teamsbyCountry =await teams.GetTeamsByCountry((int)cmbCountry.SelectedValue);

                cmbTeam.DataSource = teamsbyCountry;
                cmbTeam.ValueMember = "Id";
                cmbTeam.DisplayMember = "TeamName";
            }


        }

        #region Expose functions
        public  Agent GetAgentData()
        {

           //var result = await Task.Run(() =>
           //{
                var agent = new Agent();
                agent.AvayaId = txtAvaya.Text;
                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.CountryId = (int)cmbCountry.SelectedValue;
                agent.TeamId = (int)cmbTeam.SelectedValue;
                agent.Id = _agentId; //Cuando se lo crea viene en 0
                return agent;
           //});
           // return result;
        }

        public void ReceiveAgentData(Agents agent)
        {
            txtAvaya.Text = agent.avayaId;
            txtName.Text = agent.name;
            txtSurname.Text = agent.surname;
            cmbCountry.SelectedValue = agent.countryId;
            cmbTeam.SelectedValue = agent.teamId;
            _agentId = agent.id;
        }


        #endregion  
    }
}
