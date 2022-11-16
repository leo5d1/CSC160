using System;
using System.Collections.Generic;
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
    /// Interaction logic for DataBinding.xaml
    /// </summary>
    public partial class DataBinding : Window
    {
        public DataBinding()
        {
            InitializeComponent();
            DataContext = this;
        }
private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = txtTitle.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }
    }
}
