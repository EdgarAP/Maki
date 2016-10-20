using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.PS
{  //Carlos Salgado
    internal static class StaticInfo
    {
        internal static string makiFolderPath = "C:\\MakiTemporal\\";
        internal static string installedPkgPath= makiFolderPath + "Installed.csv";
        internal static string repositoryPkgPath = makiFolderPath + "Installed.csv";
    }
}
