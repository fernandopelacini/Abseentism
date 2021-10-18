namespace Abseentism.Shared
{
    partial class _Country
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(13, 22);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country:";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(87, 22);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 22;
            this.btnSearch.Location = new System.Drawing.Point(307, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Black;
            this.lblCount.Location = new System.Drawing.Point(355, 458);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "0";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(274, 458);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(75, 13);
            this.lblTotalRecords.TabIndex = 8;
            this.lblTotalRecords.Text = "Total records: ";
            // 
            // dgvCountries
            // 
            this.dgvCountries.AllowUserToAddRows = false;
            this.dgvCountries.AllowUserToDeleteRows = false;
            this.dgvCountries.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFlag,
            this.colCountry});
            this.dgvCountries.Location = new System.Drawing.Point(16, 65);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCountries.Size = new System.Drawing.Size(352, 372);
            this.dgvCountries.TabIndex = 4;
            this.dgvCountries.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvCountries_CellBeginEdit);
            this.dgvCountries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountries_CellClick);
            this.dgvCountries.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountries_CellEndEdit);
            this.dgvCountries.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCountries_RowsAdded);
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
            // _Country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.dgvCountries);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCountry);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "_Country";
            this.Size = new System.Drawing.Size(399, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
    }
}
