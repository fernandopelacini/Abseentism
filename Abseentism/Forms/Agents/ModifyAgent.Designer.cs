namespace Abseentism.Forms.Agents
{
    partial class ModifyAgent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.dgwAgents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Agent1 = new Abseentism.Shared._Agent();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(28, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 18);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 20);
            this.txtSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSearch, "Type the name or surname of the agent to search for");
            // 
            // btnSave
            // 
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSave.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 21;
            this.btnSave.Location = new System.Drawing.Point(459, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 31);
            this.btnSave.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSave, "Save changes");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 21;
            this.btnSearch.Location = new System.Drawing.Point(329, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgwAgents
            // 
            this.dgwAgents.AllowUserToAddRows = false;
            this.dgwAgents.AllowUserToDeleteRows = false;
            this.dgwAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colAvaya,
            this.colName,
            this.colSurname,
            this.colCountry,
            this.ColTeam});
            this.dgwAgents.Location = new System.Drawing.Point(45, 62);
            this.dgwAgents.Name = "dgwAgents";
            this.dgwAgents.ReadOnly = true;
            this.dgwAgents.Size = new System.Drawing.Size(383, 150);
            this.dgwAgents.TabIndex = 3;
            this.dgwAgents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            this.dgwAgents.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.RowsAdded);
            // 
            // colId
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colAvaya
            // 
            this.colAvaya.HeaderText = "Avaya Id";
            this.colAvaya.MaxInputLength = 30;
            this.colAvaya.Name = "colAvaya";
            this.colAvaya.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MaxInputLength = 50;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSurname
            // 
            this.colSurname.HeaderText = "Surname";
            this.colSurname.MaxInputLength = 50;
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            // 
            // colCountry
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "1";
            this.colCountry.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCountry.HeaderText = "Country";
            this.colCountry.MaxInputLength = 5;
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            this.colCountry.Visible = false;
            // 
            // ColTeam
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "1";
            this.ColTeam.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.MaxInputLength = 5;
            this.ColTeam.Name = "ColTeam";
            this.ColTeam.ReadOnly = true;
            this.ColTeam.Visible = false;
            // 
            // _Agent1
            // 
            this._Agent1.ForeColor = System.Drawing.Color.Black;
            this._Agent1.Location = new System.Drawing.Point(45, 218);
            this._Agent1.Name = "_Agent1";
            this._Agent1.Size = new System.Drawing.Size(408, 233);
            this._Agent1.TabIndex = 4;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(443, 199);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(75, 13);
            this.lblTotalRecords.TabIndex = 6;
            this.lblTotalRecords.Text = "Total records: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(524, 199);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "0";
            // 
            // ModifyAgent
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._Agent1);
            this.Controls.Add(this.dgwAgents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify an agent";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.DataGridView dgwAgents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
        private Shared._Agent _Agent1;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblCount;
    }
}