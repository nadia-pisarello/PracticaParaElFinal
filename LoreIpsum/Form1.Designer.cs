namespace LoreIpsum
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fondoPanel = new System.Windows.Forms.Panel();
            this.SplitContenedor = new System.Windows.Forms.SplitContainer();
            this.generarBtn = new System.Windows.Forms.Button();
            this.cantMaxPalabrasBox = new System.Windows.Forms.TextBox();
            this.cantiMaxPalabras = new System.Windows.Forms.Label();
            this.cantidadOracionesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantMinimaPalabrasBox = new System.Windows.Forms.TextBox();
            this.palabrasLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidadParrafosBox = new System.Windows.Forms.TextBox();
            this.cantidadPalabrasBox = new System.Windows.Forms.TextBox();
            this.textoDefectoOp = new System.Windows.Forms.CheckBox();
            this.parrafoOption = new System.Windows.Forms.RadioButton();
            this.palabraOption = new System.Windows.Forms.RadioButton();
            this.textoGeneradoBox = new System.Windows.Forms.TextBox();
            this.palabrasTotalLbl = new System.Windows.Forms.Label();
            this.totalPalabrasBox = new System.Windows.Forms.TextBox();
            this.fondoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContenedor)).BeginInit();
            this.SplitContenedor.Panel1.SuspendLayout();
            this.SplitContenedor.Panel2.SuspendLayout();
            this.SplitContenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondoPanel
            // 
            this.fondoPanel.Controls.Add(this.SplitContenedor);
            this.fondoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondoPanel.Location = new System.Drawing.Point(0, 0);
            this.fondoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fondoPanel.Name = "fondoPanel";
            this.fondoPanel.Size = new System.Drawing.Size(658, 434);
            this.fondoPanel.TabIndex = 0;
            // 
            // SplitContenedor
            // 
            this.SplitContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContenedor.Location = new System.Drawing.Point(0, 0);
            this.SplitContenedor.Name = "SplitContenedor";
            // 
            // SplitContenedor.Panel1
            // 
            this.SplitContenedor.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.SplitContenedor.Panel1.Controls.Add(this.generarBtn);
            this.SplitContenedor.Panel1.Controls.Add(this.cantMaxPalabrasBox);
            this.SplitContenedor.Panel1.Controls.Add(this.cantiMaxPalabras);
            this.SplitContenedor.Panel1.Controls.Add(this.cantidadOracionesBox);
            this.SplitContenedor.Panel1.Controls.Add(this.label1);
            this.SplitContenedor.Panel1.Controls.Add(this.cantMinimaPalabrasBox);
            this.SplitContenedor.Panel1.Controls.Add(this.palabrasLabel);
            this.SplitContenedor.Panel1.Controls.Add(this.groupBox1);
            // 
            // SplitContenedor.Panel2
            // 
            this.SplitContenedor.Panel2.Controls.Add(this.totalPalabrasBox);
            this.SplitContenedor.Panel2.Controls.Add(this.palabrasTotalLbl);
            this.SplitContenedor.Panel2.Controls.Add(this.textoGeneradoBox);
            this.SplitContenedor.Size = new System.Drawing.Size(658, 434);
            this.SplitContenedor.SplitterDistance = 282;
            this.SplitContenedor.TabIndex = 0;
            // 
            // generarBtn
            // 
            this.generarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generarBtn.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarBtn.Location = new System.Drawing.Point(92, 385);
            this.generarBtn.MaximumSize = new System.Drawing.Size(120, 35);
            this.generarBtn.Name = "generarBtn";
            this.generarBtn.Size = new System.Drawing.Size(120, 35);
            this.generarBtn.TabIndex = 7;
            this.generarBtn.Text = "Generar Texto";
            this.generarBtn.UseVisualStyleBackColor = true;
            this.generarBtn.Click += new System.EventHandler(this.generarBtn_Click);
            // 
            // cantMaxPalabrasBox
            // 
            this.cantMaxPalabrasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantMaxPalabrasBox.Enabled = false;
            this.cantMaxPalabrasBox.Location = new System.Drawing.Point(217, 256);
            this.cantMaxPalabrasBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.cantMaxPalabrasBox.Name = "cantMaxPalabrasBox";
            this.cantMaxPalabrasBox.Size = new System.Drawing.Size(40, 28);
            this.cantMaxPalabrasBox.TabIndex = 6;
            this.cantMaxPalabrasBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantiMaxPalabras
            // 
            this.cantiMaxPalabras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantiMaxPalabras.AutoSize = true;
            this.cantiMaxPalabras.Location = new System.Drawing.Point(23, 256);
            this.cantiMaxPalabras.MaximumSize = new System.Drawing.Size(175, 0);
            this.cantiMaxPalabras.Name = "cantiMaxPalabras";
            this.cantiMaxPalabras.Size = new System.Drawing.Size(174, 34);
            this.cantiMaxPalabras.TabIndex = 5;
            this.cantiMaxPalabras.Text = "Introducir cantidad máxima de palabras";
            // 
            // cantidadOracionesBox
            // 
            this.cantidadOracionesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadOracionesBox.Enabled = false;
            this.cantidadOracionesBox.Location = new System.Drawing.Point(217, 316);
            this.cantidadOracionesBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.cantidadOracionesBox.Name = "cantidadOracionesBox";
            this.cantidadOracionesBox.Size = new System.Drawing.Size(40, 28);
            this.cantidadOracionesBox.TabIndex = 4;
            this.cantidadOracionesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 319);
            this.label1.MaximumSize = new System.Drawing.Size(175, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introducir cantidad máxima de oraciones en el párrafos";
            // 
            // cantMinimaPalabrasBox
            // 
            this.cantMinimaPalabrasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantMinimaPalabrasBox.Enabled = false;
            this.cantMinimaPalabrasBox.Location = new System.Drawing.Point(217, 192);
            this.cantMinimaPalabrasBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.cantMinimaPalabrasBox.Name = "cantMinimaPalabrasBox";
            this.cantMinimaPalabrasBox.Size = new System.Drawing.Size(40, 28);
            this.cantMinimaPalabrasBox.TabIndex = 2;
            this.cantMinimaPalabrasBox.Text = "0";
            this.cantMinimaPalabrasBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // palabrasLabel
            // 
            this.palabrasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palabrasLabel.AutoSize = true;
            this.palabrasLabel.Location = new System.Drawing.Point(23, 192);
            this.palabrasLabel.MaximumSize = new System.Drawing.Size(175, 0);
            this.palabrasLabel.Name = "palabrasLabel";
            this.palabrasLabel.Size = new System.Drawing.Size(172, 34);
            this.palabrasLabel.TabIndex = 1;
            this.palabrasLabel.Text = "Introducir cantidad mínima de palabras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cantidadParrafosBox);
            this.groupBox1.Controls.Add(this.cantidadPalabrasBox);
            this.groupBox1.Controls.Add(this.textoDefectoOp);
            this.groupBox1.Controls.Add(this.parrafoOption);
            this.groupBox1.Controls.Add(this.palabraOption);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // cantidadParrafosBox
            // 
            this.cantidadParrafosBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadParrafosBox.Enabled = false;
            this.cantidadParrafosBox.Location = new System.Drawing.Point(196, 96);
            this.cantidadParrafosBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.cantidadParrafosBox.Name = "cantidadParrafosBox";
            this.cantidadParrafosBox.Size = new System.Drawing.Size(40, 28);
            this.cantidadParrafosBox.TabIndex = 7;
            this.cantidadParrafosBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidadPalabrasBox
            // 
            this.cantidadPalabrasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadPalabrasBox.Enabled = false;
            this.cantidadPalabrasBox.Location = new System.Drawing.Point(196, 60);
            this.cantidadPalabrasBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.cantidadPalabrasBox.Name = "cantidadPalabrasBox";
            this.cantidadPalabrasBox.Size = new System.Drawing.Size(40, 28);
            this.cantidadPalabrasBox.TabIndex = 6;
            this.cantidadPalabrasBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoDefectoOp
            // 
            this.textoDefectoOp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoDefectoOp.AutoSize = true;
            this.textoDefectoOp.Location = new System.Drawing.Point(10, 27);
            this.textoDefectoOp.MaximumSize = new System.Drawing.Size(275, 0);
            this.textoDefectoOp.Name = "textoDefectoOp";
            this.textoDefectoOp.Size = new System.Drawing.Size(258, 21);
            this.textoDefectoOp.TabIndex = 5;
            this.textoDefectoOp.Text = "Comenzar con Lorem ipsum dolor sit...";
            this.textoDefectoOp.UseVisualStyleBackColor = true;
            // 
            // parrafoOption
            // 
            this.parrafoOption.AutoSize = true;
            this.parrafoOption.Location = new System.Drawing.Point(9, 97);
            this.parrafoOption.Name = "parrafoOption";
            this.parrafoOption.Size = new System.Drawing.Size(154, 21);
            this.parrafoOption.TabIndex = 2;
            this.parrafoOption.Text = "Cantidad de párrafos";
            this.parrafoOption.UseVisualStyleBackColor = true;
            this.parrafoOption.Click += new System.EventHandler(this.Option_Click);
            // 
            // palabraOption
            // 
            this.palabraOption.AutoSize = true;
            this.palabraOption.Checked = true;
            this.palabraOption.Location = new System.Drawing.Point(10, 61);
            this.palabraOption.Name = "palabraOption";
            this.palabraOption.Size = new System.Drawing.Size(156, 21);
            this.palabraOption.TabIndex = 1;
            this.palabraOption.TabStop = true;
            this.palabraOption.Text = "Cantidad de palabras";
            this.palabraOption.UseVisualStyleBackColor = true;
            this.palabraOption.Click += new System.EventHandler(this.Option_Click);
            // 
            // textoGeneradoBox
            // 
            this.textoGeneradoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textoGeneradoBox.Location = new System.Drawing.Point(3, 3);
            this.textoGeneradoBox.Multiline = true;
            this.textoGeneradoBox.Name = "textoGeneradoBox";
            this.textoGeneradoBox.ReadOnly = true;
            this.textoGeneradoBox.Size = new System.Drawing.Size(368, 187);
            this.textoGeneradoBox.TabIndex = 0;
            // 
            // palabrasTotalLbl
            // 
            this.palabrasTotalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palabrasTotalLbl.AutoSize = true;
            this.palabrasTotalLbl.Location = new System.Drawing.Point(17, 223);
            this.palabrasTotalLbl.Name = "palabrasTotalLbl";
            this.palabrasTotalLbl.Size = new System.Drawing.Size(139, 17);
            this.palabrasTotalLbl.TabIndex = 1;
            this.palabrasTotalLbl.Text = "Cantidad de Palabras";
            this.palabrasTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPalabrasBox
            // 
            this.totalPalabrasBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPalabrasBox.Enabled = false;
            this.totalPalabrasBox.Location = new System.Drawing.Point(183, 220);
            this.totalPalabrasBox.MaximumSize = new System.Drawing.Size(40, 28);
            this.totalPalabrasBox.Name = "totalPalabrasBox";
            this.totalPalabrasBox.ReadOnly = true;
            this.totalPalabrasBox.Size = new System.Drawing.Size(40, 28);
            this.totalPalabrasBox.TabIndex = 7;
            this.totalPalabrasBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 434);
            this.Controls.Add(this.fondoPanel);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(674, 473);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fondoPanel.ResumeLayout(false);
            this.SplitContenedor.Panel1.ResumeLayout(false);
            this.SplitContenedor.Panel1.PerformLayout();
            this.SplitContenedor.Panel2.ResumeLayout(false);
            this.SplitContenedor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContenedor)).EndInit();
            this.SplitContenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fondoPanel;
        private System.Windows.Forms.SplitContainer SplitContenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoGeneradoBox;
        private System.Windows.Forms.RadioButton parrafoOption;
        private System.Windows.Forms.RadioButton palabraOption;
        private System.Windows.Forms.TextBox cantidadOracionesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantMinimaPalabrasBox;
        private System.Windows.Forms.Label palabrasLabel;
        private System.Windows.Forms.CheckBox textoDefectoOp;
        private System.Windows.Forms.TextBox cantMaxPalabrasBox;
        private System.Windows.Forms.Label cantiMaxPalabras;
        private System.Windows.Forms.Button generarBtn;
        private System.Windows.Forms.TextBox cantidadParrafosBox;
        private System.Windows.Forms.TextBox cantidadPalabrasBox;
        private System.Windows.Forms.TextBox totalPalabrasBox;
        private System.Windows.Forms.Label palabrasTotalLbl;
    }
}

