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
            //validate the data to handle the exception that gets thrown
            decimal monthlyInvestment = 0;
            try
            {

                monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{label1.Text} is incorrect. {ex.Message}. Enter number");
            }

            decimal yearlyInterestRate = 0;
            //validate the data to handle the exception that gets thrown
            try
            {
                yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{label2.Text} is incorrect. {ex.Message}. Enter number");
            }

            int years = 0;
            //validate the data to handle the exception that gets thrown
            try
            {
                years = Convert.ToInt32(txtYears.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{label3.Text} is incorrect. {ex.Message}. Enter number");
            }

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
