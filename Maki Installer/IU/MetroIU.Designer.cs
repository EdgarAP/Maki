namespace Maki_Installer.IU
{
    partial class MetroIU
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.aplicacionesTab = new MetroFramework.Controls.MetroTabPage();
            this.botonInstalar = new MetroFramework.Controls.MetroButton();
            this.aplicacionesGrid = new MetroFramework.Controls.MetroGrid();
            this.aplicacionesColumnaSeleccionada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicacionColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionColumnaVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionColumnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miMakiTab = new MetroFramework.Controls.MetroTabPage();
            this.botonRecargar = new MetroFramework.Controls.MetroButton();
            this.botonActualizar = new MetroFramework.Controls.MetroButton();
            this.botonDesinstalar = new MetroFramework.Controls.MetroButton();
            this.miMakiGrid = new MetroFramework.Controls.MetroGrid();
            this.miMakiSelecionada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.miMakiNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miMakiVersionActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miMakiUltimaVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paquetesTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.botonccleaner = new MetroFramework.Controls.MetroButton();
            this.bottonRecomendacion = new MetroFramework.Controls.MetroButton();
            this.debugTab = new MetroFramework.Controls.MetroTabPage();
            this.botonNotepad = new MetroFramework.Controls.MetroButton();
            this.debugTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.aplicacionesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.miMakiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miMakiGrid)).BeginInit();
            this.paquetesTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.aplicacionesTab);
            this.metroTabControl1.Controls.Add(this.miMakiTab);
            this.metroTabControl1.Controls.Add(this.paquetesTab);
            this.metroTabControl1.Controls.Add(this.debugTab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(814, 375);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // aplicacionesTab
            // 
            this.aplicacionesTab.Controls.Add(this.botonInstalar);
            this.aplicacionesTab.Controls.Add(this.aplicacionesGrid);
            this.aplicacionesTab.HorizontalScrollbarBarColor = true;
            this.aplicacionesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.aplicacionesTab.HorizontalScrollbarSize = 10;
            this.aplicacionesTab.Location = new System.Drawing.Point(4, 38);
            this.aplicacionesTab.Name = "aplicacionesTab";
            this.aplicacionesTab.Size = new System.Drawing.Size(806, 333);
            this.aplicacionesTab.TabIndex = 1;
            this.aplicacionesTab.Text = "Aplicaciones";
            this.aplicacionesTab.VerticalScrollbarBarColor = true;
            this.aplicacionesTab.VerticalScrollbarHighlightOnWheel = false;
            this.aplicacionesTab.VerticalScrollbarSize = 10;
            this.aplicacionesTab.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // botonInstalar
            // 
            this.botonInstalar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.botonInstalar.Location = new System.Drawing.Point(724, 304);
            this.botonInstalar.Name = "botonInstalar";
            this.botonInstalar.Size = new System.Drawing.Size(79, 26);
            this.botonInstalar.Style = MetroFramework.MetroColorStyle.Green;
            this.botonInstalar.TabIndex = 4;
            this.botonInstalar.Text = "Instalar";
            this.botonInstalar.UseSelectable = true;
            this.botonInstalar.UseStyleColors = true;
            this.botonInstalar.Click += new System.EventHandler(this.botonInstalar_Click);
            // 
            // aplicacionesGrid
            // 
            this.aplicacionesGrid.AllowUserToResizeRows = false;
            this.aplicacionesGrid.AutoGenerateColumns = false;
            this.aplicacionesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aplicacionesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aplicacionesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aplicacionesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.aplicacionesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aplicacionesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.aplicacionesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aplicacionesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aplicacionesColumnaSeleccionada,
            this.aplicacionColumnaNombre,
            this.aplicacionColumnaVersion,
            this.aplicacionColumnaDescripcion});
            this.aplicacionesGrid.DataSource = this.packageBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aplicacionesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.aplicacionesGrid.EnableHeadersVisualStyles = false;
            this.aplicacionesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.aplicacionesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.aplicacionesGrid.Location = new System.Drawing.Point(0, 13);
            this.aplicacionesGrid.Name = "aplicacionesGrid";
            this.aplicacionesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aplicacionesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.aplicacionesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.aplicacionesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aplicacionesGrid.Size = new System.Drawing.Size(810, 317);
            this.aplicacionesGrid.TabIndex = 2;
            // 
            // aplicacionesColumnaSeleccionada
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aplicacionesColumnaSeleccionada.DefaultCellStyle = dataGridViewCellStyle2;
            this.aplicacionesColumnaSeleccionada.HeaderText = "Seleccionada";
            this.aplicacionesColumnaSeleccionada.Name = "aplicacionesColumnaSeleccionada";
            // 
            // aplicacionColumnaNombre
            // 
            this.aplicacionColumnaNombre.HeaderText = "Nombre";
            this.aplicacionColumnaNombre.Name = "aplicacionColumnaNombre";
            this.aplicacionColumnaNombre.ReadOnly = true;
            // 
            // aplicacionColumnaVersion
            // 
            this.aplicacionColumnaVersion.HeaderText = "Versión";
            this.aplicacionColumnaVersion.Name = "aplicacionColumnaVersion";
            this.aplicacionColumnaVersion.ReadOnly = true;
            // 
            // aplicacionColumnaDescripcion
            // 
            this.aplicacionColumnaDescripcion.HeaderText = "Descripcion";
            this.aplicacionColumnaDescripcion.Name = "aplicacionColumnaDescripcion";
            this.aplicacionColumnaDescripcion.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(Maki_Installer.Business.Package);
            // 
            // miMakiTab
            // 
            this.miMakiTab.Controls.Add(this.botonRecargar);
            this.miMakiTab.Controls.Add(this.botonActualizar);
            this.miMakiTab.Controls.Add(this.botonDesinstalar);
            this.miMakiTab.Controls.Add(this.miMakiGrid);
            this.miMakiTab.HorizontalScrollbarBarColor = true;
            this.miMakiTab.HorizontalScrollbarHighlightOnWheel = false;
            this.miMakiTab.HorizontalScrollbarSize = 10;
            this.miMakiTab.Location = new System.Drawing.Point(4, 38);
            this.miMakiTab.Name = "miMakiTab";
            this.miMakiTab.Size = new System.Drawing.Size(806, 333);
            this.miMakiTab.TabIndex = 2;
            this.miMakiTab.Text = "Mi Maki";
            this.miMakiTab.VerticalScrollbarBarColor = true;
            this.miMakiTab.VerticalScrollbarHighlightOnWheel = false;
            this.miMakiTab.VerticalScrollbarSize = 10;
            // 
            // botonRecargar
            // 
            this.botonRecargar.Location = new System.Drawing.Point(4, 306);
            this.botonRecargar.Name = "botonRecargar";
            this.botonRecargar.Size = new System.Drawing.Size(75, 23);
            this.botonRecargar.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonRecargar.TabIndex = 7;
            this.botonRecargar.Text = "Recargar";
            this.botonRecargar.UseSelectable = true;
            this.botonRecargar.UseStyleColors = true;
            this.botonRecargar.Click += new System.EventHandler(this.botonRecargar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(717, 294);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(86, 36);
            this.botonActualizar.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonActualizar.TabIndex = 6;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseSelectable = true;
            this.botonActualizar.UseStyleColors = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonDesinstalar
            // 
            this.botonDesinstalar.Location = new System.Drawing.Point(623, 294);
            this.botonDesinstalar.Name = "botonDesinstalar";
            this.botonDesinstalar.Size = new System.Drawing.Size(88, 36);
            this.botonDesinstalar.Style = MetroFramework.MetroColorStyle.Red;
            this.botonDesinstalar.TabIndex = 5;
            this.botonDesinstalar.Text = "Desinstalar";
            this.botonDesinstalar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botonDesinstalar.UseSelectable = true;
            this.botonDesinstalar.UseStyleColors = true;
            this.botonDesinstalar.Click += new System.EventHandler(this.botonDesinstalar_Click);
            // 
            // miMakiGrid
            // 
            this.miMakiGrid.AllowUserToResizeRows = false;
            this.miMakiGrid.AutoGenerateColumns = false;
            this.miMakiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.miMakiGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.miMakiGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.miMakiGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.miMakiGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.miMakiGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.miMakiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miMakiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.miMakiSelecionada,
            this.miMakiNombre,
            this.miMakiVersionActual,
            this.miMakiUltimaVersion});
            this.miMakiGrid.DataSource = this.packageBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.miMakiGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.miMakiGrid.EnableHeadersVisualStyles = false;
            this.miMakiGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.miMakiGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.miMakiGrid.Location = new System.Drawing.Point(0, 13);
            this.miMakiGrid.Name = "miMakiGrid";
            this.miMakiGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.miMakiGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.miMakiGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.miMakiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.miMakiGrid.Size = new System.Drawing.Size(810, 317);
            this.miMakiGrid.TabIndex = 3;
            // 
            // miMakiSelecionada
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miMakiSelecionada.DefaultCellStyle = dataGridViewCellStyle6;
            this.miMakiSelecionada.HeaderText = "Seleccionada";
            this.miMakiSelecionada.Name = "miMakiSelecionada";
            // 
            // miMakiNombre
            // 
            this.miMakiNombre.HeaderText = "Nombre";
            this.miMakiNombre.Name = "miMakiNombre";
            this.miMakiNombre.ReadOnly = true;
            // 
            // miMakiVersionActual
            // 
            this.miMakiVersionActual.HeaderText = "Versión actual";
            this.miMakiVersionActual.Name = "miMakiVersionActual";
            this.miMakiVersionActual.ReadOnly = true;
            // 
            // miMakiUltimaVersion
            // 
            this.miMakiUltimaVersion.HeaderText = "Última versión";
            this.miMakiUltimaVersion.Name = "miMakiUltimaVersion";
            this.miMakiUltimaVersion.ReadOnly = true;
            // 
            // paquetesTab
            // 
            this.paquetesTab.Controls.Add(this.metroLabel2);
            this.paquetesTab.Controls.Add(this.metroLabel1);
            this.paquetesTab.Controls.Add(this.botonccleaner);
            this.paquetesTab.Controls.Add(this.bottonRecomendacion);
            this.paquetesTab.HorizontalScrollbarBarColor = true;
            this.paquetesTab.HorizontalScrollbarHighlightOnWheel = false;
            this.paquetesTab.HorizontalScrollbarSize = 10;
            this.paquetesTab.Location = new System.Drawing.Point(4, 38);
            this.paquetesTab.Name = "paquetesTab";
            this.paquetesTab.Size = new System.Drawing.Size(806, 333);
            this.paquetesTab.TabIndex = 0;
            this.paquetesTab.Text = "Paquetes";
            this.paquetesTab.VerticalScrollbarBarColor = true;
            this.paquetesTab.VerticalScrollbarHighlightOnWheel = false;
            this.paquetesTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(215, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(595, 50);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "CCleaner es la herramienta número uno para limpiar tu ordenador Windows.\r\nProtege" +
    " su privacidad online y hace su ordenador más rápido y seguro.";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(215, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(520, 50);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "GoogleChrome, Firefox, Teamviewer, Teracopy, Skype, WinRAR, VLC,\r\nJava, .net 4.5," +
    " OpenOffice, Flash Player y Adobe Reader";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // botonccleaner
            // 
            this.botonccleaner.Location = new System.Drawing.Point(14, 163);
            this.botonccleaner.Name = "botonccleaner";
            this.botonccleaner.Size = new System.Drawing.Size(185, 113);
            this.botonccleaner.TabIndex = 3;
            this.botonccleaner.Text = "CCleaner";
            this.botonccleaner.UseSelectable = true;
            this.botonccleaner.Click += new System.EventHandler(this.botonccleaner_Click);
            // 
            // bottonRecomendacion
            // 
            this.bottonRecomendacion.Location = new System.Drawing.Point(14, 34);
            this.bottonRecomendacion.Name = "bottonRecomendacion";
            this.bottonRecomendacion.Size = new System.Drawing.Size(185, 103);
            this.bottonRecomendacion.TabIndex = 2;
            this.bottonRecomendacion.Text = "Recomendación";
            this.bottonRecomendacion.UseSelectable = true;
            this.bottonRecomendacion.Click += new System.EventHandler(this.bottonRecomendacion_Click);
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.botonNotepad);
            this.debugTab.Controls.Add(this.debugTextBox);
            this.debugTab.HorizontalScrollbarBarColor = true;
            this.debugTab.HorizontalScrollbarHighlightOnWheel = false;
            this.debugTab.HorizontalScrollbarSize = 10;
            this.debugTab.Location = new System.Drawing.Point(4, 38);
            this.debugTab.Name = "debugTab";
            this.debugTab.Size = new System.Drawing.Size(806, 333);
            this.debugTab.TabIndex = 3;
            this.debugTab.Text = "Debug";
            this.debugTab.VerticalScrollbarBarColor = true;
            this.debugTab.VerticalScrollbarHighlightOnWheel = false;
            this.debugTab.VerticalScrollbarSize = 10;
            // 
            // botonNotepad
            // 
            this.botonNotepad.Location = new System.Drawing.Point(706, 307);
            this.botonNotepad.Name = "botonNotepad";
            this.botonNotepad.Size = new System.Drawing.Size(75, 23);
            this.botonNotepad.TabIndex = 4;
            this.botonNotepad.Text = "NP++";
            this.botonNotepad.UseSelectable = true;
            this.botonNotepad.Click += new System.EventHandler(this.botonNotepad_Click);
            // 
            // debugTextBox
            // 
            // 
            // 
            // 
            this.debugTextBox.CustomButton.Image = null;
            this.debugTextBox.CustomButton.Location = new System.Drawing.Point(475, 2);
            this.debugTextBox.CustomButton.Name = "";
            this.debugTextBox.CustomButton.Size = new System.Drawing.Size(325, 325);
            this.debugTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.debugTextBox.CustomButton.TabIndex = 1;
            this.debugTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.debugTextBox.CustomButton.UseSelectable = true;
            this.debugTextBox.CustomButton.Visible = false;
            this.debugTextBox.Lines = new string[0];
            this.debugTextBox.Location = new System.Drawing.Point(3, 3);
            this.debugTextBox.MaxLength = 32767;
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.PasswordChar = '\0';
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugTextBox.SelectedText = "";
            this.debugTextBox.SelectionLength = 0;
            this.debugTextBox.SelectionStart = 0;
            this.debugTextBox.ShortcutsEnabled = true;
            this.debugTextBox.Size = new System.Drawing.Size(803, 330);
            this.debugTextBox.TabIndex = 2;
            this.debugTextBox.UseSelectable = true;
            this.debugTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.debugTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroIU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(860, 461);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "MetroIU";
            this.Resizable = false;
            this.Text = "Maki Installer";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.aplicacionesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.miMakiTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miMakiGrid)).EndInit();
            this.paquetesTab.ResumeLayout(false);
            this.paquetesTab.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage paquetesTab;
        private MetroFramework.Controls.MetroTabPage aplicacionesTab;
        private MetroFramework.Controls.MetroTabPage miMakiTab;
        private MetroFramework.Controls.MetroTabPage debugTab;
        private MetroFramework.Controls.MetroGrid aplicacionesGrid;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private MetroFramework.Controls.MetroButton botonInstalar;
        private MetroFramework.Controls.MetroGrid miMakiGrid;
        private MetroFramework.Controls.MetroButton botonActualizar;
        private MetroFramework.Controls.MetroButton botonDesinstalar;
        private MetroFramework.Controls.MetroButton botonRecargar;
        private MetroFramework.Controls.MetroButton botonNotepad;
        private MetroFramework.Controls.MetroTextBox debugTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicacionesColumnaSeleccionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionColumnaVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacionColumnaDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn miMakiSelecionada;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiVersionActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn miMakiUltimaVersion;
        private MetroFramework.Controls.MetroButton bottonRecomendacion;
        private MetroFramework.Controls.MetroButton botonccleaner;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}