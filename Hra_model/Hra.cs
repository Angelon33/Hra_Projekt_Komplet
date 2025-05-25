using Hra_model.Predmety;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public class Hra: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

     

        public Postava postava;

        public Mistnost aktualniMistnost;
        public Mistnost AktualniMistnost
        {
            get { return aktualniMistnost; }
            set { aktualniMistnost = value; OnPropertyChanged(); }
        }

        private List<Mistnost> listMistnosti;

        public List<Mistnost> ListMistnosti
        {
            get { return listMistnosti; }
            set { listMistnosti = value; }
        }

        public Hra() {
          
                        postava = new Postava();
          /* 
                        Mistnost x = new Mistnost("Město", "Nacházíš se v menším městě Asgard. Vidíš že je plné lidí");
                        Mistnost y = new Mistnost("Kovárna", "Stará kovárna");
                        Mistnost z = new Mistnost("Nádvoří", "Velké nádvoří, kde se shlukuje mnoho lidí");
                        Mistnost lesA = new Mistnost("Vstup do lesa", "Stojíš u vstupu do lesa.");
                        Mistnost lesB = new Mistnost("Louka uprostřed lesa", "Vidíš před sebou louku s vysokým porostem");
                        Mistnost lesC = new Mistnost("Studánka na louce", "Zchladil ses tekoucí vodou");

                       


            
                        x.Okolni.Add(y);
                        y.Okolni.Add(x);
                        x.Okolni.Add(z);
                        z.Okolni.Add(x);
                        x.Okolni.Add(lesA);
                        lesA.Okolni.Add(x);
                        lesA.Okolni.Add(lesB);
                        lesB.Okolni.Add(lesA);
                        lesB.Okolni.Add(lesC);
                        lesC.Okolni.Add(lesB);
                    Vybaveni mec = new Vybaveni("Nekvalitní meč", "Tento meč musel ukout učeň kováře.. je nekvalitní a nevyvážený");
                    x.PredmetMistnost.Add(mec);
                    postava.PredmetPostavy.Add(mec);

            AktualniMistnost = x;
            listMistnosti = new List<Mistnost>() { x, y, z, lesA, lesB, lesC };

          
            /*
            Items mec = new Items("Nekvalitní meč", "Tento meč musel ukout učeň kováře.. je nekvalitní a nevyvážený");
            Items kladivo = new Items("Kovářovo kladivo", ".....");
            NPC kovar = new NPC("Kovář", "Starý kovář, s ostrým pohledem");
            NPC ucen = new NPC("Kovářův učeň", "Starý kovář, s ostrým pohledem");
            y.NpcMistnost.Add(kovar);
            y.NpcMistnost.Add(ucen);
            y.PredmetMistnost.Add(mec);
            y.PredmetMistnost.Add(kladivo);
            */


        }


    }
}
