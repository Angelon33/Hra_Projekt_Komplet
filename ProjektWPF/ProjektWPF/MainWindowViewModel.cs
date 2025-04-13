using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Hra_model;

namespace ProjektWPF
{
   
    public class MainWindowViewModel : INotifyPropertyChanged
    {
       

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        private Hra hra;

        public Hra Hra
        {
            get { return hra; }
            set { hra = value; OnPropertyChanged(); }
        }


        //Hra Hra { get; set;  }

        public MainWindowViewModel()
        {
            Hra = new Hra();
            
             




        }
       
    }
}
