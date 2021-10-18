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

namespace Abseentism.Forms.Agents
{
    public partial class ListAgent : Form
    {
        public ListAgent()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgwAgents.Rows.Clear();
            AgentRepository agents = new AgentRepository();
            IEnumerable<FullAgentViewModel> listagents =await agents.GetAgentsFullDetails(txtSearch.Text);
            
            foreach (var agente in listagents)
            {
                dgwAgents.Rows.Add(new object[] { agente.Id, agente.AvayaId, agente.Name, agente.Surname, agente.Pais, agente.TeamName });
            }


        }

        private void dgwAgents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblCount.Text = dgwAgents.Rows.Count.ToString();
        }
    }
}
