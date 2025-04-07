
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public class Postava
    {
        
        private List<Predmety> predmetPostavy; //lazyLoading vytvoří List okolni až když je třeba -------- Nevýhoda musí se provést podmínka

        public List<Predmety> PredmetPostavy
        {
            get
            {
                if (predmetPostavy == null) predmetPostavy = new List<Predmety>(); //když je null tak ho vytvoř a vrať
                return predmetPostavy;
            }
            set { predmetPostavy = value; }
        }

        




    }
}
