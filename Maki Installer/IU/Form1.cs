using Maki_Installer.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Maki_Installer.Business.Package;

namespace Maki_Installer.IU
{
    public partial class Form1 : Form
    {
        PS.OneGet oneget = new PS.OneGet();
        Business.MakiInstaller maki = new Business.MakiInstaller();
        internal PSmanager man = new PSmanager();
        Collection<Business.Package.OneGetPackage> listaInstalados = new Collection<Business.Package.OneGetPackage>();


        public Form1()
        {
                InitializeComponent();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {
                    Console.WriteLine("Ola k ase");
                    string nombre = "";
                    nombre += (string)row.Cells["Column3"].Value;
                    Console.WriteLine(nombre);
                    Collection<string> display = man.install(nombre);
                    
                 
                    
                    foreach (string a in display)
                    {
                        debugText.AppendText(a + "\n");
                        
                    }
                    debugText.AppendText("\n");
                    debugText.AppendText("\n");
                }
            }


            /*
            Business.MakiInstaller maki = new Business.MakiInstaller();
            Collection<string> display = maki.installFirefox();
            foreach (string a in display)
            {
                //textBox4.AppendText(a + "\n");
            }*/
            // if(display.Contains("0 packages failed")) return viva!
            //PARA MOSTRAR TODOS LOS ELEMENTOS DEL REPOSITORIO LOCAL 

             /*Collection<Business.Package.OneGetPackage> display = new Collection<Business.Package.OneGetPackage>();
             display = maki.getAllPackages();
              foreach (Business.Package.OneGetPackage a in display)
           {
               textBox1.AppendText(a.name + "\n");
               textBox2.AppendText(a.status + "\n");
               textBox3.AppendText(a.version + "\n");
               textBox4.AppendText(a.summary + "\n");
           }*/
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Business.Package.OneGetPackage firefox = new Business.Package.OneGetPackage();
            firefox.status = "Available";
            firefox.name = "Firefox";
            firefox.summary = "Bringing together all kinds of awesomeness to make browsing better for you";
            firefox.version = oneget.getCurrentPackageVersion(firefox.name);

            Business.Package.OneGetPackage chrome = new Business.Package.OneGetPackage();
            chrome.status = "Available";
            chrome.name = "GoogleChrome";
            chrome.summary = "";
            chrome.version = oneget.getCurrentPackageVersion(chrome.name);

            Business.Package.OneGetPackage notepadplusplus = new Business.Package.OneGetPackage();
            notepadplusplus.status = "Available";
            notepadplusplus.name = "Notepadplusplus";
            notepadplusplus.summary = "Notepad++ is a free (as in \"free speech\" and also as in \"free beer\") source code editor and Notepad replacement that supports several languages.";
            notepadplusplus.version = oneget.getCurrentPackageVersion(notepadplusplus.name);

            Collection<Business.Package.OneGetPackage> lista = new Collection<Business.Package.OneGetPackage>();
            lista.Add(firefox);
            lista.Add(chrome);
            lista.Add(notepadplusplus);

            dataGridView1.DataSource = lista;
           
            Column3.DataPropertyName = "name";
            Version.DataPropertyName = "version";
            Descripcion.DataPropertyName = "summary";


            /*Collection < string > listaInstalados = man.listLocal();
            foreach(string a in listaInstalados)
                debugText.AppendText(a + "\n");
            dataGridView2.DataSource = listaInstalados;
            InstaladoNombre.DataPropertyName = "";*/

            listaInstalados = maki.getInstalledPackageList();
            dataGridView2.DataSource = listaInstalados;

            miMakiNombre.DataPropertyName = "name";
            miMakiVersion.DataPropertyName = "version";
            miMakiDescripcion.DataPropertyName = "summary";
            




        }

        private void makiInstallerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void debugText_TextChanged(object sender, EventArgs e)
        {

        }

        private void instalados_Click(object sender, EventArgs e)
        {

        }

        private void gridInstalados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void miMakiDesinstalar_Click(object sender, EventArgs e)
        {
            
            string message = "";
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {
                    Console.WriteLine("Desinstalar");
                    string nombre = "";
                    nombre += (string)row.Cells["miMakiNombre"].Value;
                    Console.WriteLine(nombre);
                    Collection<string> display;
                    var result = MessageBox.Show("¿Estas seguro de que deseas desinstalar "+ nombre + "?", "Desinstalar",
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        display = man.uninstall(nombre);
                    else return;

                    string displayToString = "";

                    foreach (string a in display)
                    {
                        debugText.AppendText(a + "\n");
                        displayToString += a + " ";

                    }

                    if (displayToString.Contains("successfully uninstalled"))
                    {
                        message += nombre + " ha sido desinstalado correctamente.\n";
                    }
                    else
                        message += nombre + " no se ha podido desinstalar.\n";

                    debugText.AppendText("\n");
                    debugText.AppendText("\n");



                }
            }
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    

        private void miMakiActualizar_Click(object sender, EventArgs e)
        {

            string message = "";
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool checkBox = (null != checkBoxCell && null != checkBoxCell.Value && true == (bool)checkBoxCell.Value);
                if (checkBox == true)
                {
                    Console.WriteLine("Ola k ase");
                    string nombre = "";
                    nombre += (string)row.Cells["miMakiNombre"].Value;
                    Console.WriteLine(nombre);
                    Collection<string> display = man.upgrade(nombre);

                    string displayToString = "";

                    foreach (string a in display)
                    {
                        debugText.AppendText(a + "\n");
                        displayToString += a + " ";

                    }

                    if (displayToString.Contains("is the latest version available based on your source")){
                        message += nombre + " ya está en su ultima versión.\n";
                    }
                    else
                        message += nombre + " ha sido actualizado.\n";

                    debugText.AppendText("\n");
                    debugText.AppendText("\n");

                    

                }
            }
            MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void miMakiRecargar_Click(object sender, EventArgs e)
        {
            listaInstalados = maki.getInstalledPackageList();
            dataGridView2.DataSource = listaInstalados;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collection<string> display = man.install("notepadplusplus", "6.9.2");
            foreach (string a in display)
                debugText.AppendText(a + "\n");
            
        }
    }
}
