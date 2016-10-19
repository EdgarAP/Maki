using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{
    internal abstract class Package
    {
        internal struct OneGetPackage
        {
            string status;
            string searchKey;
            string summary;
            string name;
            string version;
        }

        internal struct ChocoPackage 
        {
            string name;
            string version;
        }
        
        private void update() {}
    }
}
