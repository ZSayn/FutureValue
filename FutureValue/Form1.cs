namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                    int months = years * 12;
                    decimal futureValue = CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + 
                    ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate Monthly Investment text box
            errorMessage += IsDecimal(txtMonthlyInvestment.Text, "MonthlyInvestment");
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, "Monthly Investment", 1, 1000);

            //Validate Yearly Interest Rate text box
            errorMessage += IsDecimal(txtInterestRate.Text, "Yearly Interest Rate");
            errorMessage += IsWithinRange(txtInterestRate.Text, "Yearly Interest Rate", 1, 20);

            //Validate Number of Years text box
            errorMessage += IsInt32(txtYears.Text, "Number of Years");
            errorMessage += IsWithinRange(txtYears.Text, "Number of Years", 1, 40);

            if(errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");

            }
            return success;

        }

        private string IsInt32(string value, string name)
        {
            string msg = "";
            if(!Int32.TryParse(value, out int result))
            {
                msg = name + "Must be a valid integer value .\n";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if(number < min || number > max)
                {
                    msg = name + "must be between" + min + "and" + max + ".\n";
                }
            }
            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if(!Decimal.TryParse(value, out decimal result))
            {
                msg = name + "must be a valid decimal value.\n";
            }
            return msg;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleareFututreValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtInterestRate.Text = "";
            txtYears.Text = "";
        }

        private void Calculate_ChangeColor(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.LightBlue;
            btnCalculate.ForeColor = Color.Violet;
        }

        private void Return_Color(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
            btnCalculate.ForeColor = Color.Black;
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Black;
        }

        private void Exit_ChnageColor(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.LightCoral;
            btnExit.ForeColor = Color.White;
        }
    }
}
