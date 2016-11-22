using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;

namespace Maki_Installer.PS
{
    class Installation : PSInvoker
    {
        internal void setExecutionPolicy()
        {
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                using (powershell)
                {
                    powershell.Runspace = myRunSpace;
                    powershell.AddCommand("set-ExecutionPolicy");
                    powershell.AddArgument("remotesigned");
                    powershell.AddParameter("force");
                    //powershell.AddScript("Echo Write-Host \"Set-ExecutionPolicy remotesigned -force\" | PowerShell.exe -noprofile -");
                    /*powershell.AddCommand("Write-output");
                    powershell.AddArgument("Write-Host \"Set-ExecutionPolicy remotesigned -force\" ");
                    powershell.AddCommand("PowerShell.exe");
                    powershell.AddParameter("noprofile");
                    powershell.AddParameter("command");*/
                    

                    powershell.Invoke();
                }
                powershell = null;
                myRunSpace.Close();
            }//using
        }//method
        internal void installChocolatey()
        {
            invokeVoid("iwr https://chocolatey.org/install.ps1 -UseBasicParsing | iex");
        }//method
        internal bool isChocoInstalled()
        {
            Collection<string> result = new Collection<string>();

            result = invokeString("choco info");
            foreach (string r in result)
            {
                if (r.Contains("Chocolatey")) { return true; }
            }
            return false;

        }//method

    }//class
}

