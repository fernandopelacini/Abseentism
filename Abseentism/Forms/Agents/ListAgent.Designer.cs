namespace Abseentism.Forms.Agents
{
    partial class ListAgent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.dgwAgents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(690, 343);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 13);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "0";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(609, 343);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(75, 13);
            this.lblTotalRecords.TabIndex = 12;
            this.lblTotalRecords.Text = "Total records: ";
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
            this.dgwAgents.Location = new System.Drawing.Point(28, 69);
            this.dgwAgents.Name = "dgwAgents";
            this.dgwAgents.ReadOnly = true;
            this.dgwAgents.Size = new System.Drawing.Size(687, 262);
            this.dgwAgents.TabIndex = 11;
            this.dgwAgents.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgwAgents_RowsAdded);
            // 
            // colId
            // 
            dataGridViewCellStyle4.NullValue = "0";
            this.colId.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "1";
            this.colCountry.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCountry.HeaderText = "Country";
            this.colCountry.MaxInputLength = 50;
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            // 
            // ColTeam
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "1";
            this.ColTeam.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTeam.HeaderText = "Team";
            this.ColTeam.MaxInputLength = 50;
            this.ColTeam.Name = "ColTeam";
            this.ColTeam.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 21;
            this.btnSearch.Location = new System.Drawing.Point(312, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 25);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // ListAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(746, 365);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.dgwAgents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListAgent";
            this.Text = "Agent dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.DataGridView dgwAgents;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTeam;
    }
}