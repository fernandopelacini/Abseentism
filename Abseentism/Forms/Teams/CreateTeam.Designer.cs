namespace Abseentism.Forms.Teams
{
    partial class CreateTeam
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._Country1 = new Abseentism.Shared._Country();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _Country1
            // 
            this._Country1.Location = new System.Drawing.Point(12, 12);
            this._Country1.Name = "_Country1";
            this._Country1.Size = new System.Drawing.Size(399, 495);
            this._Country1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 22;
            this.btnSave.Location = new System.Drawing.Point(682, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.ForeColor = System.Drawing.Color.Black;
            this.txtTeam.Location = new System.Drawing.Point(438, 91);
            this.txtTeam.MaxLength = 50;
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(221, 20);
            this.txtTeam.TabIndex = 4;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.ForeColor = System.Drawing.Color.Black;
            this.lblTeam.Location = new System.Drawing.Point(395, 94);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(37, 13);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Team:";
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(767, 499);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this._Country1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTeam";
            this.Text = "Register a new team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared._Country _Country1;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label lblTeam;
    }
}