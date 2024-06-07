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
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            //validate the data to handle the exception that gets thrown

            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            //validate the data to handle the exception that gets thrown

            int years = Convert.ToInt32(txtYears.Text);
            //validate the data to handle the exception that gets thrown

            int months = years * 12;

            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }
       
        //private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate = 0.05m, int months = 12) 
        //{
        //    decimal futureValue = 0m;

        //    for (int i = 0; i < months; i++)
        //    {
        //        futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
        //    }

        //    return futureValue;
        //}


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
