using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLocalizeExtension.Engine;

namespace ProjektWPF
{
    public static class Global
    {
        public static String Localized(string key)
        {
            object obj = LocalizeDictionary.Instance.GetLocalizedObject(key, null, LocalizeDictionary.Instance.Culture);
            if (obj != null) return obj.ToString();
            else return "???";
        }

    }
}
