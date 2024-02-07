namespace Ahorcados
{
    partial class Form3
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.añadirObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Location = new System.Drawing.Point(139, 101);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(498, 275);
            this.DG.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirObjetoToolStripMenuItem,
            this.editarObjetoToolStripMenuItem,
            this.borrarObjetoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // añadirObjetoToolStripMenuItem
            // 
            this.añadirObjetoToolStripMenuItem.Name = "añadirObjetoToolStripMenuItem";
            this.añadirObjetoToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.añadirObjetoToolStripMenuItem.Text = "Añadir objeto";
            this.añadirObjetoToolStripMenuItem.Click += new System.EventHandler(this.añadirObjetoToolStripMenuItem_Click);
            // 
            // editarObjetoToolStripMenuItem
            // 
            this.editarObjetoToolStripMenuItem.Name = "editarObjetoToolStripMenuItem";
            this.editarObjetoToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.editarObjetoToolStripMenuItem.Text = "Editar Objeto";
            this.editarObjetoToolStripMenuItem.Click += new System.EventHandler(this.editarObjetoToolStripMenuItem_Click);
            // 
            // borrarObjetoToolStripMenuItem
            // 
            this.borrarObjetoToolStripMenuItem.Name = "borrarObjetoToolStripMenuItem";
            this.borrarObjetoToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.borrarObjetoToolStripMenuItem.Text = "Borrar Objeto";
            this.borrarObjetoToolStripMenuItem.Click += new System.EventHandler(this.borrarObjetoToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DG;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem añadirObjetoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editarObjetoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem borrarObjetoToolStripMenuItem;
    }
}