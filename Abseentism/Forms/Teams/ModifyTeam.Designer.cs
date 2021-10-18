namespace Abseentism.Forms.Teams
{
    partial class ModifyTeam
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
            this._Team1.TabIndex = 1;
            // 
            // ModifyTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(528, 500);
            this.Controls.Add(this._Team1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Team";
            this.Load += new System.EventHandler(this.ModifyTeam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared._Team _Team1;
    }
}