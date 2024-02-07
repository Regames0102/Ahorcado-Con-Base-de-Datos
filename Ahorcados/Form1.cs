using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ahorcados
{
    public partial class Form1 : Form
    {
        public MySqlConnection mycon;
        public string cadenaconex;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool conectar()
        {
            try
            {

                mycon = new MySqlConnection(cadenaconex);
                mycon.Open();
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Credenciales Incorrectas");
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string host = TXHost.Text;
            string user = TXUser.Text;
            string password = TXPass.Text;
            string bd = TXBD.Text;
            cadenaconex = "server=" + host + ";user id=" + user + ";password=" + password + ";database=" + bd + ";persistsecurityinfo=True";
            if (conectar())
            {
                Form2 administracion = new Form2(cadenaconex);
                administracion.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
