using System;

namespace Billiard_Club
{
    partial class Form1
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblBilliardClub = new System.Windows.Forms.Label();
            this.panelX = new System.Windows.Forms.Panel();
            this.lblEarnedIncome = new System.Windows.Forms.Label();
            this.lblTotalCustomersToday = new System.Windows.Forms.Label();
            this.lblAvailableTables = new System.Windows.Forms.Label();
            this.lblReservedTables = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.nudHourlyPrice = new System.Windows.Forms.NumericUpDown();
            this.lblHourlyPrice = new System.Windows.Forms.Label();
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucTable1 = new Billiard_Club.ucTable(this, (byte)enTableID.Table1);
            this.ucTable2 = new Billiard_Club.ucTable(this, (byte)enTableID.Table2);
            this.ucTable3 = new Billiard_Club.ucTable(this, (byte)enTableID.Table3);
            this.ucTable4 = new Billiard_Club.ucTable(this, (byte)enTableID.Table4);
            this.ucTable5 = new Billiard_Club.ucTable(this, (byte)enTableID.Table5);
            this.ucTable6 = new Billiard_Club.ucTable(this, (byte)enTableID.Table6);
            this.ucTable7 = new Billiard_Club.ucTable(this, (byte)enTableID.Table7);
            this.panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(959, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(30, 28);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblBilliardClub
            // 
            this.lblBilliardClub.AutoSize = true;
            this.lblBilliardClub.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilliardClub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBilliardClub.Location = new System.Drawing.Point(359, 12);
            this.lblBilliardClub.Name = "lblBilliardClub";
            this.lblBilliardClub.Size = new System.Drawing.Size(282, 58);
            this.lblBilliardClub.TabIndex = 13;
            this.lblBilliardClub.Text = "Billiard Club";
            // 
            // panelX
            // 
            this.panelX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelX.Controls.Add(this.lblEarnedIncome);
            this.panelX.Controls.Add(this.lblTotalCustomersToday);
            this.panelX.Controls.Add(this.lblAvailableTables);
            this.panelX.Controls.Add(this.lblReservedTables);
            this.panelX.Controls.Add(this.lblTime);
            this.panelX.Controls.Add(this.label29);
            this.panelX.Controls.Add(this.lblDate);
            this.panelX.Controls.Add(this.label28);
            this.panelX.Controls.Add(this.label24);
            this.panelX.Controls.Add(this.label23);
            this.panelX.Controls.Add(this.label25);
            this.panelX.Controls.Add(this.label26);
            this.panelX.Controls.Add(this.label27);
            this.panelX.Location = new System.Drawing.Point(759, 367);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(216, 256);
            this.panelX.TabIndex = 19;
            // 
            // lblEarnedIncome
            // 
            this.lblEarnedIncome.AutoSize = true;
            this.lblEarnedIncome.Location = new System.Drawing.Point(146, 213);
            this.lblEarnedIncome.Name = "lblEarnedIncome";
            this.lblEarnedIncome.Size = new System.Drawing.Size(56, 17);
            this.lblEarnedIncome.TabIndex = 27;
            this.lblEarnedIncome.Text = "50000$";
            // 
            // lblTotalCustomersToday
            // 
            this.lblTotalCustomersToday.AutoSize = true;
            this.lblTotalCustomersToday.Location = new System.Drawing.Point(144, 182);
            this.lblTotalCustomersToday.Name = "lblTotalCustomersToday";
            this.lblTotalCustomersToday.Size = new System.Drawing.Size(48, 17);
            this.lblTotalCustomersToday.TabIndex = 26;
            this.lblTotalCustomersToday.Text = "50000";
            // 
            // lblAvailableTables
            // 
            this.lblAvailableTables.AutoSize = true;
            this.lblAvailableTables.Location = new System.Drawing.Point(153, 151);
            this.lblAvailableTables.Name = "lblAvailableTables";
            this.lblAvailableTables.Size = new System.Drawing.Size(48, 17);
            this.lblAvailableTables.TabIndex = 25;
            this.lblAvailableTables.Text = "50000";
            // 
            // lblReservedTables
            // 
            this.lblReservedTables.AutoSize = true;
            this.lblReservedTables.Location = new System.Drawing.Point(156, 120);
            this.lblReservedTables.Name = "lblReservedTables";
            this.lblReservedTables.Size = new System.Drawing.Size(48, 17);
            this.lblReservedTables.TabIndex = 24;
            this.lblReservedTables.Text = "50000";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(72, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 17);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "DateTime";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label29.Location = new System.Drawing.Point(14, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 17);
            this.label29.TabIndex = 22;
            this.label29.Text = "Date :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(72, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 17);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "DateTime";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(14, 213);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 17);
            this.label28.TabIndex = 17;
            this.label28.Text = "Earned Income :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(14, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 17);
            this.label24.TabIndex = 16;
            this.label24.Text = "Today\'s Clients:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(135, 29);
            this.label23.TabIndex = 13;
            this.label23.Text = "Summary :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(14, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(133, 17);
            this.label25.TabIndex = 15;
            this.label25.Text = "Available Tables:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(14, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 17);
            this.label26.TabIndex = 14;
            this.label26.Text = "Reserved Tables:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(14, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 17);
            this.label27.TabIndex = 13;
            this.label27.Text = "Time :";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(25, 44);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(56, 17);
            this.lblTheme.TabIndex = 14;
            this.lblTheme.Text = "Theme:";
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Checked = true;
            this.rbLight.Location = new System.Drawing.Point(85, 42);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(60, 21);
            this.rbLight.TabIndex = 20;
            this.rbLight.TabStop = true;
            this.rbLight.Text = "Light";
            this.rbLight.UseVisualStyleBackColor = true;
            // 
            // nudHourlyPrice
            // 
            this.nudHourlyPrice.DecimalPlaces = 2;
            this.nudHourlyPrice.Location = new System.Drawing.Point(869, 51);
            this.nudHourlyPrice.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudHourlyPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHourlyPrice.Name = "nudHourlyPrice";
            this.nudHourlyPrice.Size = new System.Drawing.Size(71, 22);
            this.nudHourlyPrice.TabIndex = 29;
            this.nudHourlyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHourlyPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHourlyPrice
            // 
            this.lblHourlyPrice.AutoSize = true;
            this.lblHourlyPrice.Location = new System.Drawing.Point(759, 53);
            this.lblHourlyPrice.Name = "lblHourlyPrice";
            this.lblHourlyPrice.Size = new System.Drawing.Size(107, 17);
            this.lblHourlyPrice.TabIndex = 30;
            this.lblHourlyPrice.Text = "Hourly Price ($)";
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(150, 42);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(59, 21);
            this.rbDark.TabIndex = 31;
            this.rbDark.TabStop = true;
            this.rbDark.Text = "Dark";
            this.rbDark.UseVisualStyleBackColor = true;
            this.rbDark.CheckedChanged += new System.EventHandler(this.rbDark_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucTable1
            // 
            this.ucTable1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable1.Location = new System.Drawing.Point(26, 87);
            this.ucTable1.Name = "ucTable1";
            this.ucTable1.Size = new System.Drawing.Size(214, 256);
            this.ucTable1.TabIndex = 32;
            this.ucTable1.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable1_ButtonClicked);
            // 
            // ucTable2
            // 
            this.ucTable2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable2.Location = new System.Drawing.Point(270, 87);
            this.ucTable2.Name = "ucTable2";
            this.ucTable2.Size = new System.Drawing.Size(214, 256);
            this.ucTable2.TabIndex = 33;
            this.ucTable2.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable2_ButtonClicked);
            // 
            // ucTable3
            // 
            this.ucTable3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable3.Location = new System.Drawing.Point(514, 87);
            this.ucTable3.Name = "ucTable3";
            this.ucTable3.Size = new System.Drawing.Size(214, 256);
            this.ucTable3.TabIndex = 34;
            this.ucTable3.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable3_ButtonClicked);
            // 
            // ucTable4
            // 
            this.ucTable4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable4.Location = new System.Drawing.Point(760, 87);
            this.ucTable4.Name = "ucTable4";
            this.ucTable4.Size = new System.Drawing.Size(214, 256);
            this.ucTable4.TabIndex = 35;
            this.ucTable4.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable4_ButtonClicked);
            // 
            // ucTable5
            // 
            this.ucTable5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable5.Location = new System.Drawing.Point(26, 367);
            this.ucTable5.Name = "ucTable5";
            this.ucTable5.Size = new System.Drawing.Size(214, 256);
            this.ucTable5.TabIndex = 36;
            this.ucTable5.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable5_ButtonClicked);
            // 
            // ucTable6
            // 
            this.ucTable6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable6.Location = new System.Drawing.Point(270, 367);
            this.ucTable6.Name = "ucTable6";
            this.ucTable6.Size = new System.Drawing.Size(214, 256);
            this.ucTable6.TabIndex = 37;
            this.ucTable6.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable6_ButtonClicked);
            // 
            // ucTable7
            // 
            this.ucTable7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucTable7.Location = new System.Drawing.Point(514, 367);
            this.ucTable7.Name = "ucTable7";
            this.ucTable7.Size = new System.Drawing.Size(214, 256);
            this.ucTable7.TabIndex = 38;
            this.ucTable7.ButtonClicked += new System.Action<Billiard_Club.Form1.enTableOp, string>(this.ucTable7_ButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 670);
            this.Controls.Add(this.ucTable7);
            this.Controls.Add(this.ucTable6);
            this.Controls.Add(this.ucTable5);
            this.Controls.Add(this.ucTable4);
            this.Controls.Add(this.ucTable3);
            this.Controls.Add(this.ucTable2);
            this.Controls.Add(this.ucTable1);
            this.Controls.Add(this.lblHourlyPrice);
            this.Controls.Add(this.nudHourlyPrice);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.panelX);
            this.Controls.Add(this.lblBilliardClub);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.rbDark);
            this.Controls.Add(this.rbLight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelX.ResumeLayout(false);
            this.panelX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourlyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblBilliardClub;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown nudHourlyPrice;
        private System.Windows.Forms.Label lblHourlyPrice;
        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotalCustomersToday;
        private System.Windows.Forms.Label lblAvailableTables;
        private System.Windows.Forms.Label lblReservedTables;
        private System.Windows.Forms.Label lblEarnedIncome;
        private ucTable ucTable1;
        private ucTable ucTable2;
        private ucTable ucTable3;
        private ucTable ucTable4;
        private ucTable ucTable5;
        private ucTable ucTable6;
        private ucTable ucTable7;
    }
}

