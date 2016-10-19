using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace Maki_Installer.PS
{

    internal partial class PSmanager
    {
        internal class Chocolatey
        {
            private Collection<string> invoke(string command)
            {
                Collection<string> list = new Collection<string>();

                foreach (string str in PowerShell.Create().AddScript(command).Invoke<string>())
                {
                    list.Add(str);
                }
                return list;
            }

            internal Collection<string> install(string package, string version)
            {
                return install(package + " --version " + version);
            }

            internal Collection<string> install(string package)
            {
                string command = "choco install " + package + " -y --allowemptychecksum";
                return invoke(command);
                // if (abc.Contains("0 packages failed"))
            }

            internal Collection<string> upgrade(string package)
            {
                string command = "choco upgrade " + package + " -y --allowemptychecksum";
                return invoke(command);
            }

            internal Collection<string> outdated()
            {
                return invoke("choco outdated");
            }

            internal Collection<string> uninstall(string package)
            {
                string command = "choco uninstall " + package + " -y --remove-dependencies";
                return invoke(command);
            }

            internal Collection<string> listLocal()
            {
                return invoke("choco list -l");
            }
            internal Collection<string> listAll(string filter)
            {
                return invoke("choco list -l");
            }
            internal class Pin
            {
                internal string Add(string package, string version)
                {
                    //choco pin add -n='package' --version 'version'
                    return "TODO";
                }
                internal string Add(string package)
                {
                    //choco pin add -n='package'
                    return "TODO";
                }
                internal string Remove(string package)
                {
                    //choco pin remove --name git
                    return "TODO";
                }
                internal string List()
                {
                    //choco pin list  
                    return "TODO";
                }
            }//pin
        }//choco
    }//PSmanager
}//namespace
