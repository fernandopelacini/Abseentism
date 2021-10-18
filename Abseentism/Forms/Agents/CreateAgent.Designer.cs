namespace Abseentism.Forms.Agents
{
    partial class CreateAgent
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
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this._Agent1 = new Abseentism.Shared._Agent();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 21;
            this.btnSave.Location = new System.Drawing.Point(423, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // _Agent1
            // 
            this._Agent1.ForeColor = System.Drawing.Color.Black;
            this._Agent1.Location = new System.Drawing.Point(12, 12);
            this._Agent1.Name = "_Agent1";
            this._Agent1.Size = new System.Drawing.Size(408, 233);
            this._Agent1.TabIndex = 0;
            // 
            // CreateAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 318);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._Agent1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register a new agent";
            this.ResumeLayout(false);

        }

        #endregion

        private Shared._Agent _Agent1;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}