
using Hra_model;
using ProjektWPF.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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
using WPFLocalizeExtension.Engine;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //partial část třídy psaná tady, část je v grafické části

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowViewModel viewModel;

        public MainWindow()
        {

            // Localization settings
            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
            LocalizeDictionary.Instance.IncludeInvariantCulture = false;
            // Load language settings
            if (!String.IsNullOrEmpty(Settings.Default.Lang)) LocalizeDictionary.Instance.Culture = new CultureInfo(Settings.Default.Lang);

            InitializeComponent();

            viewModel = new MainWindowViewModel();
            DataContext = viewModel;




        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            viewModel.Hra.AktualniMistnost = viewModel.Hra.AktualniMistnost.Okolni.First();
            viewModel.LoadCollectionData();
        }



        private void OkolniMistnosti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListView listView = (ListView)sender;
            if (listView.SelectedItem == null)
                return;
            viewModel.Hra.AktualniMistnost = (Mistnost)listView.SelectedItem;
            viewModel.LoadCollectionData();
        }


       

            
private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Lang = "en-US";
   
            Properties.Settings.Default.Save();
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Settings.Default.Lang = "cs-CZ";
            
            Properties.Settings.Default.Save();
            
        }
    }


    
}
