namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MetricsExplorerForm mef = new MetricsExplorerForm();

            mef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StyleManagerForm smf = new StyleManagerForm();

            smf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomStyledForm csf = new CustomStyledForm();

            csf.Show();
        }
    }
}
