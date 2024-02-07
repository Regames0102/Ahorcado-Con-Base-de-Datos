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
    public partial class Form3 : Form
    {
        string valor;
        string cadenaconex;
        public MySqlConnection mycon;
        public Form3(string cadenaconex, string valor)
        {
            InitializeComponent();
            this.cadenaconex = cadenaconex;
            this.valor = valor;
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

        private void Form3_Load(object sender, EventArgs e)
        {
            conectar();
            cargarDG(valor);
        }
        public void cargarDG(string valor)
        {
            if (valor.Equals("Categoria"))
            {
                string query = "SELECT Categoria, Dificultad FROM categorias;";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Asignar el origen de datos al DataGridView
                                DG.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde MySQL: " + ex.Message);
                }
            }
            else if (valor.Equals("Palabra"))
            {
                string query = "SELECT Palabra, Longitud, Categoria FROM palabras;";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Asignar el origen de datos al DataGridView
                                DG.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde MySQL: " + ex.Message);
                }
            }
            else
            {
                string query = "SELECT Usuario, Contrasena, Admin FROM usuarios;";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(cadenaconex))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Asignar el origen de datos al DataGridView
                                DG.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde MySQL: " + ex.Message);
                }
            }
        }

        private void añadirObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tipo = "Añadir";
            ModificacionBD añadir = new ModificacionBD(cadenaconex,valor,tipo,DG,this);
            añadir.ShowDialog();

        }

        private void editarObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tipo = "Editar";

            if (DG.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DG.SelectedRows[0];
                if (valor.Equals("Palabra"))
                {
                    if (filaSeleccionada.Cells.Count > 0)
                    {
                        ModificacionBD editar = new ModificacionBD(cadenaconex, valor, tipo, DG, this);
                        editar.TX1.Text = filaSeleccionada.Cells["Palabra"].Value.ToString();
                        editar.CB.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                        editar.ShowDialog();
                    }
                }
                else if (valor.Equals("Categoria"))
                {
                    ModificacionBD editar = new ModificacionBD(cadenaconex, valor, tipo, DG, this);
                    editar.TX1.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                    editar.TX2.Text = filaSeleccionada.Cells["Dificultad"].Value.ToString();
                    editar.ShowDialog();
                }
                else
                {
                    ModificacionBD editar = new ModificacionBD(cadenaconex, valor, tipo, DG, this);
                    editar.TX1.Text = filaSeleccionada.Cells["Usuario"].Value.ToString();
                    editar.TX2.Text = filaSeleccionada.Cells["Contrasena"].Value.ToString();
                    editar.ADMIN.Value = int.Parse(filaSeleccionada.Cells["Admin"].Value.ToString());
                    editar.ShowDialog();
                }
                // Verificar si hay celdas en la fila

            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
    }

        private void borrarObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tipo = "borrar";
            if (DG.SelectedRows.Count > 0) {
                if (valor.Equals("Palabra"))
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que quieres borrar la palabra?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Analizar el resultado del MessageBox
                    if (resultado == DialogResult.Yes)
                    {
                        string query = "delete from palabras where Palabra=@palabra";
                        using (MySqlCommand comando = new MySqlCommand(query, mycon))
                        {
                            // Parámetros
                            comando.Parameters.AddWithValue("@palabra", DG.SelectedRows[0].Cells["Palabra"].Value.ToString());

                            // Ejecutar la consulta de borrado
                            int filasAfectadas = comando.ExecuteNonQuery();

                            // Verificar si se borraron filas
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Palabra borrada correctamente.");
                                cargarDG(valor);
                            }
                        }
                    }
                }
                else if (valor.Equals("Categoria"))
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que quieres borrar la categoría? Se borraran todas las palabras", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Analizar el resultado del MessageBox
                    if (resultado == DialogResult.Yes)
                    {
                        string query = "delete from categorias where Categoria=@categoria";
                        using (MySqlCommand comando = new MySqlCommand(query, mycon))
                        {
                            // Parámetros
                            comando.Parameters.AddWithValue("@categoria", DG.SelectedRows[0].Cells["Categoria"].Value.ToString());

                            // Ejecutar la consulta de borrado
                            int filasAfectadas = comando.ExecuteNonQuery();

                            // Verificar si se borraron filas
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Categoria borrada correctamente.");
                                cargarDG(valor);
                            }
                        }
                    }
                    }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que quieres borrar este usuario? Se borrará tambien la informacion sobre el", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Analizar el resultado del MessageBox
                    if (resultado == DialogResult.Yes)
                    {
                        string query = "delete from usuarios where Usuario=@usuario";
                        using (MySqlCommand comando = new MySqlCommand(query, mycon))
                        {
                            // Parámetros
                            comando.Parameters.AddWithValue("@usuario", DG.SelectedRows[0].Cells["Usuario"].Value.ToString());

                            // Ejecutar la consulta de borrado
                            int filasAfectadas = comando.ExecuteNonQuery();

                            // Verificar si se borraron filas
                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario borrado correctamente.");
                                cargarDG(valor);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }
    }
}
