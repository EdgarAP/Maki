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
        bool isWriting;

        internal void updateRemote()
        {
            PSmanager man = new PSmanager();
            Collection<PSObject> bruto = man.getPackageListRemote();
            isWriting = true;
            repository = convertPSOtoOGP(bruto);
            isWriting = false;
        }
        private void updateLocal()
        {
            PSmanager man = new PSmanager();
            Collection<PSObject> bruto = man.getPackageListLocal();
            isWriting = true;
            repository = convertPSOtoOGP(bruto);
            isWriting = false;
        }

        internal Collection<OneGetPackage> getAllPackages()
        {
            updateLocal();
            return repository;
        }
    }
}
