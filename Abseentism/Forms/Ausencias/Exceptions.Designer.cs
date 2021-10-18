
using System;

namespace Abseentism.Forms.Ausencias
{
    partial class Exceptions
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.imgFlag = new System.Windows.Forms.PictureBox();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.panelTeam = new System.Windows.Forms.Panel();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.panelAgent = new System.Windows.Forms.Panel();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.rdbShiftChange = new System.Windows.Forms.RadioButton();
            this.rdbLateArrival = new System.Windows.Forms.RadioButton();
            this.rdbAbsence = new System.Windows.Forms.RadioButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelObservations = new System.Windows.Forms.Panel();
            this.grpObservations = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.dtpAbsenceDate = new System.Windows.Forms.DateTimePicker();
            this.lblAbsenceDate = new System.Windows.Forms.Label();
            this.panelShifChange = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblNewCheckInSchedule = new System.Windows.Forms.Label();
            this.lblOriginalCheckInSchedule = new System.Windows.Forms.Label();
            this.panelLateArrival = new System.Windows.Forms.Panel();
            this.dtpLateArrival = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissionSchedule = new System.Windows.Forms.DateTimePicker();
            this.lblLateArrivalSchedule = new System.Windows.Forms.Label();
            this.lblAdmissioonSchedule = new System.Windows.Forms.Label();
            this.panelAbsences = new System.Windows.Forms.Panel();
            this.cmbAbsenceTypes = new System.Windows.Forms.ComboBox();
            this.lblAusencias = new System.Windows.Forms.Label();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panelMaster = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlag)).BeginInit();
            this.panelCountry.SuspendLayout();
            this.panelTeam.SuspendLayout();
            this.panelAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelObservations.SuspendLayout();
            this.grpObservations.SuspendLayout();
            this.panelShifChange.SuspendLayout();
            this.panelLateArrival.SuspendLayout();
            this.panelAbsences.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(3, 30);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(55, 27);
            this.txtCountry.MaxLength = 50;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(228, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // imgFlag
            // 
            this.imgFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFlag.ErrorImage = global::Abseentism.Properties.Resources.globe;
            this.imgFlag.Location = new System.Drawing.Point(307, 17);
            this.imgFlag.Name = "imgFlag";
            this.imgFlag.Size = new System.Drawing.Size(32, 32);
            this.imgFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFlag.TabIndex = 2;
            this.imgFlag.TabStop = false;
            this.imgFlag.WaitOnLoad = true;
            // 
            // panelCountry
            // 
            this.panelCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCountry.Controls.Add(this.lblCountry);
            this.panelCountry.Controls.Add(this.imgFlag);
            this.panelCountry.Controls.Add(this.txtCountry);
            this.panelCountry.Location = new System.Drawing.Point(41, 12);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(380, 79);
            this.panelCountry.TabIndex = 3;
            // 
            // panelTeam
            // 
            this.panelTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTeam.Controls.Add(this.cmbTeams);
            this.panelTeam.Controls.Add(this.lblTeams);
            this.panelTeam.Location = new System.Drawing.Point(41, 97);
            this.panelTeam.Name = "panelTeam";
            this.panelTeam.Size = new System.Drawing.Size(380, 79);
            this.panelTeam.TabIndex = 4;
            // 
            // cmbTeams
            // 
            this.cmbTeams.BackColor = System.Drawing.Color.White;
            this.cmbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeams.ForeColor = System.Drawing.Color.Black;
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(65, 27);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(218, 21);
            this.cmbTeams.TabIndex = 1;
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
            // 
            // lblTeams
            // 
            this.lblTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(3, 30);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(42, 13);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Teams:";
            // 
            // panelAgent
            // 
            this.panelAgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAgent.Controls.Add(this.dgvAgents);
            this.panelAgent.Location = new System.Drawing.Point(41, 182);
            this.panelAgent.Name = "panelAgent";
            this.panelAgent.Size = new System.Drawing.Size(380, 413);
            this.panelAgent.TabIndex = 5;
            // 
            // dgvAgents
            // 
            this.dgvAgents.AllowUserToAddRows = false;
            this.dgvAgents.AllowUserToDeleteRows = false;
            this.dgvAgents.AllowUserToOrderColumns = true;
            this.dgvAgents.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.FullName,
            this.Avaya});
            this.dgvAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgents.GridColor = System.Drawing.Color.Gray;
            this.dgvAgents.Location = new System.Drawing.Point(0, 0);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgents.Size = new System.Drawing.Size(380, 413);
            this.dgvAgents.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.MaxInputLength = 100;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Fullname";
            this.FullName.MaxInputLength = 120;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // Avaya
            // 
            this.Avaya.HeaderText = "Avaya";
            this.Avaya.MaxInputLength = 50;
            this.Avaya.Name = "Avaya";
            this.Avaya.ReadOnly = true;
            this.Avaya.Width = 90;
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.rdbShiftChange);
            this.panelOptions.Controls.Add(this.rdbLateArrival);
            this.panelOptions.Controls.Add(this.rdbAbsence);
            this.panelOptions.Location = new System.Drawing.Point(473, 13);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(419, 42);
            this.panelOptions.TabIndex = 8;
            // 
            // rdbShiftChange
            // 
            this.rdbShiftChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbShiftChange.AutoSize = true;
            this.rdbShiftChange.Location = new System.Drawing.Point(216, 12);
            this.rdbShiftChange.Name = "rdbShiftChange";
            this.rdbShiftChange.Size = new System.Drawing.Size(85, 17);
            this.rdbShiftChange.TabIndex = 0;
            this.rdbShiftChange.Text = "Shift change";
            this.rdbShiftChange.UseVisualStyleBackColor = true;
            this.rdbShiftChange.CheckedChanged += new System.EventHandler(this.RdbShiftChange_CheckedChanged);
            // 
            // rdbLateArrival
            // 
            this.rdbLateArrival.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbLateArrival.AutoSize = true;
            this.rdbLateArrival.Location = new System.Drawing.Point(109, 12);
            this.rdbLateArrival.Name = "rdbLateArrival";
            this.rdbLateArrival.Size = new System.Drawing.Size(77, 17);
            this.rdbLateArrival.TabIndex = 0;
            this.rdbLateArrival.Text = "Late arrival";
            this.rdbLateArrival.UseVisualStyleBackColor = true;
            this.rdbLateArrival.CheckedChanged += new System.EventHandler(this.RdbLateArrival_CheckedChanged);
            // 
            // rdbAbsence
            // 
            this.rdbAbsence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAbsence.AutoSize = true;
            this.rdbAbsence.Location = new System.Drawing.Point(12, 12);
            this.rdbAbsence.Name = "rdbAbsence";
            this.rdbAbsence.Size = new System.Drawing.Size(67, 17);
            this.rdbAbsence.TabIndex = 0;
            this.rdbAbsence.Text = "Absence";
            this.rdbAbsence.UseVisualStyleBackColor = true;
            this.rdbAbsence.CheckedChanged += new System.EventHandler(this.RdbAbsence_CheckedChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelObservations);
            this.panelContainer.Controls.Add(this.panelShifChange);
            this.panelContainer.Controls.Add(this.panelLateArrival);
            this.panelContainer.Controls.Add(this.panelAbsences);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(507, 534);
            this.panelContainer.TabIndex = 11;
            // 
            // panelObservations
            // 
            this.panelObservations.Controls.Add(this.grpObservations);
            this.panelObservations.Controls.Add(this.dtpAbsenceDate);
            this.panelObservations.Controls.Add(this.lblAbsenceDate);
            this.panelObservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelObservations.Location = new System.Drawing.Point(0, 270);
            this.panelObservations.Name = "panelObservations";
            this.panelObservations.Size = new System.Drawing.Size(507, 254);
            this.panelObservations.TabIndex = 16;
            // 
            // grpObservations
            // 
            this.grpObservations.Controls.Add(this.txtObservations);
            this.grpObservations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpObservations.Location = new System.Drawing.Point(0, 76);
            this.grpObservations.Name = "grpObservations";
            this.grpObservations.Size = new System.Drawing.Size(507, 178);
            this.grpObservations.TabIndex = 11;
            this.grpObservations.TabStop = false;
            this.grpObservations.Text = "Comments:";
            // 
            // txtObservations
            // 
            this.txtObservations.BackColor = System.Drawing.Color.White;
            this.txtObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservations.ForeColor = System.Drawing.Color.Black;
            this.txtObservations.Location = new System.Drawing.Point(3, 16);
            this.txtObservations.MaxLength = 150;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(501, 159);
            this.txtObservations.TabIndex = 0;
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAbsenceDate.CalendarForeColor = System.Drawing.Color.White;
            this.dtpAbsenceDate.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.dtpAbsenceDate.CalendarTitleBackColor = System.Drawing.Color.SteelBlue;
            this.dtpAbsenceDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpAbsenceDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpAbsenceDate.CustomFormat = "dd-MM-yyyy";
            this.dtpAbsenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbsenceDate.Location = new System.Drawing.Point(153, 18);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(209, 20);
            this.dtpAbsenceDate.TabIndex = 10;
            this.dtpAbsenceDate.Value = new System.DateTime(2021, 2, 4, 0, 0, 0, 0);
            // 
            // lblAbsenceDate
            // 
            this.lblAbsenceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbsenceDate.AutoSize = true;
            this.lblAbsenceDate.Location = new System.Drawing.Point(30, 24);
            this.lblAbsenceDate.Name = "lblAbsenceDate";
            this.lblAbsenceDate.Size = new System.Drawing.Size(76, 13);
            this.lblAbsenceDate.TabIndex = 9;
            this.lblAbsenceDate.Text = "Absence date:";
            // 
            // panelShifChange
            // 
            this.panelShifChange.Controls.Add(this.dateTimePicker1);
            this.panelShifChange.Controls.Add(this.dateTimePicker2);
            this.panelShifChange.Controls.Add(this.lblNewCheckInSchedule);
            this.panelShifChange.Controls.Add(this.lblOriginalCheckInSchedule);
            this.panelShifChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShifChange.Location = new System.Drawing.Point(0, 171);
            this.panelShifChange.Name = "panelShifChange";
            this.panelShifChange.Size = new System.Drawing.Size(507, 99);
            this.panelShifChange.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lblNewCheckInSchedule
            // 
            this.lblNewCheckInSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewCheckInSchedule.AutoSize = true;
            this.lblNewCheckInSchedule.Location = new System.Drawing.Point(12, 65);
            this.lblNewCheckInSchedule.Name = "lblNewCheckInSchedule";
            this.lblNewCheckInSchedule.Size = new System.Drawing.Size(122, 13);
            this.lblNewCheckInSchedule.TabIndex = 5;
            this.lblNewCheckInSchedule.Text = "New check-in schedule:";
            // 
            // lblOriginalCheckInSchedule
            // 
            this.lblOriginalCheckInSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOriginalCheckInSchedule.AutoSize = true;
            this.lblOriginalCheckInSchedule.Location = new System.Drawing.Point(12, 27);
            this.lblOriginalCheckInSchedule.Name = "lblOriginalCheckInSchedule";
            this.lblOriginalCheckInSchedule.Size = new System.Drawing.Size(135, 13);
            this.lblOriginalCheckInSchedule.TabIndex = 1;
            this.lblOriginalCheckInSchedule.Text = "Original check-in schedule:";
            // 
            // panelLateArrival
            // 
            this.panelLateArrival.Controls.Add(this.dtpLateArrival);
            this.panelLateArrival.Controls.Add(this.dtpAdmissionSchedule);
            this.panelLateArrival.Controls.Add(this.lblLateArrivalSchedule);
            this.panelLateArrival.Controls.Add(this.lblAdmissioonSchedule);
            this.panelLateArrival.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLateArrival.Location = new System.Drawing.Point(0, 72);
            this.panelLateArrival.Name = "panelLateArrival";
            this.panelLateArrival.Size = new System.Drawing.Size(507, 99);
            this.panelLateArrival.TabIndex = 13;
            // 
            // dtpLateArrival
            // 
            this.dtpLateArrival.CalendarForeColor = System.Drawing.Color.White;
            this.dtpLateArrival.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.dtpLateArrival.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dtpLateArrival.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpLateArrival.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpLateArrival.CustomFormat = "HH:mm";
            this.dtpLateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLateArrival.Location = new System.Drawing.Point(153, 59);
            this.dtpLateArrival.Name = "dtpLateArrival";
            this.dtpLateArrival.ShowUpDown = true;
            this.dtpLateArrival.Size = new System.Drawing.Size(121, 20);
            this.dtpLateArrival.TabIndex = 10;
            // 
            // dtpAdmissionSchedule
            // 
            this.dtpAdmissionSchedule.CalendarForeColor = System.Drawing.Color.White;
            this.dtpAdmissionSchedule.CalendarMonthBackground = System.Drawing.Color.SteelBlue;
            this.dtpAdmissionSchedule.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dtpAdmissionSchedule.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpAdmissionSchedule.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpAdmissionSchedule.CustomFormat = "HH:mm";
            this.dtpAdmissionSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdmissionSchedule.Location = new System.Drawing.Point(153, 21);
            this.dtpAdmissionSchedule.Name = "dtpAdmissionSchedule";
            this.dtpAdmissionSchedule.ShowUpDown = true;
            this.dtpAdmissionSchedule.Size = new System.Drawing.Size(121, 20);
            this.dtpAdmissionSchedule.TabIndex = 9;
            // 
            // lblLateArrivalSchedule
            // 
            this.lblLateArrivalSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLateArrivalSchedule.AutoSize = true;
            this.lblLateArrivalSchedule.Location = new System.Drawing.Point(12, 65);
            this.lblLateArrivalSchedule.Name = "lblLateArrivalSchedule";
            this.lblLateArrivalSchedule.Size = new System.Drawing.Size(108, 13);
            this.lblLateArrivalSchedule.TabIndex = 5;
            this.lblLateArrivalSchedule.Text = "Late arrival schedule:";
            // 
            // lblAdmissioonSchedule
            // 
            this.lblAdmissioonSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmissioonSchedule.AutoSize = true;
            this.lblAdmissioonSchedule.Location = new System.Drawing.Point(12, 27);
            this.lblAdmissioonSchedule.Name = "lblAdmissioonSchedule";
            this.lblAdmissioonSchedule.Size = new System.Drawing.Size(109, 13);
            this.lblAdmissioonSchedule.TabIndex = 1;
            this.lblAdmissioonSchedule.Text = "Admissioon schedule:";
            // 
            // panelAbsences
            // 
            this.panelAbsences.Controls.Add(this.cmbAbsenceTypes);
            this.panelAbsences.Controls.Add(this.lblAusencias);
            this.panelAbsences.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbsences.Location = new System.Drawing.Point(0, 0);
            this.panelAbsences.Name = "panelAbsences";
            this.panelAbsences.Size = new System.Drawing.Size(507, 72);
            this.panelAbsences.TabIndex = 11;
            // 
            // cmbAbsenceTypes
            // 
            this.cmbAbsenceTypes.BackColor = System.Drawing.Color.White;
            this.cmbAbsenceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbsenceTypes.ForeColor = System.Drawing.Color.Black;
            this.cmbAbsenceTypes.FormattingEnabled = true;
            this.cmbAbsenceTypes.Location = new System.Drawing.Point(93, 24);
            this.cmbAbsenceTypes.Name = "cmbAbsenceTypes";
            this.cmbAbsenceTypes.Size = new System.Drawing.Size(244, 21);
            this.cmbAbsenceTypes.TabIndex = 3;
            // 
            // lblAusencias
            // 
            this.lblAusencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAusencias.AutoSize = true;
            this.lblAusencias.Location = new System.Drawing.Point(12, 27);
            this.lblAusencias.Name = "lblAusencias";
            this.lblAusencias.Size = new System.Drawing.Size(57, 13);
            this.lblAusencias.TabIndex = 1;
            this.lblAusencias.Text = "Absences:";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.SteelBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 21;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(507, 33);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.panelContainer);
            this.panelMaster.Controls.Add(this.btnSave);
            this.panelMaster.Location = new System.Drawing.Point(454, 62);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(507, 576);
            this.panelMaster.TabIndex = 13;
            // 
            // Exceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(994, 672);
            this.Controls.Add(this.panelMaster);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelAgent);
            this.Controls.Add(this.panelTeam);
            this.Controls.Add(this.panelCountry);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exceptions";
            this.Text = "Exceptions";
            ((System.ComponentModel.ISupportInitialize)(this.imgFlag)).EndInit();
            this.panelCountry.ResumeLayout(false);
            this.panelCountry.PerformLayout();
            this.panelTeam.ResumeLayout(false);
            this.panelTeam.PerformLayout();
            this.panelAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelObservations.ResumeLayout(false);
            this.panelObservations.PerformLayout();
            this.grpObservations.ResumeLayout(false);
            this.grpObservations.PerformLayout();
            this.panelShifChange.ResumeLayout(false);
            this.panelShifChange.PerformLayout();
            this.panelLateArrival.ResumeLayout(false);
            this.panelLateArrival.PerformLayout();
            this.panelAbsences.ResumeLayout(false);
            this.panelAbsences.PerformLayout();
            this.panelMaster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.PictureBox imgFlag;
        private System.Windows.Forms.Panel panelCountry;
        private System.Windows.Forms.Panel panelTeam;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Panel panelAgent;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.RadioButton rdbShiftChange;
        private System.Windows.Forms.RadioButton rdbLateArrival;
        private System.Windows.Forms.RadioButton rdbAbsence;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelShifChange;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblNewCheckInSchedule;
        private System.Windows.Forms.Label lblOriginalCheckInSchedule;
        private System.Windows.Forms.Panel panelLateArrival;
        private System.Windows.Forms.DateTimePicker dtpLateArrival;
        private System.Windows.Forms.DateTimePicker dtpAdmissionSchedule;
        private System.Windows.Forms.Label lblLateArrivalSchedule;
        private System.Windows.Forms.Label lblAdmissioonSchedule;
        private System.Windows.Forms.Panel panelAbsences;
        private System.Windows.Forms.ComboBox cmbAbsenceTypes;
        private System.Windows.Forms.Label lblAusencias;
        private System.Windows.Forms.Panel panelObservations;
        private System.Windows.Forms.GroupBox grpObservations;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.DateTimePicker dtpAbsenceDate;
        private System.Windows.Forms.Label lblAbsenceDate;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaya;
        private System.Windows.Forms.Panel panelMaster;
    }
}