namespace PracticaParaElFinal.PicoFermiBagel
{
    partial class PicoFermiBagelForm
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
            this.txbNumeroJugador = new System.Windows.Forms.TextBox();
            this.txbJugador = new System.Windows.Forms.TextBox();
            this.lbJugador = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSgteNumero = new System.Windows.Forms.Button();
            this.tboxTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.tboxPuntaje = new System.Windows.Forms.TextBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.tboxJugador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblNumeroJugador = new System.Windows.Forms.Label();
            this.tbxPista3 = new System.Windows.Forms.TextBox();
            this.tbxPista2 = new System.Windows.Forms.TextBox();
            this.tbxPista1 = new System.Windows.Forms.TextBox();
            this.tbxDigito3 = new System.Windows.Forms.TextBox();
            this.tbxDigito2 = new System.Windows.Forms.TextBox();
            this.tbxDigito1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNumeroJugador
            // 
            this.txbNumeroJugador.Location = new System.Drawing.Point(0, 0);
            this.txbNumeroJugador.Name = "txbNumeroJugador";
            this.txbNumeroJugador.Size = new System.Drawing.Size(100, 20);
            this.txbNumeroJugador.TabIndex = 0;
            // 
            // txbJugador
            // 
            this.txbJugador.Location = new System.Drawing.Point(0, 0);
            this.txbJugador.Name = "txbJugador";
            this.txbJugador.Size = new System.Drawing.Size(100, 20);
            this.txbJugador.TabIndex = 0;
            // 
            // lbJugador
            // 
            this.lbJugador.Location = new System.Drawing.Point(0, 0);
            this.lbJugador.Name = "lbJugador";
            this.lbJugador.Size = new System.Drawing.Size(100, 23);
            this.lbJugador.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(680, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.IniciarMenu_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Enabled = false;
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.ReiniciarMenu_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarMenu_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.MostrarHistorial_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFondo.Controls.Add(this.splitContainer1);
            this.panelFondo.Controls.Add(this.menuStrip1);
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(4);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(680, 365);
            this.panelFondo.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel1.Controls.Add(this.btnSgteNumero);
            this.splitContainer1.Panel1.Controls.Add(this.tboxTiempo);
            this.splitContainer1.Panel1.Controls.Add(this.lblTiempo);
            this.splitContainer1.Panel1.Controls.Add(this.tboxPuntaje);
            this.splitContainer1.Panel1.Controls.Add(this.lblPuntaje);
            this.splitContainer1.Panel1.Controls.Add(this.tboxJugador);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(680, 338);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSgteNumero
            // 
            this.btnSgteNumero.Enabled = false;
            this.btnSgteNumero.Location = new System.Drawing.Point(18, 295);
            this.btnSgteNumero.Name = "btnSgteNumero";
            this.btnSgteNumero.Size = new System.Drawing.Size(190, 29);
            this.btnSgteNumero.TabIndex = 6;
            this.btnSgteNumero.Text = "Siguiente número";
            this.btnSgteNumero.UseVisualStyleBackColor = true;
            this.btnSgteNumero.Click += new System.EventHandler(this.btnSgteNumero_Click);
            // 
            // tboxTiempo
            // 
            this.tboxTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTiempo.Enabled = false;
            this.tboxTiempo.Location = new System.Drawing.Point(102, 125);
            this.tboxTiempo.Name = "tboxTiempo";
            this.tboxTiempo.ReadOnly = true;
            this.tboxTiempo.Size = new System.Drawing.Size(86, 29);
            this.tboxTiempo.TabIndex = 5;
            this.tboxTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(16, 127);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(80, 36);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo\n(segundos)";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxPuntaje
            // 
            this.tboxPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxPuntaje.Enabled = false;
            this.tboxPuntaje.Location = new System.Drawing.Point(79, 86);
            this.tboxPuntaje.Name = "tboxPuntaje";
            this.tboxPuntaje.ReadOnly = true;
            this.tboxPuntaje.Size = new System.Drawing.Size(109, 29);
            this.tboxPuntaje.TabIndex = 3;
            this.tboxPuntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(15, 89);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(58, 18);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxJugador
            // 
            this.tboxJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxJugador.Location = new System.Drawing.Point(17, 44);
            this.tboxJugador.Name = "tboxJugador";
            this.tboxJugador.Size = new System.Drawing.Size(171, 29);
            this.tboxJugador.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Jugador";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblFeedback);
            this.splitContainer2.Panel1.Controls.Add(this.lblNumeroJugador);
            this.splitContainer2.Panel1.Controls.Add(this.tbxPista3);
            this.splitContainer2.Panel1.Controls.Add(this.tbxPista2);
            this.splitContainer2.Panel1.Controls.Add(this.tbxPista1);
            this.splitContainer2.Panel1.Controls.Add(this.tbxDigito3);
            this.splitContainer2.Panel1.Controls.Add(this.tbxDigito2);
            this.splitContainer2.Panel1.Controls.Add(this.tbxDigito1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(450, 338);
            this.splitContainer2.SplitterDistance = 132;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblFeedback
            // 
            this.lblFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(323, 89);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(70, 18);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "Feedback";
            // 
            // lblNumeroJugador
            // 
            this.lblNumeroJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroJugador.AutoSize = true;
            this.lblNumeroJugador.Location = new System.Drawing.Point(323, 29);
            this.lblNumeroJugador.Name = "lblNumeroJugador";
            this.lblNumeroJugador.Size = new System.Drawing.Size(77, 18);
            this.lblNumeroJugador.TabIndex = 6;
            this.lblNumeroJugador.Text = "Tu número";
            // 
            // tbxPista3
            // 
            this.tbxPista3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPista3.Enabled = false;
            this.tbxPista3.Location = new System.Drawing.Point(214, 86);
            this.tbxPista3.Name = "tbxPista3";
            this.tbxPista3.ReadOnly = true;
            this.tbxPista3.Size = new System.Drawing.Size(80, 29);
            this.tbxPista3.TabIndex = 5;
            this.tbxPista3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPista2
            // 
            this.tbxPista2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPista2.Enabled = false;
            this.tbxPista2.Location = new System.Drawing.Point(118, 86);
            this.tbxPista2.Name = "tbxPista2";
            this.tbxPista2.ReadOnly = true;
            this.tbxPista2.Size = new System.Drawing.Size(80, 29);
            this.tbxPista2.TabIndex = 4;
            this.tbxPista2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPista1
            // 
            this.tbxPista1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPista1.Enabled = false;
            this.tbxPista1.Location = new System.Drawing.Point(18, 86);
            this.tbxPista1.Name = "tbxPista1";
            this.tbxPista1.ReadOnly = true;
            this.tbxPista1.Size = new System.Drawing.Size(80, 29);
            this.tbxPista1.TabIndex = 3;
            this.tbxPista1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDigito3
            // 
            this.tbxDigito3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDigito3.Enabled = false;
            this.tbxDigito3.Location = new System.Drawing.Point(214, 26);
            this.tbxDigito3.Name = "tbxDigito3";
            this.tbxDigito3.ReadOnly = true;
            this.tbxDigito3.Size = new System.Drawing.Size(80, 29);
            this.tbxDigito3.TabIndex = 2;
            this.tbxDigito3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDigito2
            // 
            this.tbxDigito2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDigito2.Enabled = false;
            this.tbxDigito2.Location = new System.Drawing.Point(118, 26);
            this.tbxDigito2.Name = "tbxDigito2";
            this.tbxDigito2.ReadOnly = true;
            this.tbxDigito2.Size = new System.Drawing.Size(80, 29);
            this.tbxDigito2.TabIndex = 1;
            this.tbxDigito2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDigito1
            // 
            this.tbxDigito1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDigito1.Enabled = false;
            this.tbxDigito1.Location = new System.Drawing.Point(18, 26);
            this.tbxDigito1.Name = "tbxDigito1";
            this.tbxDigito1.ReadOnly = true;
            this.tbxDigito1.Size = new System.Drawing.Size(80, 29);
            this.tbxDigito1.TabIndex = 0;
            this.tbxDigito1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnEnviar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 202);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(303, 153);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(144, 46);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.EnviarNumero_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Enabled = false;
            this.button0.Location = new System.Drawing.Point(153, 153);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(144, 46);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(3, 153);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 46);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(303, 103);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 44);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(153, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 44);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(3, 103);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 44);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(303, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 44);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(153, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(3, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(153, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PicoFermiBagelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 365);
            this.Controls.Add(this.panelFondo);
            this.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PicoFermiBagelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pico Fermi Bagel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbJugador;
        private System.Windows.Forms.TextBox txbJugador;
        private System.Windows.Forms.TextBox txbNumeroJugador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tboxJugador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbxDigito3;
        private System.Windows.Forms.TextBox tbxDigito2;
        private System.Windows.Forms.TextBox tbxDigito1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblNumeroJugador;
        private System.Windows.Forms.TextBox tbxPista3;
        private System.Windows.Forms.TextBox tbxPista2;
        private System.Windows.Forms.TextBox tbxPista1;
        private System.Windows.Forms.TextBox tboxPuntaje;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.TextBox tboxTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnSgteNumero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}