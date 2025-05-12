using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_Club
{
    public partial class Form1 : Form
    {
        enum enTableID { Table1 = 2, Table2 = 4, Table3 = 8, Table4 = 16, Table5 = 32, Table6 = 64, Table7 = 128 };
        const byte TotalTablesCount = 7;
        byte startedTables;
        byte pausedTables;

        public Form1()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            //lblTheme.Text = "00:00";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeTableStatus(enTableID tableID)
        {
            switch (tableID)
            {
                case enTableID.Table1:
                    lblTableStatus1.Text = "Playing";
                    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                    lblTableStatus1.BackColor = Color.Yellow;
                    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
                //case enTableID.Table1:
                //    lblTableStatus1.Text = "Playing";
                //    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                //    lblTableStatus1.BackColor = Color.Yellow;
                //    break;
            }
        }

        private void SetTimeIn(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                //    return;
            }
        }

        private void InitializeTimeCounter(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    lblTimeCounter1.Text = "00:00";
                    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
                //case enTableID.Table1:
                //    // testing for now i'll refactor later
                //    lblTimeCounter1.Text = "00:00";
                //    return;
            }
        }

        private string CalculatePrice(enTableID TableID)
        {
            decimal price = 0;
            
            switch (TableID)
            {
                case enTableID.Table1:
                    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
                //case enTableID.Table1:
                //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration1.Text.Substring(0, 2))), 2);
                //    break;
            }

            return price.ToString() + "$";
        }

        private void SetThePrice(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    lblThePrice1.Text = CalculatePrice(TableID);
                    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
                //case enTableID.Table1:
                //    lblThePrice1.Text = CalculatePrice(TableID);
                //    return;
            }
        }

        private void Start(enTableID TableID)
        {
            SetTimeIn(TableID);
            ChangeTableStatus(TableID);
            InitializeTimeCounter(TableID);
            SetThePrice(TableID);

            // add to started tables if not already added
            if ((startedTables & (byte)TableID) == 0)
                startedTables += (byte)TableID;

            // terminating start
            btnPause1.Visible = true;
            btnStart1.Visible = false;
        }

        private bool isValidDuration(MaskedTextBox Duration)
        {
            if (char.IsDigit(Duration.Text[0]) 
             && char.IsDigit(Duration.Text[1]) 
             && Duration.Text != "00:00")
                return true;

            return false;
        }

        // btnStart(btn which_button_clicked) function

        private void btnStart1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPlayerName1.Text.Trim()))
            {
                MessageBox.Show("Enter Name First, Please!", "Missing Player Name");
                return;
            }
            
            if (!isValidDuration(mtbDuration1))
            {
                MessageBox.Show("Set Valid Duration, Please!", "Invalid revservaion Duration");
                return;
            }

            Start(enTableID.Table1);
        }

        private string formatTimeCounter(TimeSpan TimeCounter)
        {
            string formattedTimeCounter = string.Empty;

            //format Minutes
            if (TimeCounter.Minutes < 10)
                formattedTimeCounter += "0" + TimeCounter.Minutes.ToString();
            else
                formattedTimeCounter += TimeCounter.Minutes.ToString();

            // format seconds
            if (TimeCounter.Seconds < 10)
                formattedTimeCounter += ":0" + TimeCounter.Seconds.ToString();
            else
                formattedTimeCounter += ":" + TimeCounter.Seconds.ToString();

            return formattedTimeCounter;
        }

        private void UpdateTableTimeCounter(enTableID TableID)
        {
            TimeSpan TimeCounter;
            switch (TableID)
            {
                case enTableID.Table1:
                    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
                //case enTableID.Table1:
                //    TimeSpan.TryParse(lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                //    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                //    lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                //    return;
            }
        }

        bool isDurationFinished(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    return lblTimeCounter1.Text == mtbDuration1.Text;
            }

            // here should be return true to stop any glitched timer
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update app time
            DateTime AppTime;
            DateTime.TryParse(lblTime.Text, out AppTime);
            lblTime.Text = AppTime.AddSeconds(1).ToLongTimeString();

            // ADD 1 second to Each Time Counter
            for (byte i = 1; i < TotalTablesCount; i++)
            {
                byte TwoPowTableID = (byte)Math.Pow(2, i);
                if ((startedTables & TwoPowTableID) == TwoPowTableID)
                {
                    if (isDurationFinished((enTableID)TwoPowTableID))
                    {
                        // at this point 
                        // i can perform a table stop 
                        // or show message box 
                        // or a notifyIcon
                        continue;
                    }

                    UpdateTableTimeCounter((enTableID)TwoPowTableID);
                }
            }
        }
    }
}