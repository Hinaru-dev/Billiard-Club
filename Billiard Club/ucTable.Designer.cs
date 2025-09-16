namespace Billiard_Club
{
    partial class ucTable
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
            this.mtbDuration = new System.Windows.Forms.MaskedTextBox();
            this.lblThePrice = new System.Windows.Forms.Label();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label324321 = new System.Windows.Forms.Label();
            this.label43241 = new System.Windows.Forms.Label();
            this.lblDurationOfTime = new System.Windows.Forms.Label();
            this.label432 = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbDuration
            // 
            this.mtbDuration.CausesValidation = false;
            this.mtbDuration.Location = new System.Drawing.Point(138, 166);
            this.mtbDuration.Mask = "99:\\0\\0";
            this.mtbDuration.Name = "mtbDuration";
            this.mtbDuration.Size = new System.Drawing.Size(59, 22);
            this.mtbDuration.TabIndex = 43;
            this.mtbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblThePrice
            // 
            this.lblThePrice.AutoSize = true;
            this.lblThePrice.Location = new System.Drawing.Point(90, 227);
            this.lblThePrice.Name = "lblThePrice";
            this.lblThePrice.Size = new System.Drawing.Size(69, 17);
            this.lblThePrice.TabIndex = 42;
            this.lblThePrice.Text = "DateTime";
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.Location = new System.Drawing.Point(113, 198);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(69, 17);
            this.lblTimeCounter.TabIndex = 41;
            this.lblTimeCounter.Text = "DateTime";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Location = new System.Drawing.Point(75, 140);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(69, 17);
            this.lblTimeIn.TabIndex = 40;
            this.lblTimeIn.Text = "DateTime";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStop.Location = new System.Drawing.Point(116, 91);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label324321
            // 
            this.label324321.AutoSize = true;
            this.label324321.Location = new System.Drawing.Point(7, 227);
            this.label324321.Name = "label324321";
            this.label324321.Size = new System.Drawing.Size(77, 17);
            this.label324321.TabIndex = 37;
            this.label324321.Text = "The Price :";
            // 
            // label43241
            // 
            this.label43241.AutoSize = true;
            this.label43241.Location = new System.Drawing.Point(7, 198);
            this.label43241.Name = "label43241";
            this.label43241.Size = new System.Drawing.Size(101, 17);
            this.label43241.TabIndex = 36;
            this.label43241.Text = "Time Counter :";
            // 
            // lblDurationOfTime
            // 
            this.lblDurationOfTime.AutoSize = true;
            this.lblDurationOfTime.Location = new System.Drawing.Point(7, 169);
            this.lblDurationOfTime.Name = "lblDurationOfTime";
            this.lblDurationOfTime.Size = new System.Drawing.Size(124, 17);
            this.lblDurationOfTime.TabIndex = 35;
            this.lblDurationOfTime.Text = "Duration Of Time :";
            // 
            // label432
            // 
            this.label432.AutoSize = true;
            this.label432.Location = new System.Drawing.Point(7, 140);
            this.label432.Name = "label432";
            this.label432.Size = new System.Drawing.Size(62, 17);
            this.label432.TabIndex = 34;
            this.label432.Text = "Time In :";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(108, 52);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(100, 22);
            this.tbPlayerName.TabIndex = 33;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(7, 55);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 17);
            this.lblPlayerName.TabIndex = 32;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // lblTableStatus
            // 
            this.lblTableStatus.BackColor = System.Drawing.Color.Lime;
            this.lblTableStatus.Location = new System.Drawing.Point(-33, 20);
            this.lblTableStatus.Name = "lblTableStatus";
            this.lblTableStatus.Padding = new System.Windows.Forms.Padding(89, 0, 90, 0);
            this.lblTableStatus.Size = new System.Drawing.Size(281, 17);
            this.lblTableStatus.TabIndex = 31;
            this.lblTableStatus.Text = "Free";
            this.lblTableStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTable.Location = new System.Drawing.Point(0, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.lblTable.Size = new System.Drawing.Size(216, 17);
            this.lblTable.TabIndex = 30;
            this.lblTable.Text = "Table 1";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(22, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPause.Location = new System.Drawing.Point(22, 91);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 30);
            this.btnPause.TabIndex = 44;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.mtbDuration);
            this.Controls.Add(this.lblThePrice);
            this.Controls.Add(this.lblTimeCounter);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label324321);
            this.Controls.Add(this.label43241);
            this.Controls.Add(this.lblDurationOfTime);
            this.Controls.Add(this.label432);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblTableStatus);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(214, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbDuration;
        private System.Windows.Forms.Label lblThePrice;
        private System.Windows.Forms.Label lblTimeCounter;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label324321;
        private System.Windows.Forms.Label label43241;
        private System.Windows.Forms.Label lblDurationOfTime;
        private System.Windows.Forms.Label label432;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
    }
}
