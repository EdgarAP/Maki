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
    class PSInvoker
    {

        protected void invokeVoid(string script)
        {
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                using (powershell)
                {
                    powershell.Runspace = myRunSpace;
                    powershell.AddScript(script);
                    powershell.Invoke();
                }
                powershell = null;
                myRunSpace.Close();
            }
        }
        protected Collection<PSObject> invokePSObject(string script)
        {
            Collection<PSObject> result;
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                powershell.Runspace = myRunSpace;
                using (powershell)
                {
                    powershell.AddScript(script);
                    result = powershell.Invoke();
                }
                powershell = null;
                myRunSpace.Close();
                return result;
            }//using runspace
        }//method
        protected Collection<string> invokeString(string script)
        {
            /*      OLDER WORKING VERSION 
            protected Collection<string> invokeString(string command){Collection<string> list = new Collection<string>();
            foreach (string str in PowerShell.Create().AddScript(command).Invoke<string>()){list.Add(str);}return list;}   
            */

        Collection<string> result = new Collection<string>();
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                powershell.Runspace = myRunSpace;
                using (powershell)
                {
                    powershell.AddScript(script);
                    foreach (string str in powershell.Invoke<string>())
                    {
                        result.Add(str);
                    }
                }
                powershell = null;
                myRunSpace.Close();
                return result;
            }//using runspace
        }//method
    }
}
