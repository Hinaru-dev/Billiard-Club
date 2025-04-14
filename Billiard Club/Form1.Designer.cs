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
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.lblDurationOfTime = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTableStatus = new System.Windows.Forms.Label();
            this.lblTable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(969, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(30, 28);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "X";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblTimeCounter);
            this.panel1.Controls.Add(this.lblDurationOfTime);
            this.panel1.Controls.Add(this.lblTimeIn);
            this.panel1.Controls.Add(this.tbPlayerName);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.lblTableStatus);
            this.panel1.Controls.Add(this.lblTable1);
            this.panel1.Location = new System.Drawing.Point(25, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 256);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(117, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(23, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 17);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "The Price :";
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.Location = new System.Drawing.Point(8, 196);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(101, 17);
            this.lblTimeCounter.TabIndex = 9;
            this.lblTimeCounter.Text = "Time Counter :";
            // 
            // lblDurationOfTime
            // 
            this.lblDurationOfTime.AutoSize = true;
            this.lblDurationOfTime.Location = new System.Drawing.Point(8, 167);
            this.lblDurationOfTime.Name = "lblDurationOfTime";
            this.lblDurationOfTime.Size = new System.Drawing.Size(124, 17);
            this.lblDurationOfTime.TabIndex = 8;
            this.lblDurationOfTime.Text = "Duration Of Time :";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Location = new System.Drawing.Point(8, 138);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(62, 17);
            this.lblTimeIn.TabIndex = 7;
            this.lblTimeIn.Text = "Time In :";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(113, 50);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(100, 22);
            this.tbPlayerName.TabIndex = 4;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(8, 53);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(101, 17);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // lblTableStatus
            // 
            this.lblTableStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTableStatus.AutoSize = true;
            this.lblTableStatus.BackColor = System.Drawing.Color.Lime;
            this.lblTableStatus.Location = new System.Drawing.Point(0, 20);
            this.lblTableStatus.Name = "lblTableStatus";
            this.lblTableStatus.Padding = new System.Windows.Forms.Padding(89, 0, 90, 0);
            this.lblTableStatus.Size = new System.Drawing.Size(216, 17);
            this.lblTableStatus.TabIndex = 2;
            this.lblTableStatus.Text = "Free";
            // 
            // lblTable1
            // 
            this.lblTable1.AutoSize = true;
            this.lblTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTable1.Location = new System.Drawing.Point(0, 0);
            this.lblTable1.Name = "lblTable1";
            this.lblTable1.Padding = new System.Windows.Forms.Padding(80, 0, 80, 0);
            this.lblTable1.Size = new System.Drawing.Size(216, 17);
            this.lblTable1.TabIndex = 0;
            this.lblTable1.Text = "Table 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(359, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 60);
            this.label1.TabIndex = 13;
            this.label1.Text = "Billiard Club";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTable1;
        private System.Windows.Forms.Label lblTableStatus;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTimeCounter;
        private System.Windows.Forms.Label lblDurationOfTime;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label label1;
    }
}

