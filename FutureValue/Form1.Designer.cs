namespace FutureValue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMonthlyInvestment = new TextBox();
            txtInterestRate = new TextBox();
            txtYears = new TextBox();
            txtFutureValue = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Monthly Investment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Yearly Interest Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 103);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Number of Years:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 134);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Future Value:";
            // 
            // txtMonthlyInvestment
            // 
            txtMonthlyInvestment.Location = new Point(170, 30);
            txtMonthlyInvestment.Margin = new Padding(3, 2, 3, 2);
            txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            txtMonthlyInvestment.Size = new Size(110, 23);
            txtMonthlyInvestment.TabIndex = 1;
            txtMonthlyInvestment.TextChanged += ClearFutureValue;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(170, 59);
            txtInterestRate.Margin = new Padding(3, 2, 3, 2);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(110, 23);
            txtInterestRate.TabIndex = 2;
            // 
            // txtYears
            // 
            txtYears.Location = new Point(170, 98);
            txtYears.Margin = new Padding(3, 2, 3, 2);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(110, 23);
            txtYears.TabIndex = 3;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(170, 129);
            txtFutureValue.Margin = new Padding(3, 2, 3, 2);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.ReadOnly = true;
            txtFutureValue.Size = new Size(110, 23);
            txtFutureValue.TabIndex = 7;
            txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(57, 205);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(82, 22);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            btnCalculate.MouseLeave += ReturnColor;
            btnCalculate.MouseHover += Calculate_ChangeColor;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(159, 205);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += ReturnColor;
            btnExit.MouseHover += Exit_ChangeColor;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtFutureValue);
            Controls.Add(txtYears);
            Controls.Add(txtInterestRate);
            Controls.Add(txtMonthlyInvestment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            DoubleClick += ClearFutureValue;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMonthlyInvestment;
        private TextBox txtInterestRate;
        private TextBox txtYears;
        private TextBox txtFutureValue;
        private Button btnCalculate;
        private Button btnExit;
    }
}
