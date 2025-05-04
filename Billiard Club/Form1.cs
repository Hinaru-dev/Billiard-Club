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
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeTableStatus(byte tableID)
        {
            switch (tableID)
            {
                case 1:
                    lblTableStatus1.Text = "Playing";
                    lblTableStatus1.TextAlign = ContentAlignment.MiddleCenter;
                    lblTableStatus1.BackColor = Color.Yellow;
                    break;
            }
        }

        private void SetTimeIn(byte TableID)
        {
            // testing for now i'll refactor later
            lblTimeIn1.Text = DateTime.Now.ToShortTimeString();
        }

        private void InitializeTimeCounter(byte TableID)
        {
            // testing for now i'll refactor later
            lblTimeCounter1.Text = "00:00";
        }

        private string CalculatePrice(byte TableID)
        {
            decimal price = decimal.Round((nudHourlyPrice.Value / 60 * Convert.ToInt32(mtbDuration.Text.Substring(0, 2))), 2);

            return price.ToString() + "$";
        }

        private void SetThePrice(byte TableID)
        {
            // testing for now i'll refactor later
            lblThePrice1.Text = CalculatePrice(TableID);
        }

        private void Start(byte TableID)
        {
            SetTimeIn(TableID);
            ChangeTableStatus(TableID);
            InitializeTimeCounter(TableID);
            SetThePrice(TableID);

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPlayerName.Text.Trim()))
            {
                MessageBox.Show("Enter Name First, Please!", "Missing Player Name");
                return;
            }
            
            if (!isValidDuration(mtbDuration))
            {
                MessageBox.Show("Set Valid Duration, Please!", "Invalid revservaion Duration");
                return;
            }

            Start((byte)1);
        }
    }
}