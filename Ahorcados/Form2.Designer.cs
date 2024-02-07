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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ActualizarJugadores = new System.Windows.Forms.Button();
            this.ActualizarPalabras = new System.Windows.Forms.Button();
            this.ActualizarCategoria = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.Jugar = new System.Windows.Forms.Button();
            this.InfoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.label1.Location = new System.Drawing.Point(325, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(292, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Eres nuevo?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(309, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(372, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // CrearCuenta
            // 
            this.CrearCuenta.AutoSize = true;
            this.CrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CrearCuenta.Location = new System.Drawing.Point(543, 412);
            this.CrearCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.BTNAceptar.Location = new System.Drawing.Point(284, 470);
            this.BTNAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(215, 97);
            this.BTNAceptar.TabIndex = 5;
            this.BTNAceptar.Text = "Iniciar Sesion";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCanc
            // 
            this.BTNCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.BTNCanc.Location = new System.Drawing.Point(613, 470);
            this.BTNCanc.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCanc.Name = "BTNCanc";
            this.BTNCanc.Size = new System.Drawing.Size(227, 97);
            this.BTNCanc.TabIndex = 6;
            this.BTNCanc.Text = "Cancelar";
            this.BTNCanc.UseVisualStyleBackColor = true;
            this.BTNCanc.Click += new System.EventHandler(this.BTNCanc_Click);
            // 
            // TXUsu
            // 
            this.TXUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TXUsu.Location = new System.Drawing.Point(551, 241);
            this.TXUsu.Margin = new System.Windows.Forms.Padding(4);
            this.TXUsu.Name = "TXUsu";
            this.TXUsu.Size = new System.Drawing.Size(269, 42);
            this.TXUsu.TabIndex = 7;
            // 
            // TXPass
            // 
            this.TXPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TXPass.Location = new System.Drawing.Point(551, 309);
            this.TXPass.Margin = new System.Windows.Forms.Padding(4);
            this.TXPass.Name = "TXPass";
            this.TXPass.Size = new System.Drawing.Size(269, 42);
            this.TXPass.TabIndex = 8;
            // 
            // ErrorUsu
            // 
            this.ErrorUsu.AutoSize = true;
            this.ErrorUsu.CausesValidation = false;
            this.ErrorUsu.ForeColor = System.Drawing.Color.Red;
            this.ErrorUsu.Location = new System.Drawing.Point(829, 257);
            this.ErrorUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorUsu.Name = "ErrorUsu";
            this.ErrorUsu.Size = new System.Drawing.Size(136, 17);
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
            this.admin.Location = new System.Drawing.Point(600, 372);
            this.admin.Margin = new System.Windows.Forms.Padding(4);
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
            this.InfoLogin.Controls.Add(this.dataGridView1);
            this.InfoLogin.Controls.Add(this.button1);
            this.InfoLogin.Controls.Add(this.label5);
            this.InfoLogin.Controls.Add(this.ActualizarJugadores);
            this.InfoLogin.Controls.Add(this.ActualizarPalabras);
            this.InfoLogin.Controls.Add(this.ActualizarCategoria);
            this.InfoLogin.Controls.Add(this.CerrarSesion);
            this.InfoLogin.Controls.Add(this.Jugar);
            this.InfoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.InfoLogin.Location = new System.Drawing.Point(156, 32);
            this.InfoLogin.Margin = new System.Windows.Forms.Padding(4);
            this.InfoLogin.Name = "InfoLogin";
            this.InfoLogin.Padding = new System.Windows.Forms.Padding(4);
            this.InfoLogin.Size = new System.Drawing.Size(881, 719);
            this.InfoLogin.TabIndex = 12;
            this.InfoLogin.TabStop = false;
            this.InfoLogin.Text = "Informacion del perfil";
            this.InfoLogin.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 274);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.button1.Location = new System.Drawing.Point(577, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 160);
            this.button1.TabIndex = 16;
            this.button1.Text = "Configuracion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label5.Location = new System.Drawing.Point(135, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 47);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bienvenido al Ahorcado jugador";
            // 
            // ActualizarJugadores
            // 
            this.ActualizarJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ActualizarJugadores.Location = new System.Drawing.Point(577, 559);
            this.ActualizarJugadores.Margin = new System.Windows.Forms.Padding(4);
            this.ActualizarJugadores.Name = "ActualizarJugadores";
            this.ActualizarJugadores.Size = new System.Drawing.Size(247, 154);
            this.ActualizarJugadores.TabIndex = 13;
            this.ActualizarJugadores.Text = "Actualizar Jugadores";
            this.ActualizarJugadores.UseVisualStyleBackColor = true;
            this.ActualizarJugadores.Click += new System.EventHandler(this.ActualizarJugadores_Click);
            // 
            // ActualizarPalabras
            // 
            this.ActualizarPalabras.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ActualizarPalabras.Location = new System.Drawing.Point(311, 559);
            this.ActualizarPalabras.Margin = new System.Windows.Forms.Padding(4);
            this.ActualizarPalabras.Name = "ActualizarPalabras";
            this.ActualizarPalabras.Size = new System.Drawing.Size(247, 154);
            this.ActualizarPalabras.TabIndex = 12;
            this.ActualizarPalabras.Text = "Actualizar Palabras";
            this.ActualizarPalabras.UseVisualStyleBackColor = true;
            this.ActualizarPalabras.Click += new System.EventHandler(this.ActualizarPalabras_Click);
            // 
            // ActualizarCategoria
            // 
            this.ActualizarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ActualizarCategoria.Image = global::Ahorcados.Properties.Resources.aplicacion;
            this.ActualizarCategoria.Location = new System.Drawing.Point(47, 559);
            this.ActualizarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.ActualizarCategoria.Name = "ActualizarCategoria";
            this.ActualizarCategoria.Size = new System.Drawing.Size(243, 154);
            this.ActualizarCategoria.TabIndex = 11;
            this.ActualizarCategoria.UseVisualStyleBackColor = true;
            this.ActualizarCategoria.Click += new System.EventHandler(this.ActualizarCategoria_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.CerrarSesion.Location = new System.Drawing.Point(311, 396);
            this.CerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(247, 154);
            this.CerrarSesion.TabIndex = 6;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Jugar
            // 
            this.Jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.Jugar.Location = new System.Drawing.Point(47, 396);
            this.Jugar.Margin = new System.Windows.Forms.Padding(4);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(243, 155);
            this.Jugar.TabIndex = 4;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1218, 773);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.InfoLogin.ResumeLayout(false);
            this.InfoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button ActualizarJugadores;
        private System.Windows.Forms.Button ActualizarPalabras;
        private System.Windows.Forms.Button ActualizarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}