using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public abstract class Predmet
    {
        private int predmetMnozstvi;

        public int PredmetMnozstvi
        {
            get { return predmetMnozstvi; }
            set { predmetMnozstvi = value; }
        }

        public string NazevPredmetu { get; set; }
        public string PopisPredmetu { get; set; }

        public Predmet (string nazevPredmetu, string popisPredmetu)
        {
            this.NazevPredmetu = nazevPredmetu;
            this.PopisPredmetu = popisPredmetu;
        }
       








    }




    }
