using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class Form1 : Form
    {

        Form2 formulario = new Form2();
        Form3 form3 = new Form3();
        public static Form4 form4 = new Form4();
        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font("Yeseva One", 40);
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#9A381D");
            jugar.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            instr.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            salir.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            jugar.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#B84300");
            instr.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#B84300");
            salir.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#B84300");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            formulario.Show();
            this.Hide();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            formulario.Close();
            form3.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
