namespace Abseentism.Forms.Countries
{
    partial class ModifyCountry
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
            this.SuspendLayout();
            // 
            // _Country1
            // 
            this._Country1.Location = new System.Drawing.Point(12, 12);
            this._Country1.Name = "_Country1";
            this._Country1.Size = new System.Drawing.Size(399, 495);
            this._Country1.TabIndex = 0;
            // 
            // ModifyCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(626, 508);
            this.Controls.Add(this._Country1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Country";
            this.Load += new System.EventHandler(this.ModifyCountry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared._Country _Country1;
    }
}