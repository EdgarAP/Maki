using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{
    class InstalledPackage : Package
    {
        internal List<ChocoPackage> installed;
        internal List<ChocoPackage> installedUpdate;

    }
}
