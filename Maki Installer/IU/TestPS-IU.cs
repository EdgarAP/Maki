using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maki_Installer.IU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Instalando firefox");
            PS.PSmanager psman = new PS.PSmanager();
            if (psman.install("firefox"))
            {
                textBox1.Clear();
                textBox1.AppendText("exito");
            }
            else
            {
                textBox1.Clear();
                textBox1.AppendText("fallo");
            }
        }
    }
}
