using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class Form4 : Form
    {
        char[] PalabrasAdivinadas, PalabraSeleccionada, Alfabeto;
        public string[] Categoria, Animales, Paises, Ciudades, Comida, Deportes;
        int oportunidades;
        String[] Palabras;
        int aciertos;
        int puntos;
        int partidasjug;
        string palabra;
        string cadenaconex;

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (categorias.SelectedItem == null)
            {
                MessageBox.Show("Tienes que seleccionar una categoria");
            }
            else
            {
                aciertos = 0;
                iniciarJuego();
            }

        }

        Boolean fin;
        int ganadas;
        int perdidas;

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        void cargardatoscombo() {
            using (MySqlConnection mycon = new MySqlConnection(cadenaconex))
            {
                mycon.Open();

                string consulta = "SELECT Categoria FROM Categorias";
                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas devueltas
                        if (reader.HasRows)
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            categorias.Items.Clear();

                            // Leer cada fila y agregar el valor al ComboBox
                            while (reader.Read())
                            {
                                // Supongamos que estás obteniendo un valor de una columna llamada "TuColumna"
                                string valor = reader[0].ToString();
                                categorias.Items.Add(valor);
                            }
                        }
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cargardatoscombo();
        }
        
        private void creararray(string categoria)
        {
            List<string> palabras = new List<string>();  // Usamos una lista para almacenar los valores dinámicamente

            using (MySqlConnection mycon = new MySqlConnection(cadenaconex))
            {
                mycon.Open();

                string consulta ="SELECT palabra FROM palabras WHERE categoria = @Categoria";
                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas devueltas
                        if (reader.HasRows)
                        {
                            // Leer cada fila y agregar el valor a la lista
                            while (reader.Read())
                            {
                                // Supongamos que estás obteniendo un valor de una columna llamada "TuColumna"
                                string valor = reader[0].ToString();
                                palabras.Add(valor);
                            }
                        }
                    }
                }
            }

            // Convertir la lista a un array si es necesario
            string[] arrayResultante = palabras.ToArray();
        }

        public Form4(string cadenaconex)
        {
            this.cadenaconex = cadenaconex;
            InitializeComponent();
            SeleccCat.Font = new Font("BlackChancery",20);
            categorias.Font = new Font("BlackChancery", 20);
            label1.Font = new Font("Berkshire Swash", 14);
            label2.Font = new Font("Berkshire Swash", 14);
            Puntuacion1.Font = new Font("Berkshire Swash", 14);
            Contpart.Font = new Font("Berkshire Swash", 14);
            groupBox1.Font = new Font("Berkshire Swash", 20);
            Jugar.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#850A0A");
            Reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#850A0A");
            Volver.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#850A0A");
            TermPart.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#850A0A");
            Jugar.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            Reiniciar.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            Volver.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            TermPart.Font = new Font("Yeseva One", 12, FontStyle.Bold);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            Animales = new String[] { "Gato", "Perro", "Serpiente", "Pajaro", "Lagarto", "Conejo", "Araña","Elefante", "León", "Tigre", "Jirafa", "Oso", "Rinoceronte", "Hipopótamo", "Zorro", "Koala", "Canguro", "Pato", "Caballo", "Cebra", "Nutria", "Delfín", "Ballena", "Ornitorrinco", "Gorila", "Chimpancé", "Pez payaso" };
            Paises = new String[] { "España", "Alemania", "Francia", "Estados Unidos", "Canada", "Argentina", "Mexico", "Italia", "China", "Japón", "Brasil", "Rusia", "India", "Australia" };
            Ciudades = new String[] { "Huelva", "Sevilla", "Madrid", "Barcelona", "Teruel", "Malaga", "Lugo", "Valencia", "Bilbao", "Zaragoza", "Granada", "Toledo", "Cádiz", "Santander" };
            Comida = new String[] { "Espagueti", "Pizza", "Hamburguesa", "Arroz", "Tortilla", "Asado", "Patatas", "Sushi", "Curry", "Ensalada", "Paella", "Ceviche", "Tacos", "Lasaña" };
            Deportes = new String[] { "Futbol", "Baloncesto", "Tenis", "Padel", "Badmington", "Rugby", "Baseball","Voleibol", "Atletismo", "Natación", "Hockey", "Golf", "Ciclismo", "Boxeo" };

        }
        public void iniciarJuego()
        {
            if (partidasjug == 3)
            {
                MessageBox.Show("Se han acabado las partidas \nHas ganado: " + ganadas + " partidas y has perdido: " + perdidas + " partidas");
                final();
            }
            else
            {
                Contpart.Text = partidasjug.ToString();
                Puntuacion1.Text = puntos.ToString();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                string categoriaElegida = categorias.SelectedItem.ToString();

                creararray(categoriaElegida);
                switch (categoriaElegida)
                {
                    case "Animales":
                        Palabras = Animales;
                        break;
                    case "Paises":
                        Palabras = Paises;
                        break;
                    case "Ciudades":
                        Palabras = Ciudades;
                        break;
                    case "Comida":
                        Palabras = Comida;
                        break;
                    case "Deportes":
                        Palabras = Deportes;
                        break;
                    default:
                        break;
                }
                categorias.Visible = false;
                SeleccCat.Visible = false;
                flFichasJuego.Size = new System.Drawing.Size(334, 244);
                flFichasJuego.Controls.Clear();
                flFichasJuego.Enabled = true;
                oportunidades = 0;
                Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();


                Random random = new Random();
                int indicePalabraSeleccionada = random.Next(0, Palabras.Length);
                PalabraSeleccionada = Palabras[indicePalabraSeleccionada].ToUpper().ToCharArray();
                palabra = Palabras[indicePalabraSeleccionada];
                PalabrasAdivinadas = PalabraSeleccionada;

                foreach (char Letra in Alfabeto)
                {

                    Button btn = new Button();
                    btn.Tag = "";
                    btn.Text = Letra.ToString();
                    btn.Width = 50;
                    btn.Height = 35;
                    btn.Click += compara;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Atma", 15, FontStyle.Bold);
                    btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#280003");
                    btn.Name = Letra.ToString();
                    flFichasJuego.Controls.Add(btn);
                  
                }
                flPalabra.Controls.Clear();

                for (int i = 0; i < PalabraSeleccionada.Length; i++)
                {
                    Button ltr = new Button();
                    ltr.Width = 46;
                    ltr.Height = 80;

                    ltr.ForeColor = System.Drawing.ColorTranslator.FromHtml("#30292F");
                    ltr.Text = "?";
                    ltr.Font = new Font("Atma", 32, FontStyle.Bold);
                    ltr.BackColor = Color.White;
                    ltr.Name = "Adivinado" + i.ToString();
                    flPalabra.Controls.Add(ltr);

                }
            }

        }
        void compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            Button btn1 = (Button)sender;
            btn1.BackColor = Color.White;
            btn1.ForeColor = Color.Black;
            btn1.Enabled = false;

            for (int i = 0; i < PalabrasAdivinadas.Length; i++)
            {
                if (PalabrasAdivinadas[i] == char.Parse(btn1.Text))
                {
                    Button btx = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    btx.Text = PalabrasAdivinadas[i].ToString();
                    encontrado = true;
                    aciertos++;
                    puntos = puntos + 2;
                    Puntuacion1.Text = puntos.ToString();
                    btn1.BackColor = Color.Green;
                }
            }

            bool ganaste = false;

            for (int f = 0; f < PalabrasAdivinadas.Length; f++)
            {
                if (aciertos == PalabrasAdivinadas.Length)
                {
                    ganaste = true;

                }
            }
            if (ganaste == true && fin == false)
            {
                puntos = puntos + 10;
                Puntuacion1.Text = puntos.ToString();
                MessageBox.Show("Ganaste ok, ok");
                partidasjug++;
                Contpart.Text = partidasjug.ToString();
                ganadas++;
                partidas();
            }
            if (!encontrado)
            {
                btn1.BackColor = Color.Red;
                oportunidades = oportunidades + 1;
                puntos = puntos - 1;
                Puntuacion1.Text = puntos.ToString();
                switch (oportunidades)
                {
                    case 1: pictureBox1.Visible = true; break;
                    case 2: pictureBox1.Visible = false; pictureBox2.Visible = true; break;
                    case 3: pictureBox2.Visible = false; pictureBox3.Visible = true; break;
                    case 4: pictureBox3.Visible = false; pictureBox4.Visible = true; break;
                    case 5: pictureBox4.Visible = false; pictureBox5.Visible = true; break;
                    case 6: pictureBox5.Visible = false; pictureBox6.Visible = true; break;
                    case 7: pictureBox6.Visible = false; pictureBox7.Visible = true; break;
                    case 8: pictureBox7.Visible = false; pictureBox8.Visible = true; break;
                }
                if (oportunidades == 8)
                {
                    MessageBox.Show("perdiste");
                    puntos = puntos - 5;
                    Puntuacion1.Text = puntos.ToString();
                    partidasjug++;
                    Contpart.Text = partidasjug.ToString();
                    perdidas++;
                    MessageBox.Show("La palabra era: "+ palabra);
                    partidas();

                }


            }
        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseas reiniciar con la misma categoria?", "Confirmacion", MessageBoxButtons.OKCancel);
            if (result==DialogResult.OK)
            {
                flFichasJuego.Controls.Clear();
                flPalabra.Controls.Clear();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                categorias.Visible = true;
                SeleccCat.Visible = true;
            }
            else
            {
                partidasjug = 0;
                puntos = 0;
                iniciarJuego();
            }
        }

        private void TermPart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se va a terminar la partida actual, ¿Estas Seguro de que quieres terminarla?", "Confirmacion", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                flFichasJuego.Controls.Clear();
                flPalabra.Controls.Clear();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                categorias.Visible = true;
                SeleccCat.Visible = true;
            }
        }
        private void partidas()
        {
            iniciarJuego();
            aciertos = 0;
            oportunidades = 0;
        }
        private void final()
        {
            flFichasJuego.Controls.Clear();
            flPalabra.Controls.Clear();
            flFichasJuego.Visible = false;
            SeleccCat.Visible = true;
            categorias.Visible = true;
            flPalabra.Visible = false;
        }
    }
}
