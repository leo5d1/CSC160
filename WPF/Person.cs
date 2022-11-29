using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    internal class Person : INotifyPropertyChanged
    {
        private string ln;

        public List<string> lastNames = new List<string>
        {
            "Comire",
            "Shultz",
            "Smith",
            "Rodgers",
            "Kim",
            "Anderson"
        };

        public void Randomize()
        {
            Random r = new Random();
            this.Last = lastNames.ElementAt(r.Next(lastNames.Count));
        }

        public Person()
        { 
        }

        public Person(string ln)
        { this.ln = ln; }

        public string Last {
            get { return ln; }
            
            set {
                ln = value;
                PropertyHasChanged("Last");
                //"Last" = name of property
            }
        
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void PropertyHasChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        
    }
}
