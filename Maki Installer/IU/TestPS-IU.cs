using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maki_Installer.IU
{
    public partial class Form2 : Form
    { //Carlos Salgado
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Business.MakiInstaller maki = new Business.MakiInstaller();
            Collection<string> display = maki.installFirefox();
            foreach (string a in display)
            {
                textBox4.AppendText(a +"\n");
            }
           // if(display.Contains("0 packages failed")) return viva!
            //PARA MOSTRAR TODOS LOS ELEMENTOS DEL REPOSITORIO LOCAL 
              
             /* Collection<Business.Package.OneGetPackage> display = new Collection<Business.Package.OneGetPackage>();
              display = maki.getAllPackages();
               foreach (Business.Package.OneGetPackage a in display)
            {
                textBox1.AppendText(a.name + "\n");
                textBox2.AppendText(a.status + "\n");
                textBox3.AppendText(a.version + "\n");
                textBox4.AppendText(a.summary + "\n");
            }*/
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Business.MakiInstaller maki = new Business.MakiInstaller();
            maki.updateRemoteRepository();
            progressBar1.Value = 100;
            progressBar1.Update();
        }
    }
}
