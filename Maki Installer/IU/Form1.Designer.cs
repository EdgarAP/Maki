namespace Maki_Installer.IU
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Form3 = new System.Windows.Forms.TabPage();
            this.miMakiRecargar = new System.Windows.Forms.Button();
            this.miMakiActualizar = new System.Windows.Forms.Button();
            this.miMakiDesinstalar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.miMakiSelec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.miMakiImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.miMakiNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miMakiVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miMakiDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debug = new System.Windows.Forms.TabPage();
            this.debugText = new System.Windows.Forms.TextBox();
            this.makiInstallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.installNPOld = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.Form3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Debug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makiInstallerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "Debug";
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Form3);
            this.tabControl1.Controls.Add(this.Debug);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = "";
            this.tabPage1.AccessibleName = "";
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(673, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Packs";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(673, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Paquetes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(458, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Crear Pack";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(571, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Instalar Paquetes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Version,
            this.Descripcion});
            this.dataGridView1.DataSource = this.packageBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(667, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seleccionada";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.Description = "Imagen";
            this.Column2.HeaderText = "Imagen";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.HeaderText = "Versión";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(Maki_Installer.Business.Package);
            // 
            // Form3
            // 
            this.Form3.Controls.Add(this.miMakiRecargar);
            this.Form3.Controls.Add(this.miMakiActualizar);
            this.Form3.Controls.Add(this.miMakiDesinstalar);
            this.Form3.Controls.Add(this.dataGridView2);
            this.Form3.Location = new System.Drawing.Point(4, 22);
            this.Form3.Margin = new System.Windows.Forms.Padding(2);
            this.Form3.Name = "Form3";
            this.Form3.Padding = new System.Windows.Forms.Padding(2);
            this.Form3.Size = new System.Drawing.Size(673, 356);
            this.Form3.TabIndex = 2;
            this.Form3.Text = "Mi Maki";
            this.Form3.UseVisualStyleBackColor = true;
            // 
            // miMakiRecargar
            // 
            this.miMakiRecargar.Location = new System.Drawing.Point(5, 333);
            this.miMakiRecargar.Name = "miMakiRecargar";
            this.miMakiRecargar.Size = new System.Drawing.Size(103, 23);
            this.miMakiRecargar.TabIndex = 4;
            this.miMakiRecargar.Text = "Recargar lista";
            this.miMakiRecargar.UseVisualStyleBackColor = true;
            this.miMakiRecargar.Click += new System.EventHandler(this.miMakiRecargar_Click);
            // 
            // miMakiActualizar
            // 
            this.miMakiActualizar.Location = new System.Drawing.Point(512, 333);
            this.miMakiActualizar.Name = "miMakiActualizar";
            this.miMakiActualizar.Size = new System.Drawing.Size(75, 23);
            this.miMakiActualizar.TabIndex = 3;
            this.miMakiActualizar.Text = "Actualizar";
            this.miMakiActualizar.UseVisualStyleBackColor = true;
            this.miMakiActualizar.Click += new System.EventHandler(this.miMakiActualizar_Click);
            // 
            // miMakiDesinstalar
            // 
            this.miMakiDesinstalar.Location = new System.Drawing.Point(593, 333);
            this.miMakiDesinstalar.Name = "miMakiDesinstalar";
            this.miMakiDesinstalar.Size = new System.Drawing.Size(75, 23);
            this.miMakiDesinstalar.TabIndex = 2;
            this.miMakiDesinstalar.Text = "Desinstalar";
            this.miMakiDesinstalar.UseVisualStyleBackColor = true;
            this.miMakiDesinstalar.Click += new System.EventHandler(this.miMakiDesinstalar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.miMakiSelec,
            this.miMakiImagen,
            this.miMakiNombre,
            this.miMakiVersion,
            this.miMakiDescripcion});
            this.dataGridView2.DataSource = this.packageBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(669, 329);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // miMakiSelec
            // 
            this.miMakiSelec.HeaderText = "Seleccionada";
            this.miMakiSelec.Name = "miMakiSelec";
            this.miMakiSelec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // miMakiImagen
            // 
            this.miMakiImagen.Description = "Imagen";
            this.miMakiImagen.HeaderText = "Imagen";
            this.miMakiImagen.Name = "miMakiImagen";
            this.miMakiImagen.ReadOnly = true;
            // 
            // miMakiNombre
            // 
            this.miMakiNombre.HeaderText = "Nombre";
            this.miMakiNombre.Name = "miMakiNombre";
            this.miMakiNombre.ReadOnly = true;
            // 
            // miMakiVersion
            // 
            this.miMakiVersion.HeaderText = "Versión actual";
            this.miMakiVersion.Name = "miMakiVersion";
            this.miMakiVersion.ReadOnly = true;
            // 
            // miMakiDescripcion
            // 
            this.miMakiDescripcion.HeaderText = "Última versión";
            this.miMakiDescripcion.Name = "miMakiDescripcion";
            this.miMakiDescripcion.ReadOnly = true;
            // 
            // Debug
            // 
            this.Debug.AccessibleName = "Debug";
            this.Debug.Controls.Add(this.installNPOld);
            this.Debug.Controls.Add(this.debugText);
            this.Debug.Location = new System.Drawing.Point(4, 22);
            this.Debug.Name = "Debug";
            this.Debug.Padding = new System.Windows.Forms.Padding(3);
            this.Debug.Size = new System.Drawing.Size(673, 356);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "Debug";
            this.Debug.UseVisualStyleBackColor = true;
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(6, 6);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugText.Size = new System.Drawing.Size(661, 344);
            this.debugText.TabIndex = 5;
            this.debugText.Tag = "debugText";
            // 
            // makiInstallerBindingSource
            // 
            this.makiInstallerBindingSource.DataSource = typeof(Maki_Installer.Business.MakiInstaller);
            this.makiInstallerBindingSource.CurrentChanged += new System.EventHandler(this.makiInstallerBindingSource_CurrentChanged);
            // 
            // installNPOld
            // 
            this.installNPOld.Location = new System.Drawing.Point(563, 333);
            this.installNPOld.Name = "installNPOld";
            this.installNPOld.Size = new System.Drawing.Size(75, 23);
            this.installNPOld.TabIndex = 6;
            this.installNPOld.Text = "NP++ 6.7.5";
            this.installNPOld.UseVisualStyleBackColor = true;
            this.installNPOld.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 397);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.Form3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Debug.ResumeLayout(false);
            this.Debug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makiInstallerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Form3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource makiInstallerBindingSource;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TabPage Debug;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button miMakiDesinstalar;
        private System.Windows.Forms.Button miMakiActualizar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn miMakiSelec;
        private System.Windows.Forms.DataGridViewImageColumn miMakiImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiDescripcion;
        private System.Windows.Forms.Button miMakiRecargar;
        public System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.Button installNPOld;
    }
}