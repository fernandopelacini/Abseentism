namespace Abseentism.Shared
{
    partial class _Agent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAvaya = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAvaya = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(22, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(22, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAvaya
            // 
            this.lblAvaya.AutoSize = true;
            this.lblAvaya.ForeColor = System.Drawing.Color.Black;
            this.lblAvaya.Location = new System.Drawing.Point(22, 98);
            this.lblAvaya.Name = "lblAvaya";
            this.lblAvaya.Size = new System.Drawing.Size(52, 13);
            this.lblAvaya.TabIndex = 2;
            this.lblAvaya.Text = "Avaya Id:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(22, 138);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country:";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(22, 179);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(37, 13);
            this.lblTeam.TabIndex = 4;
            this.lblTeam.Text = "Team:";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(96, 18);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(96, 54);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(273, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtAvaya
            // 
            this.txtAvaya.ForeColor = System.Drawing.Color.Black;
            this.txtAvaya.Location = new System.Drawing.Point(96, 95);
            this.txtAvaya.MaxLength = 50;
            this.txtAvaya.Name = "txtAvaya";
            this.txtAvaya.Size = new System.Drawing.Size(273, 20);
            this.txtAvaya.TabIndex = 7;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.ForeColor = System.Drawing.Color.Black;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(96, 138);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(273, 21);
            this.cmbCountry.TabIndex = 8;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbTeam
            // 
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.ForeColor = System.Drawing.Color.Black;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(96, 179);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(273, 21);
            this.cmbTeam.TabIndex = 9;
            // 
            // _Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cmbTeam);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtAvaya);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAvaya);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "_Agent";
            this.Size = new System.Drawing.Size(408, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAvaya;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAvaya;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbTeam;
    }
}
