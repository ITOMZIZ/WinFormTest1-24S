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
            textBox3 = textBox1;
            textBox1 = textBox2;
            textBox2= textBox4;
            textBox4= textBox3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1= textBox4;
            textBox2= textBox1;
            textBox3= textBox2;

        }
    }
}
