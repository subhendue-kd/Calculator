namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        double number1;
        double number2;
        string Arth_operatoion;
        double result;

        private void bnt1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Arth_operatoion = "+";

            number1 = double.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Arth_operatoion = "-";

            number1 = double.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            Arth_operatoion = "*";

            number1 = double.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Arth_operatoion = "/";

            number1 = double.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtTotal.Text);

            if (Arth_operatoion == "+")
                result = number1 + number2;

            else if (Arth_operatoion == "-")
                result = number1 - number2;

            else if (Arth_operatoion == "*")
                result = number1 * number2;

            else if (Arth_operatoion == "/")
            {
                if (number2 != 0)
                    result = number1 / number2;
                else
                    MessageBox.Show("Error:Division By Zero Undefined");


            }


            txtTotal.Text = result.ToString() + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
        }
    }
}
