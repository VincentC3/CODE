namespace Cunanan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rbHawaiian.Enabled = true;
            rbItalian.Enabled = true;
            rbOverload.Enabled = true;
            rbSmall.Enabled = true;
            rbMedium.Enabled = true;
            rbLarge.Enabled = true;
            chbCheese.Enabled = true;
            chbBellPepper.Enabled = true;
            chbBacon.Enabled = true;
            chbPepperoni.Enabled = true;


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            rbHawaiian.Enabled = false;
            rbItalian.Enabled = false;
            rbOverload.Enabled = false;
            rbSmall.Enabled = false;
            rbMedium.Enabled = false;
            rbLarge.Enabled = false;
            chbCheese.Enabled = false;
            chbBellPepper.Enabled = false;
            chbBacon.Enabled = false;
            chbPepperoni.Enabled = false;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int Total = 0;
            if (rbHawaiian.Checked)
            {
                Total = 200;
                if (rbSmall.Checked)
                {
                    Total += 50;
                }
                else if (rbMedium.Checked)
                {
                    Total += 100;
                }
                else if (rbLarge.Checked)
                {
                    Total += 50;
                }
            }
            else if (rbItalian.Checked)
            {
                Total = 250;
                if (rbSmall.Checked)
                {
                    Total += 50;
                }
                else if (rbMedium.Checked)
                {
                    Total += 100;
                }
                else if (rbLarge.Checked)
                {
                    Total += 50;
                }
            }

            else if (rbOverload.Checked)
            {
                Total = 300;
                if (rbSmall.Checked)
                {
                    Total += 50;
                }
                else if (rbMedium.Checked)
                {
                    Total += 100;
                }
                else if (rbLarge.Checked)
                {
                    Total += 50;
                }
            }

            
            
            
            if (chbCheese.Checked)
            {
                Total += 50;
            }
            if (chbPepperoni.Checked)
            {
                Total += 50;
            }
            if (chbBacon.Checked)
            {
                Total += 75;
            }
            if (chbBellPepper.Checked)
            {
                Total += 50;
            }
            
            txtTotal.Text = Total.ToString();
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtAmoutPaid.Clear();
            txtChange.Clear();
            rbHawaiian.Enabled = false;
            rbItalian.Enabled = false;
            rbOverload.Enabled = false;
            rbSmall.Enabled = false;
            rbMedium.Enabled = false;
            rbLarge.Enabled = false;
            chbCheese.Enabled = false;
            chbBellPepper.Enabled = false;
            chbBacon.Enabled = false;
            chbPepperoni.Enabled = false;




        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int TotalAmount = int.Parse(txtTotal.Text);    
            int AmountPaid = int.Parse(txtAmoutPaid.Text);
            int Change = AmountPaid - TotalAmount;

            if (TotalAmount <= AmountPaid)
            {
                txtChange.Text = Change.ToString();
            }
            else 
            {
                txtChange.Text = "Effucient Blance";
            }
        }
    }
}
