
using Hra_model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //partial část třídy psaná tady, část je v grafické části

        MainWindowViewModel viewModel;
       
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();
            DataContext = viewModel;
            viewModel.Hra.AktualniMistnost.OkolniMistnost = new ObservableCollection<Mistnost>(viewModel.Hra.AktualniMistnost.Okolni);



        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            viewModel.Hra.AktualniMistnost = viewModel.Hra.AktualniMistnost.Okolni.First();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListView listView = (ListView)sender;
            //listView.SelectedItem = //aktualni mistnost změnit 
        }
    }
}
