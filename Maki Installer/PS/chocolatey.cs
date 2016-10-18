using System.Collections.Generic;
using System.Management.Automation;

namespace Maki_Installer.PS
{

    internal partial class PSmanager
    {
        internal class Chocolatey
        {
            private List<string> invoke(string command)
            {
                List<string> list = new List<string>();

                foreach (string str in PowerShell.Create().AddScript(command).Invoke<string>())
                {
                    list.Add(str);
                }
                return list;
            }

            internal bool install(string package, string version)
            {
                return install(package + " --version " + version);
            }

            internal bool install(string package)
            {
                string command = "choco install " + package + " -y --allowemptychecksum";
                List<string> list = invoke(command);
                foreach (string abc in list)
                {
                    if (abc.Contains("0 packages failed"))
                        return true;
                }
                return false;
            }

            internal bool upgrade(string package)
            {
                string command = "choco upgrade " + package + " -y --allowemptychecksum";
                List<string> list = invoke(command);
                foreach (string abc in list)
                {
                    if (abc.Contains("0 packages failed"))
                        return true;
                }
                return false;
            }

            internal List<string> outdated()
            {
                return invoke("choco outdated");
            }

            internal bool uninstall(string package)
            {
                string command = "choco uninstall " + package + " -y --remove-dependencies";
                List<string> list = invoke(command);
                foreach (string abc in list)
                {
                    if (abc.Contains("0 packages failed"))
                        return true;
                }
                return false;

            }

            internal List<string> listLocal()
            {
                return invoke("choco list -l");
            }
            internal List<string> listAll(string filter)
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
