using System.ComponentModel;

namespace WinForms
{
    public partial class Form1 : Form
    {
        BindingList<string> movies = new BindingList<string>()
        {
            "Grown Ups", "Billy Madison", "Happy Gilmore"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lb.Items.Add("Happy Gilmore");
            lb.DataSource = movies;
        }

        private void DoIt_Click(object sender, EventArgs e)
        {
            movies.Add("Uncut Gems");
            lb.DataSource = movies;

            //Button btnGoodbye = new Button();
            //btnGoodbye.Location = new Point(80, 80);
            //btnGoodbye.Text = "Goodbye";
            //btnGoodbye.Size = new Size(100, 30);
            //btnGoodbye.Click += new System.EventHandler(this.BtnGoodbye_Click);
            //Controls.Add(btnGoodbye);

            //lblTitle.Text = "little piss boy";
            //pBar.Update();
            //this.Hide();
            //Form2 SF = new Form2();
            //SF.Show();
        }
        private void BtnGoodbye_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            btnSender.Size = new Size(btnSender.Size.Width + 1, btnSender.Size.Height + 1);
            lblTitle.Text = btnSender.Text;
        }

        private void txtStuff_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("boomer");
        }

        private void txtStuff_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cont c = new Cont();
            c.Show();
        }

        private void txtStuff_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            lblTitle.Text = lb.SelectedItem.ToString();
        }
    }
}