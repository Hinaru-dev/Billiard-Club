using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_Club
{
    public partial class ucTable : UserControl
    {
        private Form1 _parentForm;
        private byte _tableID;
        public enum enTableOp { Start = 0, Pause = 1, Continue = 2, Stop = 3 };

        private void InitializeTable()
        {
            tbPlayerName.Clear();
            lblTimeIn.Text = string.Empty;
            mtbDuration.Clear();
            lblTimeCounter.Text = "00:00";
            lblThePrice.Text = "0$";
        }

        public event Action<Form1.enTableOp, string> ButtonClicked;

        void RaiseButtonClick(Form1.enTableOp TableOp, string lblPrice = null)
        {
            Action<Form1.enTableOp, string> MYButtonClicked = ButtonClicked;

            if (MYButtonClicked != null)
                MYButtonClicked.Invoke(TableOp, lblPrice);
        }

        private bool isValidDuration()
        {
            if (char.IsDigit(mtbDuration.Text[0])
             && char.IsDigit(mtbDuration.Text[1])
             && mtbDuration.Text != "00:00")
                return true;

            return false;
        }

        private bool NameAndTimeValidationsBeforeStart()
        {
            if (string.IsNullOrEmpty(tbPlayerName.Text.Trim()))
            {
                MessageBox.Show("Enter Name First, Please!", "Missing Player Name");
                return false;
            }

            if (!isValidDuration())
            {
                MessageBox.Show("Set Valid Duration, Please!", "Invalid revservaion Duration");
                return false;
            }

            return true;
        }

        private void SetTimeIn()
        {
            lblTimeIn.Text = DateTime.Now.ToShortTimeString();
        }

        public void TableTimeUpdate()
        {
            // table should be in started list but not in paused list
            if ((_parentForm.startedTables & _tableID) == _tableID && (_tableID & _parentForm.pausedTables) != _tableID)
            {
                if (isDurationFinished())
                {
                    Stop();
                    return;
                }

                UpdateTableTimeCounter();
            }
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

        private void UpdateTableTimeCounter()
        {
            TimeSpan TimeCounter;

            // add hours to the time string format
            // to make it work properly
            TimeSpan.TryParse(lblTimeCounter.Text.Insert(0, "00:"), out TimeCounter);
            TimeCounter = TimeCounter + new TimeSpan(0, 0, 1);
            lblTimeCounter.Text = formatTimeCounter(TimeCounter);
        }

        private void affectTableStatusChange(string status, Color colorValue)
        {
            lblTableStatus.Text = status;
            lblTableStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblTableStatus.BackColor = colorValue;
        }

        private void ChangeTableStatus(enTableOp TableOp)
        {
            string Status = TableOp == enTableOp.Stop ? "Free" : TableOp == enTableOp.Pause ? "Paused!" : "Playing";

            Color Value = TableOp == enTableOp.Stop ? Color.Lime : TableOp == enTableOp.Pause ? Color.Orange : Color.Yellow;

            affectTableStatusChange(Status, Value);    
        }

        private void InitializeTimeCounter()
        {
            lblTimeCounter.Text = "00:00";
        }

        bool isDurationFinished()
        {
           return lblTimeCounter.Text.Substring(0, 2) == mtbDuration.Text.Substring(0, 2);
        }

        private string CalculatePrice(enTableOp TableOp)
        {
            decimal price = 0;

            if (_parentForm != null)
            {
                if (isDurationFinished() || TableOp == enTableOp.Start)

                    price = decimal.Round((_parentForm.getNudHourlyPrice() / 60 * Convert.ToInt32(mtbDuration.Text.Substring(0, 2))), 2);

                else
                    price = decimal.Round((_parentForm.getNudHourlyPrice() / 60 * Convert.ToInt32(lblTimeCounter.Text.Substring(0, 2))), 2);
            }

            return price.ToString() + "$";
        }
        
        private void SetThePrice(enTableOp TableOp)
        {
            lblThePrice.Text = CalculatePrice(TableOp);
        }

        // ---------------
        //
        //      Start
        //
        // ---------------

        private void Start()
        {
            SetTimeIn();
            ChangeTableStatus(enTableOp.Start);
            InitializeTimeCounter();
            SetThePrice(enTableOp.Start);

            // add table to started tables
            if ((_parentForm.startedTables & _tableID) != _tableID)
                _parentForm.startedTables += _tableID;

            // terminating start
            btnPause.Visible = true;
            btnStart.Visible = false;

            if (ButtonClicked != null)
                RaiseButtonClick(Form1.enTableOp.Start);
        }

        // ---------------
        //
        //      Stop
        //
        // ---------------

        private void Stop()
        {
            // in case table is not started -> quit
            // in case table is in started list remove it and stop
            if ((_parentForm.startedTables & (byte)_tableID) != (byte)_tableID)
                return;
            else
                _parentForm.startedTables -= (byte)_tableID;

            ChangeTableStatus(enTableOp.Stop);
            SetThePrice(enTableOp.Stop);

            // remove table from paused list if there
            if ((_parentForm.pausedTables & (byte)_tableID) == (byte)_tableID)
                _parentForm.pausedTables -= (byte)_tableID;

            // terminating start
            btnPause.Visible = false;
            btnStart.Visible = true;

            // raise button clicked event to update summary
            if (ButtonClicked != null)
                RaiseButtonClick(Form1.enTableOp.Stop, lblThePrice.Text);


            string TableName = "Table " + Math.Log(_tableID, 2).ToString();
            if (MessageBox.Show("game finished\nPrice is: " + lblThePrice.Text, TableName + ": Game Over") == DialogResult.OK)
                InitializeTable();
        }

        // ---------------
        //
        //      Pause
        //
        // ---------------

        private void Pause()
        {
            if (btnPause.Text == enTableOp.Pause.ToString())
            {
                ChangeTableStatus(enTableOp.Pause);

                // add to paused tables if not already added
                if ((_parentForm.pausedTables & _tableID) == 0)
                    _parentForm.pausedTables += _tableID;

                // terminating pause
                btnPause.Text = enTableOp.Continue.ToString();
                btnPause.TextAlign = ContentAlignment.MiddleCenter;
            }

            else
            {
                ChangeTableStatus(enTableOp.Start);

                // remove from paused table
                if ((_parentForm.pausedTables & _tableID) != 0)
                    _parentForm.pausedTables -= _tableID;

                // terminating pause
                btnPause.Text = enTableOp.Pause.ToString();
                btnPause.TextAlign = ContentAlignment.MiddleCenter;
            }

        }


        // ---------------
        //
        //  Constructors
        //
        // ---------------

        public ucTable()
        {
            InitializeComponent();
        }

        public ucTable(Form1 ParentForm, byte tableID)
        {
            InitializeComponent();
            _parentForm = ParentForm;
            _tableID = tableID;

            double TableNumber = Math.Log(tableID, 2);
            lblTable.Text = "Table " + TableNumber.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (NameAndTimeValidationsBeforeStart())
                Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }
    }
}
