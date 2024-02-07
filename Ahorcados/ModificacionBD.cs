using MySql.Data.MySqlClient;
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
    public partial class ModificacionBD : Form
    {
        string cadenaconex;
        string valor;
        string tipo;
        public MySqlConnection mycon;
        DataGridView dg;
        public delegate void cargardg(string valor);
        private Form3 form3;
        public ModificacionBD(string cadenaconex, string valor,string tipo, DataGridView dg, Form3 form3)
        {
            InitializeComponent();
            this.cadenaconex = cadenaconex;
            this.valor = valor;
            this.tipo = tipo;
            this.dg = dg;
            this.form3 = form3;
        }

        private void rellenarCombo()
        {
            string query = "SELECT Categoria FROM categorias;"; // Reemplaza "NombreColumna" y "TuTabla" con tus valores reales

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpiar el ComboBox antes de agregar nuevos elementos
                            CB.Items.Clear();

                            // Agregar elementos al ComboBox desde la tabla
                            while (reader.Read())
                            {
                                CB.Items.Add(reader["Categoria"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde MySQL: " + ex.Message);
            }
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
        private void ModificacionBD_Load(object sender, EventArgs e)
        {
            conectar();
            rellenarCombo();
            if (valor.Equals("Palabra"))
            {
                Obj1.Text = "Palabra";
                Obj2.Text = "Longitud";
                Obj3.Visible = false;
                Obj4.Visible = false;
                TX4.Visible = false;
                CB.Visible = true;
                CB.Location = new System.Drawing.Point(365, 236);
                TX2.Enabled = false;
                ADMIN.Visible = false;
                Console.WriteLine(TX1.Location);
            }
            else if (valor.Equals("Categoria"))
            {
                Obj1.Text = "Categoria";
                Obj2.Text = "Dificultad";
                TX3.Visible = false;
                TX4.Visible = false;
                Obj3.Visible = false;
                Obj4.Visible = false;
                ADMIN.Visible = false;

            }
            else
            {
                Obj1.Text = "Usuario";
                Obj2.Text = "Contraseña";
                Obj3.Text = "Admin";
                Obj4.Text = "Puntuacion";
                label3.Visible = true;
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (valor.Equals("Palabra"))
            {
                if (TX1.Text.Equals("")||CB.SelectedItem.ToString()==null)
                {
                    label1.Text = "El campo de la palabra o la categoria no pueden estar vacias";
                    label1.Visible = true;
                }
                else
                {
                    string Palabra = TX1.Text;
                    string Longitud = TX1.Text.Length.ToString();
                    string Categoria = CB.SelectedItem.ToString();

                    if (tipo.Equals("Añadir"))
                    {
                        string query = "INSERT INTO palabras (Palabra, Longitud, Categoria) VALUES (@palabra, @longitud, @categoria);";

                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                            {
                                connection.Open();

                                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@palabra", Palabra);
                                    cmd.Parameters.AddWithValue("@longitud", Longitud);
                                    cmd.Parameters.AddWithValue("@categoria", Categoria);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Palabra insertada correctamente.");
                            form3.cargarDG(valor);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar la palabra en MySQL: " + ex.Message);
                        }
                    }
                    else if (tipo.Equals("Editar"))
                    {
                        string Palabra2 = TX1.Text;
                        string Longitud2 = TX1.Text.Length.ToString();
                        string Categoria2 = CB.SelectedItem.ToString();
                        string palabraeditar= dg.SelectedRows[0].Cells["Palabra"].Value.ToString();
                        string query = "UPDATE palabras set palabra=@NuevaPalabra, longitud= @nuevaLongitud, categoria=@CategoriaNueva where palabra= @palabraeditar";
                        try
                        {
                            using (MySqlCommand comando = new MySqlCommand(query, mycon))
                            {
                                comando.Parameters.AddWithValue("@nuevaPalabra", Palabra2);
                                comando.Parameters.AddWithValue("@nuevaLongitud", Longitud2);
                                comando.Parameters.AddWithValue("@CategoriaNueva", Categoria2);
                                comando.Parameters.AddWithValue("@palabraeditar", palabraeditar);
                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Se ha actualizado la palabra corretamente");
                                    form3.cargarDG(valor);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la palabra.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha habido un error al actualizar el la palabra");
                        }
                    }
                }
            }
            else if (valor.Equals("Categoria"))
            {
                if (TX1.Text.Equals(""))
                {
                    label1.Text = "El campo de la palabra o la categoria no pueden estar vacias";
                    label1.Visible = true;
                }
                else
                {
                    string categoria = TX1.Text;
                    string dificultad = TX2.Text;
 
                    if (tipo.Equals("Añadir"))
                    {
                        string query = "INSERT INTO categorias (Categoria, Dificultad) VALUES (@Categoria, @Dificultad);";

                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                            {
                                connection.Open();

                                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                                    cmd.Parameters.AddWithValue("@Dificultad", dificultad);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Categoria insertada correctamente.");
                            form3.cargarDG(valor);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar la palabra en MySQL: " + ex.Message);
                        }
                    }
                    else if (tipo.Equals("Editar"))
                    {
                        string Categoria2 = TX1.Text;
                        string Dificultad2 = TX2.Text;
                        string Categoriaeditar = dg.SelectedRows[0].Cells["Categoria"].Value.ToString();
                        string query = "update categorias set Categoria=@Categoria, Dificultad=@Dificultad where Categoria=@CategoriaEditar";
                        try
                        {
                            using (MySqlCommand comando = new MySqlCommand(query, mycon))
                            {
                                comando.Parameters.AddWithValue("@Categoria", Categoria2);
                                comando.Parameters.AddWithValue("@Dificultad", Dificultad2);
                                comando.Parameters.AddWithValue("@CategoriaEditar", Categoriaeditar);

                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Se ha actualizado la palabra corretamente");
                                    form3.cargarDG(valor);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la palabra.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha habido un error al actualizar el la palabra");
                        }
                    }
                }
            }
            else
            {
                if (TX1.Text.Equals("")||TX2.Text.Equals(""))
                {
                    label1.Text = "El campo del usuario, o de la contraseña no pueden estar vacios";
                    label2.Text = "Y el campo de Admin solo puede ser 0 o 1";
                    label1.Visible = true;
                    label2.Visible = true;
                }
                if (ADMIN.Value!=0&&ADMIN.Value!=1)
                {
                    MessageBox.Show("No puede ser");
                }
                else
                {
                    string usu = TX1.Text;
                    string contra = TX2.Text;
                    string admin = ADMIN.Value.ToString();
                    if (tipo.Equals("Añadir"))
                    {
                        string query = "INSERT INTO usuarios (Usuario, Contraseña, Admin) VALUES (@Usuario, @Contraseña,@Admin);";

                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                            {
                                connection.Open();

                                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@Usuario", usu);
                                    cmd.Parameters.AddWithValue("@Contraseña", contra);
                                    cmd.Parameters.AddWithValue("@Admin", admin);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("jugador insertada correctamente.");
                            form3.cargarDG(valor);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al insertar la palabra en MySQL: " + ex.Message);
                        }
                    }
                    else if (tipo.Equals("Editar"))
                    {
                        string Usuario = TX1.Text;
                        string Contrasena = TX2.Text;
                        string admini = ADMIN.Value.ToString();
                        string UsuarioEditar = dg.SelectedRows[0].Cells["Usuario"].Value.ToString();
                        string query = "update usuarios set Usuario=@Usuario, Contrasena=@Contrasena, Admin=@Admin where Usuario=@UsuarioEditar";
                        try
                        {
                            using (MySqlCommand comando = new MySqlCommand(query, mycon))
                            {
                                comando.Parameters.AddWithValue("@Usuario", Usuario);
                                comando.Parameters.AddWithValue("@Contrasena", Contrasena);
                                comando.Parameters.AddWithValue("@Admin", admini);
                                comando.Parameters.AddWithValue("@UsuarioEditar", UsuarioEditar);

                                int filasAfectadas = comando.ExecuteNonQuery();

                                if (filasAfectadas > 0)
                                {
                                    MessageBox.Show("Se ha actualizado la palabra corretamente");
                                    form3.cargarDG(valor);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró la palabra.");
                                }
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Ha habido un error al actualizar el la palabra");
                        }
                    }
                }
            }
        }

        private void TX1_TextChanged(object sender, EventArgs e)
        {
            if (valor.Equals("Palabra"))
            {
                TX2.Text = TX1.Text.Length.ToString();
            }
        }
    }
}
