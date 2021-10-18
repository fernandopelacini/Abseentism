using Abseentism.Forms.Agents;
using Abseentism.Forms.Countries;
using Abseentism.Forms.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abseentism.Forms
{
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAgent agent = new CreateAgent();
            LoadForm(agent);
            //agent.MdiParent = this;
            //agent.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyAgent agent = new ModifyAgent();
            LoadForm(agent);
            //agent.MdiParent = this;
            //agent.Show();
        }

        private void LoadForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateCountry country = new CreateCountry();
            LoadForm(country);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCountry country = new ListCountry();
            LoadForm(country);
        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyCountry country = new ModifyCountry();
            LoadForm(country);
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateTeam team = new CreateTeam();
            LoadForm(team);
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListAgent agent = new ListAgent();
            LoadForm(agent);
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListTeam team = new ListTeam();
            LoadForm(team);
        }

        private void modifyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModifyTeam team = new ModifyTeam();
            LoadForm(team);
        }

        private void mnuExceptionsGenerate_Click(object sender, EventArgs e)
        {
            Ausencias.Exceptions absence = new Ausencias.Exceptions();
            LoadForm(absence);
        }
    }
}
