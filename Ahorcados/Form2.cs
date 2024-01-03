using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ahorcados
{
    public partial class Form2 : Form
    {
        bool cuentanueva = false;
        public string cadenaconex;
        public MySqlConnection mycon;
        int ADMIN = 0;
        public Form2(string cadenaconex)
        {
            InitializeComponent();
            this.cadenaconex = cadenaconex;

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

                MessageBox.Show("Error a la hora de conectarse a la base de datos");
                return false;
            }
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            CrearCuenta.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000FF");
            Font subrayadoFont = new Font(CrearCuenta.Font, FontStyle.Underline);

            // Asigna el nuevo objeto Font al Label
            CrearCuenta.Font = subrayadoFont;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            CrearCuenta.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000000");
            Font subrayadoFont = new Font(CrearCuenta.Font, FontStyle.Regular);

            // Asigna el nuevo objeto Font al Label
            CrearCuenta.Font = subrayadoFont;

        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            cuentanueva = true;
            label1.Text = "Creacion de Cuenta";
            BTNAceptar.Text = "Crear Cuenta";
            admin.Visible = true;
            BTNCanc.Text = "Volver al Inicio de Sesion";
            this.BackColor = Color.LightSlateGray;
            label1.Location = new System.Drawing.Point(230,69);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conectar();
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        
        {
            if (TXUsu.Text.Equals("") || TXPass.Text.Equals(""))
            {

            }
            else
            {
                string usuario = TXUsu.Text;
                string contraseña = TXPass.Text;
                bool admini = false;
                if (admin.Checked == true)
                {
                    admini = true;
                }
                if (cuentanueva == true)
                {
                    if (VerificarExistenciaUsuario(cadenaconex, usuario) == true)
                    {
                        ErrorUsu.Visible = true;
                    }
                    else
                    {
                        ErrorUsu.Visible = false;
                        AgregarNuevoUsuario(usuario, contraseña, admini);
                        InfoLogin.Visible = true;
                    }
                }
                else
                {
                    if (login(usuario, contraseña))
                    {
                        mostrarinforlogin(usuario,ADMIN);
                        InfoLogin.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseñas incorrectos");
                    }
                }
            }
        }
        void mostrarinforlogin(string usuario, int admin)
        {
            using (MySqlConnection mycon = new MySqlConnection(cadenaconex))
            {
                mycon.Open();  // Abre la conexión

                // Consulta SQL para verificar la existencia del usuario
                string consulta = "SELECT Puntuacion, PartidasJugadas, PartidasGanadas, PartidasPerdidas from informacion where Jugador = @nombreUsuario ";

                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    // Parámetro para el nombre de usuario
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas devueltas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Obtener los valores de las columnas
                                int puntuacion = reader.GetInt32(0);
                                int partidasJugadas = reader.GetInt32(1);
                                int partidasGanadas = reader.GetInt32(2);
                                int partidasPerdidas = reader.GetInt32(3);

                                // Mostrar la información (puedes adaptar esto según tus necesidades)
                                puntos.Text = puntuacion.ToString();
                                partjug.Text = partidasJugadas.ToString();
                                partgan.Text = partidasGanadas.ToString();
                                partperd.Text = partidasPerdidas.ToString();

                                if (admin==1)
                                {
                                    InfoLogin.Size = new System.Drawing.Size(661, 632);

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El usuario no existe en la base de datos.");
                        }

                    }
                }
            }
        }
        void AgregarNuevoUsuario(string usuario, string contraseña,bool admin)
        {
            int administrador=0;
            if (admin==true)
            {
                administrador = 1;
            }
                // Abrir la conexión
                // Consulta SQL para insertar un nuevo usuario
                string consulta = "INSERT INTO usuarios (Usuario, Contraseña, Admin) VALUES (@nuevoUsuario,@contraseña,@admin)";

                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    // Parámetro para el nuevo nombre de usuario
                    command.Parameters.AddWithValue("@nuevoUsuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@admin", administrador);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }
        }
        public bool login(string usuario, string contraseña)
        {
            using (MySqlConnection mycon = new MySqlConnection(cadenaconex))
            {
                mycon.Open();  // Abre la conexión

                // Consulta SQL para verificar la existencia del usuario
                string consulta = "SELECT COUNT(*), Admin FROM usuarios WHERE Usuario = @nombreUsuario and Contraseña = @contraseña";

                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    // Parámetro para el nombre de usuario
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    // Ejecutar la consulta y obtener el resultado
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas devueltas
                        if (reader.Read())
                        {
                            // Obtener el número de filas y el valor adicional
                            int count = reader.GetInt32(0);
                            int otroValor = reader.GetInt32(1); // Ajusta el índice según la posición de tu columna en la consulta
                            if (otroValor>0)
                            {
                                ADMIN = 1;
                            }
                            if (count>0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

       public bool VerificarExistenciaUsuario(string connectionString, string nombreUsuario)
        {
            using (MySqlConnection mycon = new MySqlConnection(connectionString))
            {
                mycon.Open();  // Abre la conexión

                // Consulta SQL para verificar la existencia del usuario
                string consulta = "SELECT COUNT(*) FROM usuarios WHERE Usuario = @nombreUsuario";

                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    // Parámetro para el nombre de usuario
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    // Ejecutar la consulta y obtener el resultado
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Si el resultado es mayor que cero, el usuario existe
                    if (count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void BTNCanc_Click(object sender, EventArgs e)
        {
            if (cuentanueva==true)
            {
                this.BackColor = Color.White;
                label1.Text = "Inicio de Sesion";
                BTNAceptar.Text = "Iniciar Sesion";
                BTNCanc.Text = "Cancelar";
                admin.Visible = false;
                label1.Location = new System.Drawing.Point(244, 69);
            }
            else
            {

            }
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            InfoLogin.Visible = false;
        }

        private void BorrarDatos_Click(object sender, EventArgs e)
        {
            string usuario = TXUsu.Text;
            DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas borrar los datos para el usuario {usuario}?", "Confirmar Actualización", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado==DialogResult.OK)
            {
                borrardatos(usuario);
            }
            else
            {
                MessageBox.Show("Operacion cancelada por el usuario.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void borrardatos(string usuario)
        {
            using (MySqlConnection mycon = new MySqlConnection(cadenaconex))
            {
                mycon.Open();  // Abre la conexión

                // Consulta SQL para actualizar los datos del usuario
                string consulta = "UPDATE informacion SET Puntuacion = 0, PartidasJugadas = 0, PartidasGanadas = 0, PartidasPerdidas = 0 WHERE Jugador = @nombreUsuario";

                using (MySqlCommand command = new MySqlCommand(consulta, mycon))
                {
                    // Parámetro para el nombre de usuario
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);

                    // Ejecutar la actualización
                    int filasActualizadas = command.ExecuteNonQuery();

                    // Verificar si se realizaron actualizaciones
                    if (filasActualizadas > 0)
                    {
                        mostrarinforlogin(usuario,ADMIN);
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró ningún usuario con el nombre {usuario}.");
                    }
                }
            }
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            Form4 jugar = new Form4(cadenaconex);
            jugar.Show();
        }
    }
}
