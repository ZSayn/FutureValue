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
            decimal monthlyInvestment = 0;
            decimal yearlyInterestRate = 0;
            int years = 0;
            try
            {
                monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                yearlyInterestRate = 0; Convert.ToDecimal(txtInterestRate.Text);
                years = Convert.ToInt32(txtYears.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{label1.Text} is incorrect. {ex.Message} Enter number");
            }
            int months = years * 12;

            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = CalculateFutureValue(0, monthlyInvestment, monthlyInterestRate, months);

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private decimal CalculateFutureValue(decimal futureValue, decimal monthlyInvestment, decimal monthlyInterestRate, int month)
        {
            for (int i = 0; i < month; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtInterestRate.Text = "";
            txtYears.Text = "";
        }

        private void Calculate_ChangeColor(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Pink;
            btnCalculate.ForeColor = Color.White;
        }

        private void Return_Color(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
            btnCalculate.ForeColor = Color.Black;
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Black;
        }

        private void Exit_ChangeColor(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
        }
    }
}
