using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model.Predmety
{
    internal class Jidlo : SpotrebniPredmet
    {


        public Jidlo(string NazevPredmetu, TypPredmetu Typ) : base(NazevPredmetu, Typ)
        {
        }

        public void Snist(int ZivotHrace)
        {
            ZivotHrace += 10;

        }

    }
}
