using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.PS
{
    internal partial class PSmanager
    {
        private Chocolatey chocolate = new Chocolatey();
        private Chocolatey.Pin chocopin = new Chocolatey.Pin();

        internal bool install(string package)
        {
            return chocolate.install(package);
        }
        internal bool install(string package, string version)
        {
            return chocolate.install(package, version);
        }
        internal bool upgrade(string package)
        {
            return chocolate.upgrade(package);
        }
        internal List<string> outdated()
        {
            return chocolate.outdated();
        }
        internal bool uninstall(string package)
        {
            return chocolate.uninstall(package);
        }
        internal List<string> listLocal()
        {
            return chocolate.listLocal();
        }
        internal List<string> listAll(string filter = "")
        {
            return chocolate.listAll(filter);
        }
        internal string pinAdd(string package, string version)
        {
            return chocopin.Add(package, version);
        }
        internal string pinAdd(string package)
        {
            return chocopin.Add(package);
        }
        internal string pinRemove(string package)
        {
            return chocopin.Remove(package);
        }
        internal string pinList()
        {
            return chocopin.List();
        }
    }//psmanager
}//namespace

