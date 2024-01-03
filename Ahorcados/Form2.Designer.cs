namespace Ahorcados
{
    partial class Form2
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
            System.Windows.Forms.Label label7;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CrearCuenta = new System.Windows.Forms.Label();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCanc = new System.Windows.Forms.Button();
            this.TXUsu = new System.Windows.Forms.TextBox();
            this.TXPass = new System.Windows.Forms.TextBox();
            this.ErrorUsu = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.admin = new System.Windows.Forms.CheckBox();
            this.InfoLogin = new System.Windows.Forms.GroupBox();
            this.ActualizarJugadores = new System.Windows.Forms.Button();
            this.ActualizarPalabras = new System.Windows.Forms.Button();
            this.ActualizarCategoria = new System.Windows.Forms.Button();
            this.partperd = new System.Windows.Forms.Label();
            this.partgan = new System.Windows.Forms.Label();
            this.partjug = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.BorrarDatos = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.InfoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            label7.Location = new System.Drawing.Point(17, 189);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(377, 47);
            label7.TabIndex = 2;
            label7.Text = "Partidas ganadas =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.label1.Location = new System.Drawing.Point(244, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(219, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Eres nuevo?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(232, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(279, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // CrearCuenta
            // 
            this.CrearCuenta.AutoSize = true;
            this.CrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CrearCuenta.Location = new System.Drawing.Point(407, 335);
            this.CrearCuenta.Name = "CrearCuenta";
            this.CrearCuenta.Size = new System.Drawing.Size(279, 39);
            this.CrearCuenta.TabIndex = 4;
            this.CrearCuenta.Text = "Crear una cuenta";
            this.CrearCuenta.Click += new System.EventHandler(this.CrearCuenta_Click);
            this.CrearCuenta.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.CrearCuenta.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.BTNAceptar.Location = new System.Drawing.Point(213, 382);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(161, 79);
            this.BTNAceptar.TabIndex = 5;
            this.BTNAceptar.Text = "Iniciar Sesion";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCanc
            // 
            this.BTNCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.BTNCanc.Location = new System.Drawing.Point(460, 382);
            this.BTNCanc.Name = "BTNCanc";
            this.BTNCanc.Size = new System.Drawing.Size(170, 79);
            this.BTNCanc.TabIndex = 6;
            this.BTNCanc.Text = "Cancelar";
            this.BTNCanc.UseVisualStyleBackColor = true;
            this.BTNCanc.Click += new System.EventHandler(this.BTNCanc_Click);
            // 
            // TXUsu
            // 
            this.TXUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TXUsu.Location = new System.Drawing.Point(413, 196);
            this.TXUsu.Name = "TXUsu";
            this.TXUsu.Size = new System.Drawing.Size(203, 42);
            this.TXUsu.TabIndex = 7;
            // 
            // TXPass
            // 
            this.TXPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TXPass.Location = new System.Drawing.Point(413, 251);
            this.TXPass.Name = "TXPass";
            this.TXPass.Size = new System.Drawing.Size(203, 42);
            this.TXPass.TabIndex = 8;
            // 
            // ErrorUsu
            // 
            this.ErrorUsu.AutoSize = true;
            this.ErrorUsu.CausesValidation = false;
            this.ErrorUsu.ForeColor = System.Drawing.Color.Red;
            this.ErrorUsu.Location = new System.Drawing.Point(622, 209);
            this.ErrorUsu.Name = "ErrorUsu";
            this.ErrorUsu.Size = new System.Drawing.Size(117, 15);
            this.ErrorUsu.TabIndex = 9;
            this.ErrorUsu.Text = "Ya existe un usuario";
            this.ErrorUsu.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.admin.Location = new System.Drawing.Point(450, 302);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(213, 36);
            this.admin.TabIndex = 11;
            this.admin.Text = "Administrador";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Visible = false;
            // 
            // InfoLogin
            // 
            this.InfoLogin.BackColor = System.Drawing.Color.Transparent;
            this.InfoLogin.Controls.Add(this.ActualizarJugadores);
            this.InfoLogin.Controls.Add(this.ActualizarPalabras);
            this.InfoLogin.Controls.Add(this.ActualizarCategoria);
            this.InfoLogin.Controls.Add(this.partperd);
            this.InfoLogin.Controls.Add(this.partgan);
            this.InfoLogin.Controls.Add(this.partjug);
            this.InfoLogin.Controls.Add(this.puntos);
            this.InfoLogin.Controls.Add(this.CerrarSesion);
            this.InfoLogin.Controls.Add(this.BorrarDatos);
            this.InfoLogin.Controls.Add(this.Jugar);
            this.InfoLogin.Controls.Add(this.label8);
            this.InfoLogin.Controls.Add(label7);
            this.InfoLogin.Controls.Add(this.label6);
            this.InfoLogin.Controls.Add(this.label5);
            this.InfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.InfoLogin.Location = new System.Drawing.Point(116, 65);
            this.InfoLogin.Name = "InfoLogin";
            this.InfoLogin.Size = new System.Drawing.Size(661, 478);
            this.InfoLogin.TabIndex = 12;
            this.InfoLogin.TabStop = false;
            this.InfoLogin.Text = "Informacion del perfil";
            this.InfoLogin.Visible = false;
            // 
            // ActualizarJugadores
            // 
            this.ActualizarJugadores.Location = new System.Drawing.Point(433, 501);
            this.ActualizarJugadores.Name = "ActualizarJugadores";
            this.ActualizarJugadores.Size = new System.Drawing.Size(185, 125);
            this.ActualizarJugadores.TabIndex = 13;
            this.ActualizarJugadores.Text = "Actualizar Jugadores";
            this.ActualizarJugadores.UseVisualStyleBackColor = true;
            // 
            // ActualizarPalabras
            // 
            this.ActualizarPalabras.Location = new System.Drawing.Point(233, 501);
            this.ActualizarPalabras.Name = "ActualizarPalabras";
            this.ActualizarPalabras.Size = new System.Drawing.Size(185, 125);
            this.ActualizarPalabras.TabIndex = 12;
            this.ActualizarPalabras.Text = "Actualizar Palabras";
            this.ActualizarPalabras.UseVisualStyleBackColor = true;
            // 
            // ActualizarCategoria
            // 
            this.ActualizarCategoria.Location = new System.Drawing.Point(35, 501);
            this.ActualizarCategoria.Name = "ActualizarCategoria";
            this.ActualizarCategoria.Size = new System.Drawing.Size(182, 125);
            this.ActualizarCategoria.TabIndex = 11;
            this.ActualizarCategoria.Text = "Actualizar Categoria";
            this.ActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // partperd
            // 
            this.partperd.AutoSize = true;
            this.partperd.Location = new System.Drawing.Point(393, 252);
            this.partperd.Name = "partperd";
            this.partperd.Size = new System.Drawing.Size(66, 47);
            this.partperd.TabIndex = 10;
            this.partperd.Text = "23";
            // 
            // partgan
            // 
            this.partgan.AutoSize = true;
            this.partgan.Location = new System.Drawing.Point(393, 189);
            this.partgan.Name = "partgan";
            this.partgan.Size = new System.Drawing.Size(66, 47);
            this.partgan.TabIndex = 9;
            this.partgan.Text = "19";
            // 
            // partjug
            // 
            this.partjug.AutoSize = true;
            this.partjug.Location = new System.Drawing.Point(393, 126);
            this.partjug.Name = "partjug";
            this.partjug.Size = new System.Drawing.Size(66, 47);
            this.partjug.TabIndex = 8;
            this.partjug.Text = "24";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(393, 69);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(66, 47);
            this.puntos.TabIndex = 7;
            this.puntos.Text = "15";
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(433, 338);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(185, 125);
            this.CerrarSesion.TabIndex = 6;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // BorrarDatos
            // 
            this.BorrarDatos.Location = new System.Drawing.Point(233, 338);
            this.BorrarDatos.Name = "BorrarDatos";
            this.BorrarDatos.Size = new System.Drawing.Size(185, 125);
            this.BorrarDatos.TabIndex = 5;
            this.BorrarDatos.Text = "Borrar Datos";
            this.BorrarDatos.UseVisualStyleBackColor = true;
            this.BorrarDatos.Click += new System.EventHandler(this.BorrarDatos_Click);
            // 
            // Jugar
            // 
            this.Jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.Jugar.Location = new System.Drawing.Point(35, 337);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(182, 126);
            this.Jugar.TabIndex = 4;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label8.Location = new System.Drawing.Point(17, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 47);
            this.label8.TabIndex = 3;
            this.label8.Text = "Partidas perdidas =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label6.Location = new System.Drawing.Point(28, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 47);
            this.label6.TabIndex = 1;
            this.label6.Text = "Partidas jugadas =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label5.Location = new System.Drawing.Point(102, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Puntuacion =";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(939, 751);
            this.Controls.Add(this.InfoLogin);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.ErrorUsu);
            this.Controls.Add(this.TXPass);
            this.Controls.Add(this.TXUsu);
            this.Controls.Add(this.BTNCanc);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.CrearCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.InfoLogin.ResumeLayout(false);
            this.InfoLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CrearCuenta;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCanc;
        private System.Windows.Forms.TextBox TXUsu;
        private System.Windows.Forms.TextBox TXPass;
        private System.Windows.Forms.Label ErrorUsu;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.GroupBox InfoLogin;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button BorrarDatos;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label partperd;
        private System.Windows.Forms.Label partgan;
        private System.Windows.Forms.Label partjug;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Button ActualizarJugadores;
        private System.Windows.Forms.Button ActualizarPalabras;
        private System.Windows.Forms.Button ActualizarCategoria;
    }
}