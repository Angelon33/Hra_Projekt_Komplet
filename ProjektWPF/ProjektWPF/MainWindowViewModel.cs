using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml;
using Hra_model;
using Newtonsoft.Json;

namespace ProjektWPF
{
   
    public class MainWindowViewModel : INotifyPropertyChanged
    {

       
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Mistnost> okolniMistnost;

        public ObservableCollection<Mistnost> OkolniMistnost
        {
            get { return okolniMistnost; }
            set { okolniMistnost = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Predmet> inventar;

        public ObservableCollection<Predmet> Inventar
        {
            get { return inventar; }
            set { inventar = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Predmet> predmetMistnosti;

        public ObservableCollection<Predmet> PredmetMistnosti
        {
            get { return predmetMistnosti; }
            set { predmetMistnosti = value; OnPropertyChanged(); }
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
            string filecontent = File.ReadAllText(Directory.GetCurrentDirectory() + "\\mistnosti.txt");
            JsonSerializer deserializer = new JsonSerializer();
            deserializer.Formatting = Newtonsoft.Json.Formatting.Indented;
            deserializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            //List<Mistnost> x = JsonConvert.DeserializeObject<List<Mistnost>>(filecontent, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            deserializer.ReferenceLoopHandling = ReferenceLoopHandling.Serialize;
            var x = deserializer.Deserialize<List<Mistnost>>(new JsonTextReader(new StringReader(filecontent)));
            hra.AktualniMistnost = x[0];
            LoadCollectionData();




        }

        public void LoadCollectionData()
        {
            //
            
            OkolniMistnost = new ObservableCollection<Mistnost>(Hra.AktualniMistnost.Okolni);
            Inventar = new ObservableCollection<Predmet>(Hra.postava.PredmetPostavy);
            PredmetMistnosti = new ObservableCollection<Predmet>(Hra.AktualniMistnost.PredmetMistnost);

        }

    }
}
