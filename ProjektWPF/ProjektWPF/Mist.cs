using System.Collections.ObjectModel;

namespace ProjektWPF
{
    public class Mist
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public ObservableCollection<AkceViewModel> Akce { get; set; } = new ObservableCollection<AkceViewModel>();
    }
}
