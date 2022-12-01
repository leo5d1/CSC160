using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            txtReturn.Text = "";

            ht.Clear();

            ht.Add("@Username", txtUsername.Text);
            ht.Add("@Password", txtPassword.Text);

            sql = "Select Name from Users where Username=@Username and Password=@Password";

            dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

            if (dt.Rows.Count > 0) 
            {
                txtReturn.Text = "Login Successful";
            }
            else
            {
                txtReturn.Text = "Login Failed";
            }

            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();

            sql = "Insert into Users (Name, Username, Password, Email) Values (@Name, @Username, @Password, @Email)";
            ht.Add("@Name", txtRName.Text);
            ht.Add("@Username", txtRUsername.Text);
            ht.Add("@Password", txtRPassword.Text);
            ht.Add("@Email", txtREmail.Text);

            lngReturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);

            txtRName.Text = "";
            txtRUsername.Text = "";
            txtRPassword.Text = "";
            txtREmail.Text = "";
        }
    }
}
