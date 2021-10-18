using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Abseentism.Clases.Repository;
using Abseentism.Data.ViewModels;
using Abseentism.Clases;

namespace Abseentism.Shared
{
    public partial class _Team : UserControl
    {
        private string selectedTeam = string.Empty;
        private int rowIndice = 0;
        public _Team()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTeams.Rows.Clear();
            TeamRepository teamrepo = new TeamRepository();

            IEnumerable<TeamCountryViewModel> listteams = await teamrepo.GetAll(txtSearch.Text);

            foreach (var teams in listteams)
            {
            //    Bitmap flag;
            //    switch (teams.Country)
            //    {
            //        case "Brazil":
            //        case "Brasil":
            //        case "brasil":
            //        case "brazil":
            //            flag = new Bitmap(Properties.Resources.brazil);
            //            break;
            //        case "Argentina":
            //        case "argentina":
            //        case "Argentine":
            //        case "argentine":
            //            flag = new Bitmap(Properties.Resources.Argentina);
            //            break;
            //        case "Chile":
            //        case "chile":
            //            flag = new Bitmap(Properties.Resources.Chile);
            //            break;
            //        case "Canada":
            //        case "canada":
            //            flag = new Bitmap(Properties.Resources.Canada);
            //            break;
            //        default:
            //            flag = new Bitmap(Properties.Resources.globe);
            //            break;
            //    }
                dgvTeams.Rows.Add(new object[] { teams.Id, Helpers.GetFlag(teams.Country) , teams.Country, teams.Team });
            }
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
            dgvTeams.Columns["colTeam"].ReadOnly = false;
        }

        #region GridView
        private void dgvTeams_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedTeam = dgvTeams.Rows[e.RowIndex].Cells["colTeam"].Value.ToString();
        }


        private void RestoreCellValue(int rowIndex)
        {
            dgvTeams.Rows[rowIndex].Cells["colTeam"].Value = selectedTeam;
        }

        private void dgvTeams_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgvTeams.Rows.Count.ToString();
        }
        
        private void dgvTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && (int)dgvTeams.CurrentRow.Cells["colId"].Value > 0)  //El Null value de colID es 0
            {
                rowIndice = (int)dgvTeams.CurrentRow.Cells["colId"].Value;
            }
        }
        #endregion

        private async void dgvTeams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvTeams.Rows[e.RowIndex].Cells["colTeam"].Value.ToString()))
            {
                var team = new TeamRepository();

                Teams editedTeam = new Teams();
                editedTeam.TeamName = dgvTeams.Rows[e.RowIndex].Cells["colTeam"].Value.ToString();
                editedTeam.Id = (int)dgvTeams.Rows[e.RowIndex].Cells["colId"].Value;

                if (await team.EditTeam(editedTeam))
                {
                    MessageBox.Show(Constants.DATA_UPDATE_OK, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Constants.DUPLICATED_DATA, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RestoreCellValue(e.RowIndex);
                }
            }
            else
            {
                RestoreCellValue(e.RowIndex);
            }
        }
    }
}
