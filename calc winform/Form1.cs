using ClassLibrary1;
namespace calc_winform
{
    public partial class Form1 : Form
    {
        private string operation;
        double son1, son2;
        bool lamp;
        public Form1()
        {
            InitializeComponent();
            lamp = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (lamp)
            {
                lamp = false;
                textBox1.Text = "0";
            }
            Button btn = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = btn.Text;
            }
            else
                textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            son1 = Convert.ToDouble(textBox1.Text);
            operation = btn.Text;
            lamp = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calc ishla = new Calc();
            double result = 0;
            son2 = Convert.ToDouble(textBox1.Text);
            if (son2== 0 && (operation=="/" || operation=="%"))
            {
                MessageBox.Show("0 ga bo'lish mumkin emas");
            }
            else
            {
                result = ishla.hisobla(son1, son2, operation);

            }
            operation = "=";
            textBox1.Text = result.ToString();
            lamp = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double son;
            son = Convert.ToDouble(textBox1.Text);
            son = -son;
            textBox1.Text = son.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0,textBox1.Text.Length-1);
            if (textBox1.Text.Length==0)
            {
                textBox1.Text = "0";
            }
        }
    }
}