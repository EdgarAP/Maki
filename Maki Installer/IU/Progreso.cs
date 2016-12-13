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
    public partial class Progreso : Form
    {
        Collection<string> paquetes;
        string modo;
        internal struct Pkts
        {
            internal string name;
            internal string estado;
        }

        public Progreso(Collection<string> paquetes, string modo)
        {

            this.modo = modo;
            this.paquetes = paquetes;
            InitializeComponent();
        }

        private void Progreso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collection<Pkts> pkts = new Collection<Pkts>();
            foreach (string pkt in paquetes)
            {
                Pkts pk = new Pkts();
                pk.name = pkt;
                pk.estado = "En espera";
                pkts.Add(pk);
            }
            textBox1.Clear(); foreach (Pkts a in pkts) { textBox1.AppendText(a.name + " - " + a.estado + "\n"); }

            Collection<string> result = new Collection<string>();
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                powershell.Runspace = myRunSpace;
                using (powershell)
                {

                    foreach (string paquete in paquetes)
                    {
                        if (true)
                        {
                            Pkts pk1 = new Pkts();
                            pk1.name = paquete;
                            pk1.estado = "En espera";
                            pkts.Remove(pk1);
                            pk1.estado = "En proceso";
                            pkts.Add(pk1);
                        }
                        textBox1.Clear(); foreach (Pkts a in pkts)
                        {
                            textBox1.AppendText(a.name + " - " + a.estado + "\n");
                            textBox2.Clear();
                            textBox2.AppendText(a.name + " se está procesando");
                        }

                        if (modo == "i") powershell.AddScript("choco install " + paquete + " -y --allowemptychecksum");
                        else if (modo == "d") powershell.AddScript("choco uninstall " + paquete + " -y --remove-dependencies");
                        else if (modo == "a") powershell.AddScript("choco upgrade " + paquete + " -y --allowemptychecksum");

                        foreach (string str in powershell.Invoke<string>())
                        {
                            if (str.Contains("packages failed."))
                                if (str.Contains("0 packages failed."))
                                {
                                    Pkts pk1 = new Pkts();
                                    pk1.name = paquete;
                                    pk1.estado = "En proceso";
                                    pkts.Remove(pk1);
                                    pk1.estado = "Éxito";
                                    pkts.Add(pk1);

                                    textBox1.Clear(); foreach (Pkts a in pkts) { textBox1.AppendText(a.name + " - " + a.estado + "\n"); }
                                }
                                else
                                {
                                    Pkts pk1 = new Pkts();
                                    pk1.name = paquete;
                                    pk1.estado = "En proceso";
                                    pkts.Remove(pk1);
                                    pk1.estado = "Fallo";
                                    pkts.Add(pk1);
                                    textBox1.Clear(); foreach (Pkts a in pkts) { textBox1.AppendText(a.name + " - " + a.estado + "\n"); }
                                }
                        }
                    }
                }
                powershell = null;
                myRunSpace.Close();
            }
        }
    }
}
