using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.Business
{
    class RepositoryPackage : Package
    {
        internal List<OneGetPackage> repository;
        internal List<OneGetPackage> repositoryUpdate;
    }
}
