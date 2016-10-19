using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{
    class PinnedPackage : Package
    {
        internal List<ChocoPackage> pinned;
        internal List<ChocoPackage> pinnedUpdate;
    }
}
