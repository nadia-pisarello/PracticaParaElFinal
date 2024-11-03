namespace PracticaParaElFinal.Ahorcado
{
    partial class AhorcadoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarPartida = new System.Windows.Forms.Button();
            this.lbCantidadPalabrasDescubiertas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMensajes = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lbpalabraOculta = new System.Windows.Forms.Label();
            this.letraElegida = new System.Windows.Forms.TextBox();
            this.tbPalabraUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadDeIntentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbJugador = new System.Windows.Forms.Label();
            this.tbxJugador = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxJugador);
            this.panel1.Controls.Add(this.lbJugador);
            this.panel1.Controls.Add(this.btnGuardarPartida);
            this.panel1.Controls.Add(this.lbCantidadPalabrasDescubiertas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbMensajes);
            this.panel1.Controls.Add(this.btnTerminar);
            this.panel1.Controls.Add(this.lbpalabraOculta);
            this.panel1.Controls.Add(this.letraElegida);
            this.panel1.Controls.Add(this.tbPalabraUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cantidadDeIntentos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 531);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardarPartida
            // 
            this.btnGuardarPartida.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPartida.Location = new System.Drawing.Point(627, 426);
            this.btnGuardarPartida.Name = "btnGuardarPartida";
            this.btnGuardarPartida.Size = new System.Drawing.Size(127, 89);
            this.btnGuardarPartida.TabIndex = 14;
            this.btnGuardarPartida.Text = "Guardar Partida";
            this.btnGuardarPartida.UseVisualStyleBackColor = true;
            this.btnGuardarPartida.Click += new System.EventHandler(this.btnGuardarPartida_Click);
            // 
            // lbCantidadPalabrasDescubiertas
            // 
            this.lbCantidadPalabrasDescubiertas.AutoSize = true;
            this.lbCantidadPalabrasDescubiertas.BackColor = System.Drawing.SystemColors.Menu;
            this.lbCantidadPalabrasDescubiertas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCantidadPalabrasDescubiertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadPalabrasDescubiertas.Location = new System.Drawing.Point(436, 104);
            this.lbCantidadPalabrasDescubiertas.Name = "lbCantidadPalabrasDescubiertas";
            this.lbCantidadPalabrasDescubiertas.Size = new System.Drawing.Size(37, 39);
            this.lbCantidadPalabrasDescubiertas.TabIndex = 13;
            this.lbCantidadPalabrasDescubiertas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad de Palabras Descubiertas";
            // 
            // lbMensajes
            // 
            this.lbMensajes.AutoSize = true;
            this.lbMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajes.Location = new System.Drawing.Point(48, 426);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(0, 29);
            this.lbMensajes.TabIndex = 11;
            this.lbMensajes.Visible = false;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(179, 25);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(130, 48);
            this.btnTerminar.TabIndex = 10;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // lbpalabraOculta
            // 
            this.lbpalabraOculta.AutoSize = true;
            this.lbpalabraOculta.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpalabraOculta.Location = new System.Drawing.Point(238, 186);
            this.lbpalabraOculta.Name = "lbpalabraOculta";
            this.lbpalabraOculta.Size = new System.Drawing.Size(0, 31);
            this.lbpalabraOculta.TabIndex = 9;
            // 
            // letraElegida
            // 
            this.letraElegida.Enabled = false;
            this.letraElegida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.letraElegida.Location = new System.Drawing.Point(335, 366);
            this.letraElegida.Name = "letraElegida";
            this.letraElegida.Size = new System.Drawing.Size(123, 35);
            this.letraElegida.TabIndex = 8;
            this.letraElegida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letraElegida.TextChanged += new System.EventHandler(this.letraElegida_TextChanged);
            // 
            // tbPalabraUsuario
            // 
            this.tbPalabraUsuario.Enabled = false;
            this.tbPalabraUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPalabraUsuario.Location = new System.Drawing.Point(22, 300);
            this.tbPalabraUsuario.Name = "tbPalabraUsuario";
            this.tbPalabraUsuario.Size = new System.Drawing.Size(469, 35);
            this.tbPalabraUsuario.TabIndex = 7;
            this.tbPalabraUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPalabraUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPalabraUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingresa la palabra oculta aquí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresa tu letra elegida aquí:";
            // 
            // cantidadDeIntentos
            // 
            this.cantidadDeIntentos.AutoSize = true;
            this.cantidadDeIntentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cantidadDeIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadDeIntentos.Location = new System.Drawing.Point(627, 104);
            this.cantidadDeIntentos.Name = "cantidadDeIntentos";
            this.cantidadDeIntentos.Size = new System.Drawing.Size(37, 39);
            this.cantidadDeIntentos.TabIndex = 2;
            this.cantidadDeIntentos.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(524, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intentos";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(22, 25);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 48);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbJugador
            // 
            this.lbJugador.AutoSize = true;
            this.lbJugador.BackColor = System.Drawing.SystemColors.Menu;
            this.lbJugador.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugador.Location = new System.Drawing.Point(389, 36);
            this.lbJugador.Name = "lbJugador";
            this.lbJugador.Size = new System.Drawing.Size(84, 26);
            this.lbJugador.TabIndex = 15;
            this.lbJugador.Text = "Jugador";
            // 
            // tbxJugador
            // 
            this.tbxJugador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxJugador.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxJugador.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxJugador.Location = new System.Drawing.Point(479, 25);
            this.tbxJugador.Name = "tbxJugador";
            this.tbxJugador.Size = new System.Drawing.Size(278, 46);
            this.tbxJugador.TabIndex = 16;
            this.tbxJugador.Text = "Ingresa tu nombre...";
            this.tbxJugador.TextChanged += new System.EventHandler(this.tbxJugador_TextChanged);
            // 
            // AhorcadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 531);
            this.Controls.Add(this.panel1);
            this.Name = "AhorcadoForm";
            this.Text = "Ahorcado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cantidadDeIntentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPalabraUsuario;
        private System.Windows.Forms.TextBox letraElegida;
        private System.Windows.Forms.Label lbpalabraOculta;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lbMensajes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbCantidadPalabrasDescubiertas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarPartida;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbxJugador;
        private System.Windows.Forms.Label lbJugador;
    }
}