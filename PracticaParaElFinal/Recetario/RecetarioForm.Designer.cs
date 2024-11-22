namespace PracticaParaElFinal.Recetario
{
    partial class RecetarioForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRecetas = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRecetas);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 305);
            this.panel1.TabIndex = 0;
            // 
            // dgvRecetas
            // 
            this.dgvRecetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecetas.Location = new System.Drawing.Point(0, 24);
            this.dgvRecetas.Name = "dgvRecetas";
            this.dgvRecetas.Size = new System.Drawing.Size(652, 281);
            this.dgvRecetas.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenu,
            this.categoríaMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(652, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // archivoMenu
            // 
            this.archivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivo,
            this.cerrarArchivo});
            this.archivoMenu.Name = "archivoMenu";
            this.archivoMenu.Size = new System.Drawing.Size(60, 20);
            this.archivoMenu.Text = "Archivo";
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivo.Text = "Abrir";
            this.abrirArchivo.Click += new System.EventHandler(this.AbrirArchivo_Click);
            // 
            // cerrarArchivo
            // 
            this.cerrarArchivo.Name = "cerrarArchivo";
            this.cerrarArchivo.Size = new System.Drawing.Size(180, 22);
            this.cerrarArchivo.Text = "Cerrar";
            this.cerrarArchivo.Click += new System.EventHandler(this.cerrarArchivo_Click);
            // 
            // categoríaMenu
            // 
            this.categoríaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.categoríaMenu.Enabled = false;
            this.categoríaMenu.Name = "categoríaMenu";
            this.categoríaMenu.Size = new System.Drawing.Size(70, 20);
            this.categoríaMenu.Text = "Categoría";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bebidasToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.principalesToolStripMenuItem,
            this.postresToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // bebidasToolStripMenuItem
            // 
            this.bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            this.bebidasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.bebidasToolStripMenuItem.Text = "Bebidas";
            this.bebidasToolStripMenuItem.Click += new System.EventHandler(this.VerCategoria_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.VerCategoria_Click);
            // 
            // principalesToolStripMenuItem
            // 
            this.principalesToolStripMenuItem.Name = "principalesToolStripMenuItem";
            this.principalesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.principalesToolStripMenuItem.Text = "Principales";
            this.principalesToolStripMenuItem.Click += new System.EventHandler(this.VerCategoria_Click);
            // 
            // postresToolStripMenuItem
            // 
            this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
            this.postresToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.postresToolStripMenuItem.Text = "Postres";
            this.postresToolStripMenuItem.Click += new System.EventHandler(this.VerCategoria_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RecetarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 305);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetarioForm";
            this.Text = "Recetario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivo;
        private System.Windows.Forms.ToolStripMenuItem cerrarArchivo;
        private System.Windows.Forms.ToolStripMenuItem categoríaMenu;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvRecetas;
    }
}