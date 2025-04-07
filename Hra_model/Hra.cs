using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private Mistnost aktualniMistnost;
        public Mistnost AktualniMistnost
        {
            get { return aktualniMistnost; }
            set { aktualniMistnost = value; OnPropertyChanged(); }
        }

        public Hra() {

            postava = new Postava();
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
            AktualniMistnost = x;
            Predmety mec = new Predmety("Nekvalitní meč", "Tento meč musel ukout učeň kováře.. je nekvalitní a nevyvážený");
            Predmety kladivo = new Predmety("Kovářovo kladivo", ".....");
            NPC kovar = new NPC("Kovář", "Starý kovář, s ostrým pohledem");
            NPC ucen = new NPC("Kovářův učeň", "Starý kovář, s ostrým pohledem");
            y.NpcMistnost.Add(kovar);
            y.NpcMistnost.Add(ucen);
            y.PredmetMistnost.Add(mec);
            y.PredmetMistnost.Add(kladivo);

        }

       
    }
}
