
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra_model
{
    public class NPC
    {
        public string JmenoNPC { get; }
        public string PopisNPC { get; set; }
        //public List<Mistnost> Okolni { get; set; }
     
        public NPC(string jmenoNPC, string popisNPC)
        {
            JmenoNPC = jmenoNPC;
            PopisNPC = popisNPC;

        }


      
    }
}
