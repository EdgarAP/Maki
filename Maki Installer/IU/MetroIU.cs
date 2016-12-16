using MetroFramework.Forms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Maki_Installer.Business;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Maki_Installer.IU
{
    public partial class MetroIU : MetroForm
    {
        PS.OneGet oneget = new PS.OneGet();
        Business.MakiInstaller maki = new Business.MakiInstaller();
        internal PSmanager man = new PSmanager();
        Collection<Business.Package.OneGetPackage> listaInstalados = new Collection<Business.Package.OneGetPackage>();

        public MetroIU()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Collection<Package.OneGetPackage> lista = new Collection<Package.OneGetPackage>();
            Collection<PSObject> result;
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                powershell.Runspace = myRunSpace;
                using (powershell)
                {  //actualizo de remoto a local y saco la lista
                    powershell.AddScript("$obj=find-package -source chocolatey -ProviderName chocolatey -force |select -Property 'name','version','summary','status';$obj|Export-Clixml " + System.IO.Directory.GetCurrentDirectory() + "\\Repository.xml -Force;$obj");
                    result = powershell.Invoke();
                }
                powershell = null;
                myRunSpace.Close();
            }//using runspace
            lista = Package.convertPSOtoOGP(result);
            aplicacionesGrid.DataSource = lista;
            aplicacionColumnaNombre.DataPropertyName = "name";
            aplicacionColumnaVersion.DataPropertyName = "version";
            aplicacionColumnaDescripcion.DataPropertyName = "summary";
            listaInstalados = maki.getInstalledPackageList();
            miMakiGrid.DataSource = listaInstalados;
            miMakiNombre.DataPropertyName = "name";
            miMakiVersionActual.DataPropertyName = "version";
            miMakiUltimaVersion.DataPropertyName = "summary";

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Collection<string> a = new Collection<string>();
            a.Add("firefox");
            a.Add("googlechrome");
            a.Add("notepadplusplus");
            MetroProgreso p = new MetroProgreso(a, "Instalación");
            p.Show();
        }

        private void botonInstalar_Click(object sender, EventArgs e)
        {
            Collection<string> ainstalar = new Collection<string>();
            foreach (DataGridViewRow row in aplicacionesGrid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {
                    string nombre = "";
                    nombre += (string)row.Cells["aplicacionColumnaNombre"].Value;
                    ainstalar.Add(nombre);
                }
            }
            MetroProgreso p = new MetroProgreso(ainstalar, "Instalación");
            p.Show();
        }

        private void botonDesinstalar_Click(object sender, EventArgs e)
        {
            Collection<string> desinstalar = new Collection<string>();
            string message = "";
            foreach (DataGridViewRow row in miMakiGrid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {

                    string nombre = "";
                    nombre += (string)row.Cells["miMakiNombre"].Value;

                    var result = MessageBox.Show("¿Estas seguro de que deseas DESINSTALAR " + nombre + "?", "Desinstalar",
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        desinstalar.Add(nombre);
                    else return;

                }
            }

            MetroProgreso p = new MetroProgreso(desinstalar, "Desinstalación");
            p.Show();

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {

            Collection<string> actualizar = new Collection<string>();

            string message = "";
            foreach (DataGridViewRow row in miMakiGrid.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {

                    string nombre = "";
                    nombre += (string)row.Cells["miMakiNombre"].Value;
                    actualizar.Add(nombre);
                }
            }
            MetroProgreso p = new MetroProgreso(actualizar, "Actualización");
            p.Show();

        }

        private void botonRecargar_Click(object sender, EventArgs e)
        {
            listaInstalados = maki.getInstalledPackageList();
            miMakiGrid.DataSource = listaInstalados;
        }

        private void botonNotepad_Click(object sender, EventArgs e)
        {
            Collection<string> display = man.install("notepadplusplus", "6.9.2");
            foreach (string a in display)
                debugTextBox.AppendText(a + "\n");
        }

        private void bottonRecomendacion_Click(object sender, EventArgs e)
        {
            Collection<string> mes = new Collection<string>();
            mes.Add("googlechrome");
            mes.Add("firefox");
            mes.Add("teamviewer");
            mes.Add("teracopy");
            mes.Add("skype");
            mes.Add("winrar");
            mes.Add("vlc");
            mes.Add("jre8");
            mes.Add("dotnet4.5");
            mes.Add("openoffice");
            mes.Add("flashplayerplugin");
            mes.Add("adobereader");
            MetroProgreso p = new MetroProgreso(mes, "Instalación");
            p.Show();
        }

        private void botonccleaner_Click(object sender, EventArgs e)
        {
            Collection<string> mes = new Collection<string>();
            mes.Add("ccleaner");
            MetroProgreso p = new MetroProgreso(mes, "Instalación");
            p.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
