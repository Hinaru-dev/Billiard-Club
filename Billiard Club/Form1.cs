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
        public decimal getNudHourlyPrice()
        {
            return nudHourlyPrice.Value;
        }

        // functionng enums
        public enum enTableID { Table1 = 2, Table2 = 4, Table3 = 8, Table4 = 16, Table5 = 32, Table6 = 64, Table7 = 128 };
        public enum enTableOp { Start = 0, Pause = 1, Continue = 2, Stop = 3 };
        // functioning data
        public const byte TotalTablesCount = 7;
        public byte startedTables = 0;
        public byte pausedTables = 0;

        public Form1()
        {
            InitializeComponent();

            // using this way to use constructor
            // without blocking form1[design]
            // from working 
            //this.ucTable1 = new Billiard_Club.ucTable(this, 2);

            // Initialize Summary Panel
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            InitializeSummaryStatistics();
            UpdateSummaryPanel();

            for (byte i = 1; i<=TotalTablesCount; i++)
                InitializeTable((enTableID)Math.Pow(2,i));
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void affectTableStatusChange(Label lblTableStatus, string status, Color colorValue)
        {
            lblTableStatus.Text = status;
            lblTableStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblTableStatus.BackColor = colorValue;
        }

        private void ChangeTableStatus(enTableID tableID, enTableOp TableOp)
        {
            string Status = TableOp == enTableOp.Stop ? "Free" : TableOp == enTableOp.Pause ? "Paused!" : "Playing";
            
            Color Value = TableOp == enTableOp.Stop ? Color.Lime : TableOp == enTableOp.Pause ? Color.Orange : Color.Yellow;

            switch (tableID)
            {
                case enTableID.Table1:
                    //affectTableStatusChange(lblTableStatus1, Status, Value);
                    break;
                case enTableID.Table2:
                    affectTableStatusChange(lblTableStatus2, Status, Value);
                    break;
                case enTableID.Table3:
                    affectTableStatusChange(lblTableStatus3, Status, Value);
                    break;
                case enTableID.Table4:
                    affectTableStatusChange(lblTableStatus4, Status, Value);
                    break;
                case enTableID.Table5:
                    affectTableStatusChange(lblTableStatus5, Status, Value);
                    break;
                case enTableID.Table6:
                    affectTableStatusChange(lblTableStatus6, Status, Value);
                    break;
                case enTableID.Table7:
                    affectTableStatusChange(lblTableStatus7, Status, Value);
                    break;
            }
        }

        private void SetTimeIn(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    //lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table2:
                    lblTimeIn2.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table3:
                    lblTimeIn3.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table4:
                    lblTimeIn4.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table5:
                    lblTimeIn5.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table6:
                    lblTimeIn6.Text = DateTime.Now.ToShortTimeString();
                    return;
                case enTableID.Table7:
                    lblTimeIn7.Text = DateTime.Now.ToShortTimeString();
                    return;
                default:
                    return;
            }
        }

        private void InitializeTable(enTableID TableID)
        {
            switch(TableID)
            {
                case enTableID.Table1:
                    //tbPlayerName1.Clear();
                    //lblTimeIn1.Text = string.Empty;
                    //mtbDuration1.Clear();
                    //lblTimeCounter1.Text = "00:00";
                    //lblThePrice1.Text = "0$";
                    return;
                case enTableID.Table2:
                    tbPlayerName2.Clear();
                    lblTimeIn2.Text = string.Empty;
                    mtbDuration2.Clear();
                    lblTimeCounter2.Text = "00:00";
                    lblThePrice2.Text = "0$";
                    return;
                case enTableID.Table3:
                    tbPlayerName3.Clear();
                    lblTimeIn3.Text = string.Empty;
                    mtbDuration3.Clear();
                    lblTimeCounter3.Text = "00:00";
                    lblThePrice3.Text = "0$";
                    return;
                case enTableID.Table4:
                    tbPlayerName4.Clear();
                    lblTimeIn4.Text = string.Empty;
                    mtbDuration4.Clear();
                    lblTimeCounter4.Text = "00:00";
                    lblThePrice4.Text = "0$";
                    return;
                case enTableID.Table5:
                    tbPlayerName5.Clear();
                    lblTimeIn5.Text = string.Empty;
                    mtbDuration5.Clear();
                    lblTimeCounter5.Text = "00:00";
                    lblThePrice5.Text = "0$";
                    return;
                case enTableID.Table6:
                    tbPlayerName6.Clear();
                    lblTimeIn6.Text = string.Empty;
                    mtbDuration6.Clear();
                    lblTimeCounter6.Text = "00:00";
                    lblThePrice6.Text = "0$";
                    return;
                case enTableID.Table7:
                    tbPlayerName7.Clear();
                    lblTimeIn7.Text = string.Empty;
                    mtbDuration7.Clear();
                    lblTimeCounter7.Text = "00:00";
                    lblThePrice7.Text = "0$";
                    return;
            }
        }

        private void InitializeTimeCounter(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    //lblTimeCounter1.Text = "00:00";
                    return;
                case enTableID.Table2:
                    lblTimeCounter2.Text = "00:00";
                    return;
                case enTableID.Table3:
                    lblTimeCounter3.Text = "00:00";
                    return;
                case enTableID.Table4:
                    lblTimeCounter4.Text = "00:00";
                    return;
                case enTableID.Table5:
                    lblTimeCounter5.Text = "00:00";
                    return;
                case enTableID.Table6:
                    lblTimeCounter6.Text = "00:00";
                    return;
                case enTableID.Table7:
                    lblTimeCounter7.Text = "00:00";
                    return;
            }
        }

        private string CalculatePrice(enTableID TableID, enTableOp TableOp)
        {
            decimal price = 0;
            
            switch (TableID)
            {
                case enTableID.Table1:
                    //if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                    //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(//mtbDuration1.Text.Substring(0, 2))), 2);
                    //else
                    //    price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(//lblTimeCounter1.Text.Substring(0, 2))), 2);
                    //break;

                case enTableID.Table2:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration2.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter2.Text.Substring(0, 2))), 2);
                    break;

                case enTableID.Table3:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration3.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter3.Text.Substring(0, 2))), 2);
                    break;

                case enTableID.Table4:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration4.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter4.Text.Substring(0, 2))), 2);
                    break;

                case enTableID.Table5:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration5.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter5.Text.Substring(0, 2))), 2);
                    break;

                case enTableID.Table6:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration6.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter6.Text.Substring(0, 2))), 2);
                    break;

                case enTableID.Table7:
                    if (isDurationFinished(TableID) || TableOp == enTableOp.Start)
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration7.Text.Substring(0, 2))), 2);
                    else
                        price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(lblTimeCounter7.Text.Substring(0, 2))), 2);
                    break;
            }

            return price.ToString() + "$";
        }

        private void SetThePrice(enTableID TableID, enTableOp TableOp)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    //lblThePrice1.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table2:
                    lblThePrice2.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table3:
                    lblThePrice3.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table4:
                    lblThePrice4.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table5:
                    lblThePrice5.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table6:
                    lblThePrice6.Text = CalculatePrice(TableID, TableOp);
                    return;
                case enTableID.Table7:
                    lblThePrice7.Text = CalculatePrice(TableID, TableOp);
                    return;
            }
        }

        private void Pause(enTableID TableID, Button btnPause)
        {
            if (btnPause.Text == enTableOp.Pause.ToString())
            {
                ChangeTableStatus(TableID, enTableOp.Pause);

                // add to paused tables if not already added
                if ((pausedTables & (byte)TableID) == 0)
                    pausedTables += (byte)TableID;

                // terminating pause
                btnPause.Text = enTableOp.Continue.ToString();
                btnPause.TextAlign = ContentAlignment.MiddleCenter;
            }

            else
            {
                ChangeTableStatus(TableID, enTableOp.Start);

                // remove from paused table
                if ((pausedTables & (byte)TableID) != 0)
                    pausedTables -= (byte)TableID;

                // terminating pause
                btnPause.Text = enTableOp.Pause.ToString();
                btnPause.TextAlign = ContentAlignment.MiddleCenter;
            }
            
        }
        
        private void Stop(enTableID TableID, Button btnPause, Button btnStart, Label lblThePrice)
        {
            // in case table is not started -> quit
            // in case table is in started list remove it and stop
            if ((startedTables & (byte)TableID) != (byte)TableID)
                return; 
            else
                startedTables -= (byte)TableID;

            ChangeTableStatus(TableID, enTableOp.Stop);
            SetThePrice(TableID, enTableOp.Stop);

            if ((pausedTables & (byte)TableID) == (byte)TableID)
                pausedTables -= (byte)TableID;

            // terminating start
            btnPause.Visible = false;
            btnStart.Visible = true;


            // update summary panel
            UpdateSummaryStatistics(enTableOp.Stop, lblThePrice.Text);
            UpdateSummaryPanel();

            if (MessageBox.Show("game finished\nPrice is: " + lblThePrice.Text, TableID.ToString() + ": Game Over") == DialogResult.OK)
                InitializeTable(TableID);
        }

        private void Start(enTableID TableID, Button btnPause, Button btnStart)
        {
            SetTimeIn(TableID);
            ChangeTableStatus(TableID, enTableOp.Start);
            InitializeTimeCounter(TableID);
            SetThePrice(TableID, enTableOp.Start);

            // add to started tables if not already added
            if ((startedTables & (byte)TableID) == 0)
                startedTables += (byte)TableID;

            // terminating start
            btnPause.Visible = true;
            btnStart.Visible = false;

            // update summary panel
            UpdateSummaryStatistics(enTableOp.Start);
            UpdateSummaryPanel();
        }

        private bool isValidDuration(MaskedTextBox Duration)
        {
            if (char.IsDigit(Duration.Text[0]) 
             && char.IsDigit(Duration.Text[1]) 
             && Duration.Text != "00:00")
                return true;

            return false;
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
                    //TimeSpan.TryParse(//lblTimeCounter1.Text.Insert(0, "00:"), out TimeCounter);
                    //TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    //lblTimeCounter1.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table2:
                    TimeSpan.TryParse(lblTimeCounter2.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter2.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table3:
                    TimeSpan.TryParse(lblTimeCounter3.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter3.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table4:
                    TimeSpan.TryParse(lblTimeCounter4.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter4.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table5:
                    TimeSpan.TryParse(lblTimeCounter5.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter5.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table6:
                    TimeSpan.TryParse(lblTimeCounter6.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter6.Text = formatTimeCounter(TimeCounter);
                    return;
                case enTableID.Table7:
                    TimeSpan.TryParse(lblTimeCounter7.Text.Insert(0, "00:"), out TimeCounter);
                    TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
                    lblTimeCounter7.Text = formatTimeCounter(TimeCounter);
                    return;
            }
        }

        bool isDurationFinished(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    //return //lblTimeCounter1.Text.Substring(0, 2) == //mtbDuration1.Text.Substring(0, 2);
                    //break; // break added after commenting table1 
                    // commented table1 to convert to ucTable
                case enTableID.Table2:
                    return lblTimeCounter2.Text.Substring(0, 2) == mtbDuration2.Text.Substring(0, 2);
                case enTableID.Table3:
                    return lblTimeCounter3.Text.Substring(0, 2) == mtbDuration3.Text.Substring(0, 2);
                case enTableID.Table4:
                    return lblTimeCounter4.Text.Substring(0, 2) == mtbDuration4.Text.Substring(0, 2);
                case enTableID.Table5:
                    return lblTimeCounter5.Text.Substring(0, 2) == mtbDuration5.Text.Substring(0, 2);
                case enTableID.Table6:
                    return lblTimeCounter6.Text.Substring(0, 2) == mtbDuration6.Text.Substring(0, 2);
                case enTableID.Table7:
                    return lblTimeCounter7.Text.Substring(0, 2) == mtbDuration7.Text.Substring(0, 2);
            }

            MessageBox.Show("is time duration function check glitched and didn't find table");
            return true;
        }

        private void PerformStop(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    //Stop(TableID, btnPause1, btnStart1, lblThePrice1);
                    break;
                case enTableID.Table2:
                    Stop(TableID, btnPause2, btnStart2, lblThePrice2);
                    break;
                case enTableID.Table3:
                    Stop(TableID, btnPause3, btnStart3, lblThePrice3);
                    break;
                case enTableID.Table4:
                    Stop(TableID, btnPause4, btnStart4, lblThePrice4);
                    break;
                case enTableID.Table5:
                    Stop(TableID, btnPause5, btnStart5, lblThePrice5);
                    break;
                case enTableID.Table6:
                    Stop(TableID, btnPause6, btnStart6, lblThePrice6);
                    break;
                case enTableID.Table7:
                    Stop(TableID, btnPause7, btnStart7, lblThePrice7);
                    break;
            }
        }

        void TimeUpdate_TableCheck(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    ucTable1.TableTimeUpdate();
                    return;
                case enTableID.Table2:
                    //ucTable2.TableTimeUpdate();
                    return;
                case enTableID.Table3:
                    //ucTable3.TableTimeUpdate();
                    return;
                case enTableID.Table4:
                    //ucTable4.TableTimeUpdate();
                    return;
                case enTableID.Table5:
                    //ucTable5.TableTimeUpdate();
                    return;
                case enTableID.Table6:
                    //ucTable6.TableTimeUpdate();
                    return;
                case enTableID.Table7:
                    //ucTable7.TableTimeUpdate();
                    return;
                default:
                    return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update app time
            DateTime AppTime;
            DateTime.TryParse(lblTime.Text, out AppTime);
            lblTime.Text = AppTime.AddSeconds(1).ToLongTimeString();

            if (startedTables != 0)
            {
                // ADD 1 second to Each Time Counter
                for (byte i = 1; i <= TotalTablesCount; i++)
                {
                    byte TwoPowTableID = (byte)Math.Pow(2, i);
                    TimeUpdate_TableCheck((enTableID)TwoPowTableID);
                }
            }
        }

        private bool NameAndTimeValidationsBeforeStart(TextBox tbPlayerName, MaskedTextBox mtbDuration)
        {
            if (string.IsNullOrEmpty(tbPlayerName.Text.Trim()))
            {
                MessageBox.Show("Enter Name First, Please!", "Missing Player Name");
                return false;
            }

            if (!isValidDuration(mtbDuration))
            {
                MessageBox.Show("Set Valid Duration, Please!", "Invalid revservaion Duration");
                return false;
            }

            return true;
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            //if (NameAndTimeValidationsBeforeStart(//tbPlayerName1, //mtbDuration1))
                //Start(enTableID.Table1, btnPause1, btnStart1);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName2, mtbDuration2))
                Start(enTableID.Table2, btnPause2, btnStart2);
        }

        private void btnStart3_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName3, mtbDuration3))
                Start(enTableID.Table3, btnPause3, btnStart3);
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName4, mtbDuration4))
                Start(enTableID.Table4, btnPause4, btnStart4);
        }

        private void btnStart5_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName5, mtbDuration5))
                Start(enTableID.Table5, btnPause5, btnStart5);
        }

        private void btnStart6_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName6, mtbDuration6))
                Start(enTableID.Table6, btnPause6, btnStart6);
        }

        private void btnStart7_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart(tbPlayerName7, mtbDuration7))
                Start(enTableID.Table7, btnPause7, btnStart7);
        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table1, (Button)sender);
        }

        private void btnPause2_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table2, (Button)sender);
        }

        private void btnPause3_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table3, (Button)sender);
        }

        private void btnPause4_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table4, (Button)sender);
        }

        private void btnPause5_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table5, (Button)sender);
        }

        private void btnPause6_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table6, (Button)sender);
        }

        private void btnPause7_Click(object sender, EventArgs e)
        {
            Pause(enTableID.Table7, (Button)sender);
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            //Stop(enTableID.Table1, btnPause1, btnStart1, lblThePrice1);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table2, btnPause2, btnStart2, lblThePrice2);
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table3, btnPause3, btnStart3, lblThePrice3);
        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table4, btnPause4, btnStart4, lblThePrice4);
        }

        private void btnStop5_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table5, btnPause5, btnStart5, lblThePrice5);
        }

        private void btnStop6_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table6, btnPause6, btnStart6, lblThePrice6);
        }

        private void btnStop7_Click(object sender, EventArgs e)
        {
            Stop(enTableID.Table7, btnPause7, btnStart7, lblThePrice7);
        }

        private void InitializeSummaryStatistics()
        {
            lblReservedTables.Tag = (byte)0;
            lblAvailableTables.Tag = (byte)TotalTablesCount;
            lblTotalCustomersToday.Tag = (byte)0;
            lblEarnedIncome.Tag = (decimal)0.00m;
        }

        private decimal ConvertPriceStringToDecimal(string lblPrice)
        {
            return Convert.ToDecimal(lblPrice.Substring(0, lblPrice.Length - 1));
        }

        private void UpdateSummaryStatistics(enTableOp TableOp, string lblPrice = null)
        {
            decimal PayedPrice = lblPrice == null ? 0.00M : ConvertPriceStringToDecimal(lblPrice);
 
            switch (TableOp)
            {
                case enTableOp.Start:
                    lblReservedTables.Tag = Convert.ToByte(lblReservedTables.Tag) + 1;
                    lblAvailableTables.Tag = Convert.ToByte(lblAvailableTables.Tag) - 1;
                    return;

                case enTableOp.Stop:
                    lblReservedTables.Tag = Convert.ToByte(lblReservedTables.Tag) - 1;
                    lblAvailableTables.Tag = Convert.ToByte(lblAvailableTables.Tag) + 1;
                    lblTotalCustomersToday.Tag = Convert.ToByte(lblTotalCustomersToday.Tag) + 1;
                    lblEarnedIncome.Tag = Convert.ToDecimal(lblEarnedIncome.Tag) + PayedPrice;
                    return;

                default:
                    return;
            }
        }

        private void UpdateSummaryPanel()
        {
            lblReservedTables.Text = lblReservedTables.Tag.ToString();
            lblAvailableTables.Text = lblAvailableTables.Tag.ToString();
            lblTotalCustomersToday.Text = lblTotalCustomersToday.Tag.ToString();
            lblEarnedIncome.Text = lblEarnedIncome.Tag.ToString() + "$";
        }

        private void paintTableAndItsStatus(Color color)
        {
            //lblTable1.ForeColor = color;
            lblTable2.ForeColor = color;
            lblTable3.ForeColor = color;
            lblTable4.ForeColor = color;
            lblTable5.ForeColor = color;
            lblTable6.ForeColor = color;
            lblTable7.ForeColor = color;

            //lblTableStatus1.ForeColor = color;
            lblTableStatus2.ForeColor = color;
            lblTableStatus3.ForeColor = color;
            lblTableStatus4.ForeColor = color;
            lblTableStatus5.ForeColor = color;
            lblTableStatus6.ForeColor = color;
            lblTableStatus7.ForeColor = color;
        }

        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                // general black
                this.BackColor = Color.Black;
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.BackColor = Color.Black;
                    ctrl.ForeColor = Color.Gray;
                }

                // final touches
                lblBilliardClub.ForeColor = Color.LimeGreen;
                btnQuit.ForeColor = Color.Black;
                btnQuit.BackColor = Color.Red;
                paintTableAndItsStatus(Color.Black);

            }
            else
            {
                // general black
                this.BackColor = SystemColors.Control;
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.BackColor = SystemColors.ControlLight;
                    ctrl.ForeColor = SystemColors.ControlText;
                }

                // final touches
                lblBilliardClub.ForeColor = Color.FromArgb(255, 128, 0);
                btnQuit.BackColor = Color.FromArgb(227, 0, 0);
                paintTableAndItsStatus(SystemColors.ControlText);

                // fixing some color mess :')
                lblTheme.BackColor = SystemColors.Control;
                rbDark.BackColor = SystemColors.Control;
                rbLight.BackColor = SystemColors.Control;
                lblBilliardClub.BackColor = SystemColors.Control;
                nudHourlyPrice.BackColor = SystemColors.Control;
                lblHourlyPrice.BackColor = SystemColors.Control;
            }
        }

        private void ucTable_ButtonClicked(enTableOp TableOp, string lblPrice, byte TableID)
        {
            switch (TableOp)
            {
                case enTableOp.Start:
                    if ((startedTables & (byte)TableID) == 0)
                        startedTables += (byte)TableID;
                    // update summary panel
                    UpdateSummaryStatistics(enTableOp.Start);
                    UpdateSummaryPanel();
                    return;

                case enTableOp.Stop:
                    // update summary panel
                    UpdateSummaryStatistics(enTableOp.Stop, lblPrice);
                    UpdateSummaryPanel();
                    return;

                default:
                    return;
            }
        }

        private void ucTable1_ButtonClicked(enTableOp TableOp, string lblPrice = null)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)Math.Pow(2,1)); 
        }
    }
}