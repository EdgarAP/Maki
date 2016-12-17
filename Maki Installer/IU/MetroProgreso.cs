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
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
        Collection<string> paquetes;
        Collection<string> display;
        string modo;
        internal struct Pkts
        {
            internal string name;
            internal string estado;
        }
        Collection<Pkts> pkts = new Collection<Pkts>();

        public MetroProgreso(Collection<string> paquetes, string modo)
        {

            this.modo = modo;
            this.paquetes = paquetes;
            InitializeComponent();
            this.Text = modo;
            this.Shown += new System.EventHandler(this.Progreso_Shown);

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            int i = 0;
            BackgroundWorker worker = sender as BackgroundWorker;
            foreach (string pkt in paquetes)
            {
                i++;
                Pkts pk = new Pkts();
                pk.name = pkt;
                pk.estado = "En espera";
                pkts.Add(pk);
            }
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
                        worker.ReportProgress((i));

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

                                    worker.ReportProgress((i));
                                }
                                else
                                {
                                    Pkts pk1 = new Pkts();
                                    pk1.name = paquete;
                                    pk1.estado = "En proceso";
                                    pkts.Remove(pk1);
                                    pk1.estado = "Fallo";
                                    pkts.Add(pk1);
                                    worker.ReportProgress((i));
                                }
                        }
                        worker.ReportProgress((i));
                    }
                }
                powershell = null;
                myRunSpace.Close();
                

                this.Text = "Finalizado";

                Application.DoEvents();
            }
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBox1.Clear(); foreach (Pkts a in pkts) { textBox1.AppendText(a.name + " - " + a.estado + "\n"); }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressSpinner1.Value = 200;
            metroProgressSpinner1.Spinning = false;
            metroProgressSpinner1.Visible = false;
            metroProgressSpinner1.Update();
            finishedImage.Visible = true;
            textBox2.AppendText(modo + " completada");
        }

        private void Progreso_Shown(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public void metroProgressSpinner1_Click(object sender, EventArgs e) { }
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}