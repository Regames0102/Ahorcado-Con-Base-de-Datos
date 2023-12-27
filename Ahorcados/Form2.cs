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
    public partial class Form2 : Form
    {
        private int StringActual = 1;
        public Form2()
        {
            InitializeComponent();
            label1.Font = new Font("Yeseva One", 16);
            button1.Font = new Font("BlackChancery", 16, FontStyle.Bold);
            button2.Font = new Font("BlackChancery", 16, FontStyle.Bold);
            button3.Font = new Font("BlackChancery", 16, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StringActual==4)
            {
                StringActual = 1;
            }
            else
            {
            StringActual++;
            htp.Image = Image.FromFile($"..\\..\\..\\RecursosInstruc\\Comojugar{StringActual}.png");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(StringActual==1)
            {
                StringActual = 4;
            }
            else
            {
                StringActual--;
                htp.Image = Image.FromFile($"..\\..\\..\\RecursosInstruc\\Comojugar{StringActual}.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
