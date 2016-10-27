﻿using Maki_Installer.Business;
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
        internal PSmanager man = new PSmanager();
        
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
            Business.MakiInstaller maki = new Business.MakiInstaller();
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
            firefox.version = "49.0.2.20161024";
            Business.Package.OneGetPackage chrome = new Business.Package.OneGetPackage();
            chrome.status = "Available";
            chrome.name = "GoogleChrome";
            chrome.summary = "";
            chrome.version = "54.0.2840.71";

            Collection<Business.Package.OneGetPackage> lista = new Collection<Business.Package.OneGetPackage>();
            lista.Add(firefox);
            lista.Add(chrome);
            dataGridView1.DataSource = lista;
           
            Column3.DataPropertyName = "Name";
            Version.DataPropertyName = "Version";
            Descripcion.DataPropertyName = "Summary";

            
            
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


    }
}
