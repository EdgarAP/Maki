using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace Maki_Installer.PS
{
    class OneGet : PSInvoker 
    { //Carlos Salgado
        PowerShell powershell = PowerShell.Create();
        internal Collection<PSObject> getPackageListRemote()
        { //no va, find-package no devuelve lo que toca. 
            return invokePSObject("$obj=find-package -source chocolatey|select -Property 'name','version','summary','status';$obj|Export-Clixml "+ StaticInfo.repositoryPkgPath + "\\Repository.xml -Force;");
        }
        internal Collection<PSObject> getPackageListLocal()
        {
            return invokePSObject("Import-Clixml " + StaticInfo.repositoryPkgPath);
        }

        internal Collection<string> getInstalledPackageList()
        {
            return invokeString("choco list -l | where { ($_) -notlike \"*choco*\"} | where { ($_) -notlike \"*packages installed*\"}");
        }
        internal string getCurrentPackageVersion(string package)
        {
            Collection<string> linea = new Collection<string>();
            string lineasuelta = "";
            string result = "";
            try
            {
               linea = invokeString("chocolatey version " + package + " | where {($_) -like \"" + package + " v*.*\"}");
                lineasuelta = linea.ElementAt<string>(0);
            
            int primerEspacio = lineasuelta.IndexOf(' ');
            int segundoEspacio = lineasuelta.Substring(primerEspacio+1).IndexOf(' ');
            result = lineasuelta.Substring(primerEspacio + 1, segundoEspacio);
            }
            catch (Exception e) {
                Console.WriteLine("{0} Exception caught.", e);
                try
                {
                    linea = invokeString("chocolatey version " + package + " | where {($_) -like \"*" + package + " *.*\"}");
                    lineasuelta = linea.ElementAt<string>(0);
                    int primerEspacio = lineasuelta.IndexOf("Version");
                    int segundoEspacio = lineasuelta.Substring(primerEspacio + 8).IndexOf(' ');
                    result = "v" + lineasuelta.Substring(primerEspacio + 8, segundoEspacio);
                }catch(Exception a)
                {
                    Console.WriteLine("{0} Exception caught.", a);
                }
            }
            return result;
        }
    }
}
