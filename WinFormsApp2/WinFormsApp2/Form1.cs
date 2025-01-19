
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double first;
        string arit;


        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            n1.Click += sum;
            n2.Click += sum;
            n3.Click += sum;
            n4.Click += sum;
            n5.Click += sum;
            n6.Click += sum;
            n7.Click += sum;
            n8.Click += sum;
            n9.Click += sum;
            n0.Click += sum;
            toch.Click += sum;
        }
        public void sum(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = button.Text;
                }
                else
                {
                    textBox1.Text += button.Text;
                }
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void n1_Click(object sender, EventArgs e)
        {

        }
        private void n2_Click(object sender, EventArgs e)
        {

        }
        private void n3_Click(object sender, EventArgs e)
        {

        }



        private void n4_Click(object sender, EventArgs e)
        {

        }

        private void n5_Click(object sender, EventArgs e)
        {

        }



        private void n6_Click(object sender, EventArgs e)
        {

        }

        private void n7_Click(object sender, EventArgs e)
        {

        }
        private void n8_Click(object sender, EventArgs e)
        {

        }
        private void n9_Click(object sender, EventArgs e)
        {

        }
        private void n0_Click(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {

            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arit = "/";


        }

        private void pu_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arit = "+";
        }
        private void minu_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arit = "-";
        }
        private void zvez_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arit = "*";
        }
        private void ravn_Click(object sender, EventArgs e)
        {
            double sekond = Convert.ToDouble(textBox1.Text);
            double resolt;
            if (arit == "*")
            {
                resolt = first * sekond;
                textBox1.Text = Convert.ToString(resolt);
                first = resolt;

            }
            else if (arit == "/")
            {
                resolt = first / sekond;
                textBox1.Text = Convert.ToString(resolt);
                first = resolt;
            }
            else if (arit == "-")
            {
                resolt = first - sekond;
                textBox1.Text = Convert.ToString(resolt);
                first = resolt;
            }
            else if (arit == "+")
            {
                resolt = first + sekond;
                textBox1.Text = Convert.ToString(resolt);
                first = resolt;
            }


        }
        private void toch_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}