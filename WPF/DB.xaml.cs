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
    /// Interaction logic for DB.xaml
    /// </summary>
    public partial class DB : Window
    {
        public DB()
        {
            InitializeComponent();
        }

        private void btnDoIt_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long lngReturn;

            ht.Clear();

            sql = "Insert into Names (Name, Title) Values (@Name, @Title)";
            ht.Add("@Name", "Ray Maple");
            ht.Add("@Title", "Syrup Master");
            ht.Add("@ID", 3);
            //lngReturn = ExDB.ExecuteIt("CSC160", sql, ht);

            sql = "Update Names set Name=@Name, Title=@Title where ID=@ID";

            //sql = "Delete from names where ID=@ID";

            lngReturn = ExDB.ExecuteIt("CSC160", sql, ht);

            ht.Clear();
            ht.Add("@ID", 3);
            //sql = "Select ID, Name from Names where ID=@ID";// and username=@Username";
            sql = "Select ID, Name, Title from Names";
            dt = ExDB.GetDataTable("CSC160", ht, sql);

            //DataRow dr;
            //if (dt.Rows.Count > 0 ) 
            //{
            //    dr = dt.Rows[0];
            //    int intID;
            //    intID = (int)dr["ID"];
            //    lblMsg.Content = intID;
            //}

            dg.ItemsSource = dt.DefaultView;



        }
    }
}
