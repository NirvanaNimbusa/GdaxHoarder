﻿namespace GdaxHoarder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddNewBurden = new System.Windows.Forms.Button();
            this.gridBurdens = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridBurdenLog = new System.Windows.Forms.DataGridView();
            this.btnLogRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBalancesRefresh = new System.Windows.Forms.Button();
            this.lblLtc = new System.Windows.Forms.Label();
            this.lblEth = new System.Windows.Forms.Label();
            this.lblBtc = new System.Windows.Forms.Label();
            this.lblUsd = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.burdenLogIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burdenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.burdenLogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingLog = new System.Windows.Forms.BindingSource(this.components);
            this.nextRunTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblBch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdenLog)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewBurden
            // 
            this.btnAddNewBurden.Location = new System.Drawing.Point(495, 167);
            this.btnAddNewBurden.Name = "btnAddNewBurden";
            this.btnAddNewBurden.Size = new System.Drawing.Size(119, 23);
            this.btnAddNewBurden.TabIndex = 2;
            this.btnAddNewBurden.Text = "Add New Task";
            this.btnAddNewBurden.UseVisualStyleBackColor = true;
            this.btnAddNewBurden.Click += new System.EventHandler(this.btnAddNewBurden_Click);
            // 
            // gridBurdens
            // 
            this.gridBurdens.AllowUserToAddRows = false;
            this.gridBurdens.AllowUserToDeleteRows = false;
            this.gridBurdens.AllowUserToResizeColumns = false;
            this.gridBurdens.AllowUserToResizeRows = false;
            this.gridBurdens.AutoGenerateColumns = false;
            this.gridBurdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBurdens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.nextRunTimeDataGridViewTextBoxColumn,
            this.Edit,
            this.DeleteColumn});
            this.gridBurdens.DataSource = this.bindingSource1;
            this.gridBurdens.Location = new System.Drawing.Point(6, 19);
            this.gridBurdens.Name = "gridBurdens";
            this.gridBurdens.ReadOnly = true;
            this.gridBurdens.Size = new System.Drawing.Size(611, 142);
            this.gridBurdens.TabIndex = 0;
            this.gridBurdens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.gridBurdens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.DataPropertyName = "Task";
            this.Task.FillWeight = 200F;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAddNewBurden);
            this.groupBox1.Controls.Add(this.gridBurdens);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tasks";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(370, 167);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridBurdenLog);
            this.groupBox2.Controls.Add(this.btnLogRefresh);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // gridBurdenLog
            // 
            this.gridBurdenLog.AllowUserToAddRows = false;
            this.gridBurdenLog.AllowUserToDeleteRows = false;
            this.gridBurdenLog.AutoGenerateColumns = false;
            this.gridBurdenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBurdenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.burdenLogIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.burdenNameDataGridViewTextBoxColumn,
            this.successDataGridViewCheckBoxColumn,
            this.burdenLogNameDataGridViewTextBoxColumn});
            this.gridBurdenLog.DataSource = this.bindingLog;
            this.gridBurdenLog.Location = new System.Drawing.Point(6, 19);
            this.gridBurdenLog.Name = "gridBurdenLog";
            this.gridBurdenLog.ReadOnly = true;
            this.gridBurdenLog.Size = new System.Drawing.Size(608, 160);
            this.gridBurdenLog.TabIndex = 0;
            // 
            // btnLogRefresh
            // 
            this.btnLogRefresh.Location = new System.Drawing.Point(498, 185);
            this.btnLogRefresh.Name = "btnLogRefresh";
            this.btnLogRefresh.Size = new System.Drawing.Size(119, 23);
            this.btnLogRefresh.TabIndex = 1;
            this.btnLogRefresh.Text = "Refresh";
            this.btnLogRefresh.UseVisualStyleBackColor = true;
            this.btnLogRefresh.Click += new System.EventHandler(this.btnLogRefresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BurdenTypeId";
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Task";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblBch);
            this.groupBox3.Controls.Add(this.btnBalancesRefresh);
            this.groupBox3.Controls.Add(this.lblLtc);
            this.groupBox3.Controls.Add(this.lblEth);
            this.groupBox3.Controls.Add(this.lblBtc);
            this.groupBox3.Controls.Add(this.lblUsd);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 41);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Balances";
            // 
            // btnBalancesRefresh
            // 
            this.btnBalancesRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBalancesRefresh.Location = new System.Drawing.Point(534, 13);
            this.btnBalancesRefresh.Name = "btnBalancesRefresh";
            this.btnBalancesRefresh.Size = new System.Drawing.Size(83, 23);
            this.btnBalancesRefresh.TabIndex = 4;
            this.btnBalancesRefresh.Text = "Refresh";
            this.btnBalancesRefresh.UseVisualStyleBackColor = true;
            this.btnBalancesRefresh.Click += new System.EventHandler(this.btnBalancesRefresh_Click);
            // 
            // lblLtc
            // 
            this.lblLtc.AutoSize = true;
            this.lblLtc.Location = new System.Drawing.Point(315, 18);
            this.lblLtc.Name = "lblLtc";
            this.lblLtc.Size = new System.Drawing.Size(30, 13);
            this.lblLtc.TabIndex = 3;
            this.lblLtc.Text = "LTC:";
            // 
            // lblEth
            // 
            this.lblEth.AutoSize = true;
            this.lblEth.Location = new System.Drawing.Point(202, 18);
            this.lblEth.Name = "lblEth";
            this.lblEth.Size = new System.Drawing.Size(32, 13);
            this.lblEth.TabIndex = 2;
            this.lblEth.Text = "ETH:";
            // 
            // lblBtc
            // 
            this.lblBtc.AutoSize = true;
            this.lblBtc.Location = new System.Drawing.Point(92, 18);
            this.lblBtc.Name = "lblBtc";
            this.lblBtc.Size = new System.Drawing.Size(31, 13);
            this.lblBtc.TabIndex = 1;
            this.lblBtc.Text = "BTC:";
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Location = new System.Drawing.Point(9, 18);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(33, 13);
            this.lblUsd.TabIndex = 0;
            this.lblUsd.Text = "USD:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GDax Hoarder";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // burdenLogIdDataGridViewTextBoxColumn
            // 
            this.burdenLogIdDataGridViewTextBoxColumn.DataPropertyName = "BurdenLogId";
            this.burdenLogIdDataGridViewTextBoxColumn.HeaderText = "BurdenLogId";
            this.burdenLogIdDataGridViewTextBoxColumn.Name = "burdenLogIdDataGridViewTextBoxColumn";
            this.burdenLogIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.burdenLogIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 110;
            // 
            // burdenNameDataGridViewTextBoxColumn
            // 
            this.burdenNameDataGridViewTextBoxColumn.DataPropertyName = "BurdenName";
            this.burdenNameDataGridViewTextBoxColumn.HeaderText = "BurdenName";
            this.burdenNameDataGridViewTextBoxColumn.Name = "burdenNameDataGridViewTextBoxColumn";
            this.burdenNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.burdenNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // successDataGridViewCheckBoxColumn
            // 
            this.successDataGridViewCheckBoxColumn.DataPropertyName = "Success";
            this.successDataGridViewCheckBoxColumn.HeaderText = "Success";
            this.successDataGridViewCheckBoxColumn.Name = "successDataGridViewCheckBoxColumn";
            this.successDataGridViewCheckBoxColumn.ReadOnly = true;
            this.successDataGridViewCheckBoxColumn.Width = 60;
            // 
            // burdenLogNameDataGridViewTextBoxColumn
            // 
            this.burdenLogNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.burdenLogNameDataGridViewTextBoxColumn.DataPropertyName = "BurdenLogName";
            this.burdenLogNameDataGridViewTextBoxColumn.HeaderText = "BurdenLogName";
            this.burdenLogNameDataGridViewTextBoxColumn.Name = "burdenLogNameDataGridViewTextBoxColumn";
            this.burdenLogNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingLog
            // 
            this.bindingLog.DataSource = typeof(GdaxHoarder.Data.Entities.BurdenLog);
            // 
            // nextRunTimeDataGridViewTextBoxColumn
            // 
            this.nextRunTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nextRunTimeDataGridViewTextBoxColumn.DataPropertyName = "NextRunTime";
            this.nextRunTimeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nextRunTimeDataGridViewTextBoxColumn.HeaderText = "NextRunTime";
            this.nextRunTimeDataGridViewTextBoxColumn.Name = "nextRunTimeDataGridViewTextBoxColumn";
            this.nextRunTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nextRunTimeDataGridViewTextBoxColumn.Width = 97;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GdaxHoarder.Data.EntityViews.BurdenView);
            // 
            // lblBch
            // 
            this.lblBch.AutoSize = true;
            this.lblBch.Location = new System.Drawing.Point(426, 18);
            this.lblBch.Name = "lblBch";
            this.lblBch.Size = new System.Drawing.Size(32, 13);
            this.lblBch.TabIndex = 4;
            this.lblBch.Text = "BCH:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDax Hoarder by http://howtoaddict.com";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBurdenLog)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewBurden;
        private System.Windows.Forms.DataGridView gridBurdens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogRefresh;
        private System.Windows.Forms.DataGridView gridBurdenLog;
        private System.Windows.Forms.BindingSource bindingLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLtc;
        private System.Windows.Forms.Label lblEth;
        private System.Windows.Forms.Label lblBtc;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenLogIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn successDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burdenLogNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnBalancesRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextRunTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Label lblBch;
    }
}