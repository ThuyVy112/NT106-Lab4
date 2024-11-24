namespace NT106_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1Btn_Click(object sender, EventArgs e)
        {
            Bai1 form = new Bai1();
            form.Show();
        }

        private void b2Btn_Click(object sender, EventArgs e)
        {
            Bai2 form = new Bai2();
            form.Show();
        }

        private void b3Btn_Click(object sender, EventArgs e)
        {
            Bai3 form = new Bai3();
            form.Show();
        }

        private void b4Btn_Click(object sender, EventArgs e)
        {
            Bai4 form = new Bai4();
            form.Show();
        }
    }
}
