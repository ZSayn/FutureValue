using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal monthlyInvestment = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {

                monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{label1.Text} is not incorret. {ex.Message }\n Enter number" + ex.Message);
            }

            decimal yearlyInterestRate = 0;
            try
            {
                yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{label2.Text} is not incorret. {ex.Message}\n Enter number" + ex.Message);

            }


            int years = 0;

            try
            {
                years = Convert.ToInt32(txtYears.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{label3.Text} is not incorret. {ex.Message}\n Enter number" + ex.Message);
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
