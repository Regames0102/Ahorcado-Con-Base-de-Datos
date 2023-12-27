namespace Ahorcados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jugar = new System.Windows.Forms.Button();
            this.instr = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jugar
            // 
            this.jugar.BackColor = System.Drawing.Color.Transparent;
            this.jugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar.Location = new System.Drawing.Point(313, 105);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(153, 56);
            this.jugar.TabIndex = 0;
            this.jugar.Text = "Empezar";
            this.jugar.UseVisualStyleBackColor = false;
            this.jugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // instr
            // 
            this.instr.BackColor = System.Drawing.Color.Transparent;
            this.instr.FlatAppearance.BorderSize = 2;
            this.instr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instr.Location = new System.Drawing.Point(313, 218);
            this.instr.Name = "instr";
            this.instr.Size = new System.Drawing.Size(153, 55);
            this.instr.TabIndex = 2;
            this.instr.Text = "Instrucciones";
            this.instr.UseVisualStyleBackColor = false;
            this.instr.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(313, 332);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(153, 55);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 40.25F);
            this.label1.Location = new System.Drawing.Point(223, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "El Ahorcado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.instr);
            this.Controls.Add(this.jugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button instr;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
    }
}

