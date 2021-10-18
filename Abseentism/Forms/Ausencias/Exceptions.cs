using Abseentism.Clases;
using Abseentism.Clases.Repository;
using Abseentism.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abseentism.Forms.Ausencias
{
    public partial class Exceptions : Form
    {
        public Exceptions()
        {
            InitializeComponent();
            ShowHidePanels();
            GetUserData();
            //Task.Run(() => GetUserData()).Wait();
        }



        #region Radio Buttons
        private void RdbAbsence_CheckedChanged(object sender, EventArgs e)
        {
            ShowHidePanels();
        }

        private void RdbLateArrival_CheckedChanged(object sender, EventArgs e)
        {
            ShowHidePanels();
        }

        private void RdbShiftChange_CheckedChanged(object sender, EventArgs e)
        {
            ShowHidePanels();
        }

        #endregion

        #region Methods
        private void ShowHidePanels()
        {
            panelAbsences.Visible = rdbAbsence.Checked;
            panelLateArrival.Visible = rdbLateArrival.Checked;
            panelShifChange.Visible = rdbShiftChange.Checked;

            if (panelAbsences.Visible || panelLateArrival.Visible || panelShifChange.Visible ? panelObservations.Visible = true : panelObservations.Visible = false) ;


            if (panelLateArrival.Visible)
            {
                lblAbsenceDate.Text = "Late arrival date:";
            }
            else if (panelShifChange.Visible)
            {
                lblAbsenceDate.Text = "New shift date:";
            }
            else
            {
                lblAbsenceDate.Text = "Absence date:";
            }
        }

        private void CleanUpFields()
        {
            txtObservations.Clear();
            dtpAbsenceDate.Value = DateTime.Today;
        }

        private async void GetUserData()
        {
            txtCountry.Text = "Argentina";// Credentials.User.Country.Pais;
            imgFlag.Image = Helpers.GetFlag("Argentina");// Credentials.User.Country.Pais);
            await LoadTeamsCombo(1);// Credentials.User.Country.Id);
            await LoadAbsencesCombo();
            //return true;
        }

        private async Task<bool> LoadAbsencesCombo()
        {
            try
            {
                var absencerepo = new AbsenceTypeRepository();
                cmbAbsenceTypes.Items.Clear();
                cmbAbsenceTypes.DataSource = await absencerepo.GetAll();
                cmbAbsenceTypes.ValueMember = "ID";
                cmbAbsenceTypes.DisplayMember = "Name";
                return true;
            }
            catch (Exception)
            {
                //TODO Log error properly
                //throw;
                return false;
            }
        }

        private async Task<bool> LoadTeamsCombo(int idcountry)
        {
            try
            {
                var teams = new TeamRepository();
                cmbTeams.Items.Clear();
                cmbTeams.DataSource = await teams.GetTeamsByCountry(idcountry);
                cmbTeams.ValueMember = "Id";
                cmbTeams.DisplayMember = "TeamName";
                return true;
            }
            catch (Exception ex)
            {
                //TODO log exception
                throw ex;
            return false;
            }

        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //TODO
            //Save in repository

            CleanUpFields();
        }

        private async void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeams.SelectedIndex > 0)
            {
                
                var agents =  await GetAgents();
                 dgvAgents.Rows.Clear();
                //dgvAgents.DataSource = agents;
                //TODO  meter las rows en la grilla.
                foreach (var item in agents)
                {
                    dgvAgents.Rows.Add(new object[] {item.Id,item.FullName,item.AvayaId });
                }
            }

        }

        private async Task<IEnumerable<Agent>> GetAgents()
        {
            var agents = new AgentRepository();
            IEnumerable<Agent> data = await agents.GetAgentsByTeam(1,(int)cmbTeams.SelectedValue);
            return data;

        }
    }
}
