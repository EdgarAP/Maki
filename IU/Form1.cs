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

namespace Maki_Installer.IU
{
    public partial class Form1 : Form
    {
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
            Collection<Business.Package.OneGetPackage> display = new Collection<Business.Package.OneGetPackage>();
            Business.RepositoryPackage repo = new Business.RepositoryPackage();
            display = repo.getAllPackages();
            foreach (Business.Package.OneGetPackage a in display)
            {
                /*textBox1.AppendText(a.name + "\n");
                textBox2.AppendText(a.status + "\n");
                textBox3.AppendText(a.version + "\n");
                textBox4.AppendText(a.summary + "\n");*/
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
