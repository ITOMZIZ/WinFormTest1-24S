namespace WinFormTest1
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes = new TextBox[4];
        public Form1()
        {
            InitializeComponent();

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox4;
            textBoxes[3] = textBox3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text.ToString();
            string x2 = textBox2.Text.ToString();
            string x3 = textBox3.Text.ToString();
            string x4 = textBox4.Text.ToString();
            textBox1.Text = x4;
            textBox2.Text = x1;
            textBox3.Text = x2;
            textBox4.Text = x3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x1 = textBox1.Text.ToString();
            string x2 = textBox2.Text.ToString();
            string x3 = textBox3.Text.ToString();
            string x4 = textBox4.Text.ToString();
            textBox1.Text = x2;
            textBox2.Text = x3;
            textBox3.Text = x4;
            textBox4.Text = x1;

        }
    }
}
