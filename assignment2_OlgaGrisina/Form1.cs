namespace assignment2_OlgaGrisina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}