using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektWPF
{
    public class AkceViewModel
    {
        public string PopisAkce { get; set; }
        public ICommand AkceCommand { get; set; }
    }
}
