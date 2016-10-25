using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{
    class InstalledPackage : Package
    { //Carlos Salgado
        internal List<ChocoPackage> installed;
        internal List<ChocoPackage> outdated;
    }
}
