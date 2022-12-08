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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();

            sql = "Insert into Watchlist (Name, Type, Length, AmountWatched) Values (@Name, @Type, @Length, @AmountWatched)";
            ht.Add("@Name", txtName.Text);
            ht.Add("@Type", txtType.Text);
            ht.Add("@Length", txtLength.Text);
            ht.Add("@AmountWatched", txtAmountWatched.Text);

            lngReturn = ExDB.ExecuteIt("CSC160", sql, ht);

            SearchButton_Click(sender, e );

            txtName.Text = "";
            txtType.Text = "";
            txtLength.Text = "";
            txtAmountWatched.Text = "";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;

            ht.Clear();

            if (txtSName.Text != "" || txtSType.Text != "")
            {
                ht.Clear();

                ht.Add("@Name", txtSName.Text);
                ht.Add("@Type", txtSType.Text);

                sql = "Select * from Watchlist where Name=@Name or Type=@Type";

                dt = ExDB.GetDataTable("CSC160", ht, sql);
            }
            else
            {
                ht.Clear();

                sql = "Select * from Watchlist";

                dt = ExDB.GetDataTable("CSC160", ht, sql);
            }

            dg.ItemsSource = dt.DefaultView;

            txtSName.Text = "";
            txtSType.Text = "";
            txtSLength.Text = "";
            txtSAmountWatched.Text = "";
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;

            ht.Clear();

            ht.Clear();

            ht.Add("@Name", txtSName.Text);
            ht.Add("@Type", txtSType.Text);
            ht.Add("@Length", txtSLength.Text);
            ht.Add("@AmountWatched", txtSAmountWatched.Text);

            if(txtSLength.Text != "" && txtSAmountWatched.Text != "")
            {
                sql = "Update Watchlist set Length=@Length, AmountWatched=@AmountWatched where Name=@Name or Type=@Type";

                dt = ExDB.GetDataTable("CSC160", ht, sql);
            }
            else if (txtSLength.Text != "")
            {
                sql = "Update Watchlist set Length=@Length where Name=@Name or Type=@Type";

                dt = ExDB.GetDataTable("CSC160", ht, sql);
            }
            else if (txtSAmountWatched.Text != "")
            {
                sql = "Update Watchlist set AmountWatched=@AmountWatched where Name=@Name or Type=@Type";

                dt = ExDB.GetDataTable("CSC160", ht, sql);
            }
            else
            {
                SearchButton_Click(sender, e);
            }

            txtSName.Text = "";
            txtSType.Text = "";
            txtSLength.Text = "";
            txtSAmountWatched.Text = "";

            SearchButton_Click(sender, e);
        }
    }
}
