namespace Abseentism.Forms.Teams
{
    partial class ListTeam
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
            this._Team1 = new Abseentism.Shared._Team();
            this.SuspendLayout();
            // 
            // _Team1
            // 
            this._Team1.ForeColor = System.Drawing.Color.Black;
            this._Team1.Location = new System.Drawing.Point(12, 12);
            this._Team1.Name = "_Team1";
            this._Team1.Size = new System.Drawing.Size(528, 489);
            this._Team1.TabIndex = 0;
            // 
            // ListTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(535, 535);
            this.Controls.Add(this._Team1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team dashboard";
            this.Load += new System.EventHandler(this.ListTeam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared._Team _Team1;
    }
}