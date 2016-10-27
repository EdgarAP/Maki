using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{ //Carlos Salgado
    class RepositoryPackage : Package
    {
        internal Collection<OneGetPackage> repository;
    }
}
