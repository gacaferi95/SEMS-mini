using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Projekti_KNK
{
    static class Parametra
    {
        public static string _KonektimiDB = ConfigurationManager.ConnectionStrings["Regjistrimi_Studenteve"].ToString();
        public static string Perdoruesi = "";
    }
}
