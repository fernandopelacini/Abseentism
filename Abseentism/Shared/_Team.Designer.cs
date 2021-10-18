namespace Abseentism.Shared
{
    partial class _Team
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(476, 459);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 13);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "0";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(395, 459);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(75, 13);
            this.lblTotalRecords.TabIndex = 14;
            this.lblTotalRecords.Text = "Total records: ";
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFlag,
            this.colCountry,
            this.colTeam});
            this.dgvTeams.Location = new System.Drawing.Point(19, 63);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(471, 372);
            this.dgvTeams.TabIndex = 13;
            this.dgvTeams.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTeams_CellBeginEdit);
            this.dgvTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeams_CellClick);
            this.dgvTeams.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeams_CellEndEdit);
            this.dgvTeams.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTeams_RowsAdded);
            // 
            // colId
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.FillWeight = 50F;
            this.colId.HeaderText = "#";
            this.colId.MaxInputLength = 10;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 30;
            // 
            // colFlag
            // 
            this.colFlag.HeaderText = "";
            this.colFlag.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colFlag.Name = "colFlag";
            this.colFlag.ReadOnly = true;
            this.colFlag.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFlag.Width = 30;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "Country";
            this.colCountry.MaxInputLength = 50;
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            this.colCountry.Width = 200;
            // 
            // colTeam
            // 
            this.colTeam.HeaderText = "Team";
            this.colTeam.MaxInputLength = 50;
            this.colTeam.Name = "colTeam";
            this.colTeam.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(100, 20);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtSearch, "Type country or team to search for");
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(16, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Country/Team:";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 22;
            this.btnSearch.Location = new System.Drawing.Point(349, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 31);
            this.btnSearch.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSearch, "Search for the input stated");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // _Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "_Team";
            this.Size = new System.Drawing.Size(528, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.DataGridView dgvTeams;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam;
    }
}
