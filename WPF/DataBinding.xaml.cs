using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Student> lstStudents = new ObservableCollection<Student>();

        public DataBinding()
        {
            InitializeComponent();
            DataContext = this;

            //manually bind in C#
            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            txtData.SetBinding(TextBlock.TextProperty, binding);

            lstStudents.Add(new Student() { Id = 1, Name = "Rob1" });
            lstStudents.Add(new Student() { Id = 2, Name = "Bob1" });
            lstStudents.Add(new Student() { Id = 3, Name = "Cob1" });
            lbStudents.ItemsSource = lstStudents;
        }

        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            //manually trigger the binding update
            BindingExpression be = txtTitle.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           int newId = lstStudents[lstStudents.Count- 1].Id + 1;
           lstStudents.Add(new Student() { Id = newId, Name = "Hob" + newId });
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbStudents.SelectedItem != null)
                lstStudents.Remove((Student)lbStudents.SelectedItem);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (lbStudents.SelectedItem != null)
            {
                ((Student)lbStudents.SelectedItem).Name = "Lob";
                lbStudents.Items.Refresh();
                //modifying the listbox itself is different than auto binding
            }
        }

        class Student
        {
            public int Id { get; set; }
            public string name = "";

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
