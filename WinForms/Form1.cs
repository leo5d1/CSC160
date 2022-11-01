namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DoIt_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "little piss boy";
            //pBar.Update();
            //this.Hide();
            //Form2 SF = new Form2();
            //SF.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtStuff_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("boomer");
        }

        private void txtStuff_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }
    }
}