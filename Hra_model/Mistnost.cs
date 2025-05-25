
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Hra_model
{
    

    public class Mistnost : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Jmeno { get; set; }
        public string Popis {  get; set;  }
        //public List<Mistnost> Okolni { get; set; }


        

        private List<Mistnost> okolni; //lazyLoading vytvoří List okolni až když je třeba -------- Nevýhoda musí se provést podmínka

        public List<Mistnost> Okolni
        {
            get {
                if (okolni == null) okolni = new List<Mistnost>(); //když je null tak ho vytvoř a vrať
                return okolni; }
            set { okolni = value; OnPropertyChanged(); }

        }


        







        public List<Items> predmetMistnost; 

        public List<Items> PredmetMistnost
        {
            get
            {
                if (predmetMistnost == null) predmetMistnost = new List<Items>(); //když je null tak ho vytvoř a vrať
                return predmetMistnost;
            }
            set { predmetMistnost = value; }
        }

        public List<NPC> npcMistnost; 

        public List<NPC> NpcMistnost
        {
            get
            {
                if (npcMistnost == null) npcMistnost = new List<NPC>(); //když je null tak ho vytvoř a vrať
                return npcMistnost;
            }
            set { npcMistnost = value; }
        }








        /*
        public int MyProperty { get; set; } //prop a tab --> když chci přistupovat k get a set
        private int myVar; //propfull a tab --> použiju v případě když chci upravit get a set

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

        public Mistnost(string jmeno, string popis)
        {
            Jmeno = jmeno;
            Popis = popis;
            

        }
        

       
      

       

        

        

        /*
        public void SetPopis(string novyPopis)
        {

            this.popis = novyPopis;

        }

        public void GetPopis()
        {
            return popis;

        }

        */

    }
}
