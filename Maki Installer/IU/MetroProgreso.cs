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
using System.Management.Automation.Runspaces;
using System.Management.Automation;

namespace Maki_Installer.IU
{
    public partial class MetroProgreso : MetroForm
    {

        Collection<string> paquetes;
        Collection<string> display;
        string modo;
        internal struct Pkts
        {
            internal string name;
            internal string estado;
        }

        public MetroProgreso(Collection<string> paquetes, string modo)
        {

            this.modo = modo;
            this.paquetes = paquetes;
            InitializeComponent();
            this.Text = modo;
            this.Shown += new System.EventHandler(this.Progreso_Shown);

        }

        private void Progreso_Shown(object sender, EventArgs e)
        {
            int i = 0;

            Collection<Pkts> pkts = new Collection<Pkts>();
            foreach (string pkt in paquetes)
            {
                i++;
                Pkts pk = new Pkts();
                pk.name = pkt;
                pk.estado = "En espera";
                pkts.Add(pk);
            }
            textBox1.Clear(); foreach (Pkts a in pkts) { textBox1.AppendText(a.name + " - " + a.estado + "\n"); }

            Collection<string> result = new Collection<string>();
            using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
            {
                i = (int)100 / i;
                myRunSpace.Open();
                PowerShell powershell = PowerShell.Create();
                powershell.Runspace = myRunSpace;
                using (powershell)
                {
                    
                   
                    Application.DoEvents();

                    foreach (string paquete in paquetes)
                    {
                        Application.DoEvents();
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

                        if (modo == "Instalación") powershell.AddScript("choco install " + paquete + " -y --allowemptychecksum");
                        else if (modo == "Desinstalación") powershell.AddScript("choco uninstall " + paquete + " -y --remove-dependencies");
                        else if (modo == "Actualización") powershell.AddScript("choco upgrade " + paquete + " -y --allowemptychecksum");

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
                        
                        Application.DoEvents();
                        textBox2.Clear();
                        textBox2.AppendText("Se ha completado la " + modo);
                    }
                }
                powershell = null;
                myRunSpace.Close();

                metroProgressSpinner1.Value = 200;
                metroProgressSpinner1.Spinning = false;
                metroProgressSpinner1.Visible = false;
                metroProgressSpinner1.Update();

                finishedImage.Visible = true;

                this.Text = "Finalizado";

                Application.DoEvents();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }
    }
}
