using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public abstract class Predmet
    {
        public enum TypPredmetu
        {
            Spotrebni,
            Vybaveni,
            
        }
        private int predmetMnozstvi;

        public int PredmetMnozstvi
        {
            get { return predmetMnozstvi; }
            set { predmetMnozstvi = value; }
        }

        public TypPredmetu Typ { get; set; }


        public string NazevPredmetu { get; set; }

            
    }
}
