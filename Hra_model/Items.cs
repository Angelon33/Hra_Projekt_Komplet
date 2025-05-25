
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public class Items
    {
        
        public string JmenoPredmetu { get; }
        public string PopisPredmetu { get; set; }
        //public List<Mistnost> Okolni { get; set; }
        

       
        public Items(string jmenoPredmetu, string popisPredmetu)
        {
            JmenoPredmetu = jmenoPredmetu;
            PopisPredmetu = popisPredmetu;

        }

       
        
        

    }
}
