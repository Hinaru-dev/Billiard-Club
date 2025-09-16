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

            // Initialize Summary Panel
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            InitializeSummaryStatistics();
            UpdateSummaryPanel();
        }

        public decimal getNudHourlyPrice()
        {
            return nudHourlyPrice.Value;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        void TimeUpdate_TableCheck(enTableID TableID)
        {
            switch (TableID)
            {
                case enTableID.Table1:
                    ucTable1.TableTimeUpdate();
                    return;
                case enTableID.Table2:
                    ucTable2.TableTimeUpdate();
                    return;
                case enTableID.Table3:
                    ucTable3.TableTimeUpdate();
                    return;
                case enTableID.Table4:
                    ucTable4.TableTimeUpdate();
                    return;
                case enTableID.Table5:
                    ucTable5.TableTimeUpdate();
                    return;
                case enTableID.Table6:
                    ucTable6.TableTimeUpdate();
                    return;
                case enTableID.Table7:
                    ucTable7.TableTimeUpdate();
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
            foreach (ucTable uct in this.Controls.OfType<ucTable>())
                uct.paintTableAndItsStatus(color);
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
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table1); 
        }

        private void ucTable2_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table2);
        }

        private void ucTable3_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table3);
        }

        private void ucTable4_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table4);
        }

        private void ucTable5_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table5);
        }

        private void ucTable6_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table6);
        }

        private void ucTable7_ButtonClicked(enTableOp TableOp, string lblPrice)
        {
            ucTable_ButtonClicked(TableOp, lblPrice, (byte)enTableID.Table7);
        }
    }
}