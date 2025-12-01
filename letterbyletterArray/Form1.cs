namespace letterbyletterArray
{
    public partial class Form1 : Form
    {
        string[] item = { "b", "e", "h", "s","a" };
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (index < item.Length)
            {
                label1.Text = item[index];
                index++;
            }

        }
    }
}
