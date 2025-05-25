using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model.Predmety
{
    internal class Jidlo : SpotrebniPredmet
    {


        public Jidlo(string NazevPredmetu, string PopisPredmetu) : base(NazevPredmetu, PopisPredmetu)
        {
        }

        public void Snist(int ZivotHrace)
        {
            ZivotHrace += 10;

        }

    }
}
