using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using static Maki_Installer.Business.Package;

namespace Maki_Installer.Business
{
    class MakiInstaller
    {
        internal RepositoryPackage repo = new RepositoryPackage();
        internal InstalledPackage insta = new InstalledPackage();
        internal PinnedPackage pin = new PinnedPackage();
        internal PSmanager man = new PSmanager();

        internal void updateRemoteRepository()
        {
            Collection<PSObject> bruto = man.getPackageListRemote();
            repo.repository = convertPSOtoOGP(bruto);
        }
        private void updateLocalRepository()
        {
            Collection<PSObject> bruto = man.getPackageListLocal();
            repo.repository = convertPSOtoOGP(bruto);
        }
        internal Collection<string> installFirefox()
        {
            return man.install("firefox");
        }
        internal Collection<OneGetPackage> getAllPackages()
        {
            updateLocalRepository();
            return repo.repository;
        }
        internal Collection<OneGetPackage> getInstalledPackageList()
        {
            Collection<string> bruto = man.getInstalledPackageList();
            return convertStringtoOGP(bruto);
        }

    }
}
