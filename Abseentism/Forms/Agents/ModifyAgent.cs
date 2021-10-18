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
using Abseentism;
using Abseentism.Clases;

namespace Abseentism.Forms.Agents
{
    public partial class ModifyAgent : Form
    {
        public ModifyAgent()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgwAgents.Rows.Clear();
            AgentRepository agents = new AgentRepository();
            IEnumerable<Data.Agents> listagents =await agents.GetAll(txtSearch.Text);
            //DataGridViewRow dgvRow = (DataGridViewRow)dgwAgents.Rows[0].Clone();
            foreach (var agente in listagents)
            {

                dgwAgents.Rows.Add(new object[] { agente.id, agente.avayaId, agente.name, agente.surname, agente.countryId, agente.teamId });

            }
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && (int)dgwAgents.CurrentRow.Cells["colId"].Value > 0)  //El Null value de colID es 0
            {
                Data.Agents agente = new Data.Agents();
                agente.id = (int)dgwAgents.CurrentRow.Cells["colId"].Value;
                agente.avayaId = (string)dgwAgents.CurrentRow.Cells["colAvaya"].Value;
                agente.name = (string)dgwAgents.CurrentRow.Cells["colName"].Value;
                agente.surname = (string)dgwAgents.CurrentRow.Cells["colSurname"].Value;
                agente.countryId = (int)dgwAgents.CurrentRow.Cells["colCountry"].Value;
                agente.teamId = (int)dgwAgents.CurrentRow.Cells["colTeam"].Value;
                _Agent1.ReceiveAgentData(agente);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            //Guardar los datos
            var agent = new Agent();
            var repository = new AgentRepository();
            agent = _Agent1.GetAgentData();
            if (await repository.IsValid(agent))
            {
                if (await repository.EditAgent(agent))
                {
                    MessageBox.Show("Data updated succesfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgwAgents.Rows.Clear();
                    _Agent1.CleanUpFields();
                }
                else
                {
                    MessageBox.Show("Duplicated agent!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show(Constants.MANDATORY_FIELDS, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgwAgents.Rows.Count.ToString();
        }
    }
}
