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


namespace Abseentism.Forms.Agents
{
    public partial class CreateAgent : Form
    {
        public CreateAgent()
        {
            InitializeComponent();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            //if (_Agent1.Validate())
            //{
                //Guardar los datos
                var agent = new Agent();
                var repository = new AgentRepository();
                agent =  _Agent1.GetAgentData();
          //  var isValid =  repository.IsValid(agent).Result;

            if (await repository.IsValid(agent)) { 
                if (await repository.AddAgent(agent))
                {
                    MessageBox.Show(Constants.DATA_SAVE_OK, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Agent1.CleanUpFields();
                }
                else
                {
                    MessageBox.Show(Constants.DUPLICATED_DATA, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                {
                MessageBox.Show(Constants.MANDATORY_FIELDS, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           

        }
    }
}
