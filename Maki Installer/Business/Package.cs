using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace Maki_Installer.Business
{
    internal abstract class Package
    { //Carlos Salgado

        internal struct OneGetPackage
        {

            internal string status { get; set; }
            internal string summary;
            internal string name { get; set; }
            internal string version;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }
            public string Version
            {
                get
                {
                    return version;
                }

                set
                {
                    version = value;
                }
            }
            public string Summary
            {
                get
                {
                    return summary;
                }

                set
                {
                    summary = value;
                }
            }
            public string Status
            {
                get
                {
                    return status;
                }

                set
                {
                    status = value;
                }
            }

        }

        internal struct ChocoPackage 
        {
            internal string name; 
            internal string version;
        }
        
        private void update() {}

        internal static Collection<OneGetPackage> convertPSOtoOGP(Collection<PSObject> psc)
        {
            Collection<OneGetPackage> result1 = new Collection<OneGetPackage>();
            OneGetPackage result = new OneGetPackage();
            PSMemberInfo count;
            foreach (PSObject pso in psc)
            {
                count = pso.Properties["Status"];
                result.status = count.Value.ToString()  ?? " ";
                count = pso.Properties["Summary"];
                if (count.Value != null) result.summary = count.Value.ToString() ?? " ";
                count = pso.Properties["Name"];
                result.name = count.Value.ToString() ?? " ";
                count = pso.Properties["Version"];
                result.version = count.Value.ToString() ?? " ";
                result1.Add(result);
            }
            return result1;
        }
        internal static OneGetPackage convertPSOtoOGP(PSObject pso)
        {
            OneGetPackage result = new OneGetPackage();
            PSMemberInfo count = pso.Properties["Status"];
            result.status = count.Value.ToString() ?? " ";
            count = pso.Properties["Summary"];
            result.summary = count.Value.ToString() ?? " ";
            count = pso.Properties["Name"];
            result.name = count.Value.ToString() ?? " ";
            count = pso.Properties["Version"];
            result.version = count.Value.ToString() ?? " ";

            return result;
        }
        /* CONVIERTE UN STRING A OGP CON EL SUMMARY Y STATUS EN BLANCO (PARA PAQUETES INSTALADOS) */
        internal static Collection<OneGetPackage> convertStringtoOGP(Collection<string> str)
        {
            PS.OneGet oneget = new PS.OneGet();
            Collection<OneGetPackage> result1 = new Collection<OneGetPackage>();
            OneGetPackage result = new OneGetPackage();
            string count;
            try
            {
                foreach (string s in str)
                {
                    int index = s.LastIndexOf(" ");
                    count = s.Substring(0, index);
                    result.name = count;
                    string nombre = count;
                    count = s.Substring(index + 1);
                    result.version = count;
                    string currentVersion = oneget.getCurrentPackageVersion(nombre);
                    result.summary = currentVersion;
                    result.status = "";
                    result1.Add(result);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Source);
            }
            return result1;
        }

        //convertPSOtoCP
        //convertOGPtoCP
        //convertCPtoOGP

    }
}
