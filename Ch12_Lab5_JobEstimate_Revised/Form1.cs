using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_Lab5_JobEstimate_Revised
{
    public partial class FormJobEstimate : Form
    {
        public FormJobEstimate()
        {
            InitializeComponent();
        }

        //Global Coonstant
        const decimal TRIPFEE = 35.00M;

        //Global Variables
        decimal hoursToComplete = 0.00M;
        decimal hourlyRate = 0.00M;
        decimal totalFee = 0.00M;

        private void FormJobEstimate_Load(object sender, EventArgs e)
        {
            clearAllNecessaryFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            decimal result;

            keepGoing = validateDescription();

            if (keepGoing)
            {
                keepGoing = validateHoursToComplete(out result);
            }
            else
            {
                return;
            }

            if(keepGoing)
            {
                keepGoing = validateHourlyRate(out result);
            }
            else
            {
                return;
            }

            if(keepGoing)
            {
                calculateCurrentValue();
            }
        }

        private bool validateDescription()
        {
            if (textBoxDescription.Text.Trim() == "")
            {
                showMessageBox("Cannot Have an Empty Description!",
                                                "EMPTY DESCRIPTION");
                return false;
            }
            return true;
        }

        private bool validateHoursToComplete(out decimal result)
        {
            if (textBoxHoursToComplete.Text.Trim() == "")
            {
                showMessageBox("Cannot Have an Empty Hours To Complete!",
                                               "EMPTY HOURS TO COMPLETE");
                result = -1;
                textBoxHoursToComplete.Focus();
                return false;
            }

            bool res = Decimal.TryParse(textBoxHoursToComplete.Text, out result);

            if (!res)
            {
                showMessageBox("Cannot Have Non-Numeric Hours To Complete!",
                                                "NON-NUMERIC HOURS TO COMPLETE");
                return false;
            }

            if (result < 0)
            {
                showMessageBox("Cannot Have Negative Hours To Complete!",
                                                "NEGATIVE HOURS TO COMPLETE");
                textBoxHoursToComplete.Text = "";
                textBoxHoursToComplete.Focus();
                return false;
            }

            hoursToComplete = result;
            return true;
        }

            private bool validateHourlyRate(out decimal result)
            {
                if (textBoxHourlyRate.Text.Trim() == "")
                {
                    showMessageBox("Cannot Have An Empty Hourly Rate!",
                                                    "EMPTY HOURLY RATE");
                    result = -1;
                    textBoxHourlyRate.Focus();
                    return false;                        
                }

                bool res = Decimal.TryParse(textBoxHourlyRate.Text, out result);

                if (!res)
                {
                    showMessageBox("Cannot Have Non-Numeric Hourly Rate!",
                                                    "NON-NUMERIC HOURLY RATE");
                    textBoxHourlyRate.Text = "";
                    textBoxHourlyRate.Focus();
                    return false;
                }

                if (result<0)
                {
                    showMessageBox("Cannot Have Negative Hourly Rate!",
                                                    "NEGATIVE HOURLY RATE");
                    return false;
                }

                hourlyRate = result;
                return true;
            }

            private void calculateCurrentValue()
            {
                labelServiceRequested.Text = textBoxDescription.Text;
                labelCurrentHours.Text = hoursToComplete.ToString("f1");
                label1CurrentRate.Text = hourlyRate.ToString("c");

                totalFee = (hoursToComplete * hourlyRate) + TRIPFEE;

                labelCurrentTotalFee.Text = totalFee.ToString("c");
            }

            private void showMessageBox(string title, string text)
            {
                MessageBox.Show(title,
                                                text,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
            }       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllNecessaryFields();
        }

        private void clearAllNecessaryFields()
        {
            textBoxDescription.Text = "";
            labelServiceRequested.Text = "";
            textBoxHoursToComplete.Text = "";
            labelCurrentHours.Text = "";
            textBoxHourlyRate.Text = "";
            label1CurrentRate.Text = "";
            labelCurrentTotalFee.Text = "";
            textBoxDescription.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitProgram();
        }

        private void exitProgram()
        {
            if (MessageBox.Show("Do You Really Want To Exit The Program?",
                           "EXIT PROGRAM NOW?!?!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //  Normal program termination
                Application.Exit();
            }
        }
    }
}
