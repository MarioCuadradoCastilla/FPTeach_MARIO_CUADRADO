using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FPTeach.Vista
{
    public partial class FormRecursos : Form
    {
        private string connectionString;
        private DataSet dataSet;
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public FormRecursos()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DataBase.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            //MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatos()
        {
            using (SqlConnection connection = new SqlConnection(construirCadenaConexión()))
            {
                string query = "SELECT * FROM recurso";
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void FormRecursos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            cargarCombobox();

        }
        private void cargarCombobox() {
            SqlConnection connection = new SqlConnection(construirCadenaConexión());

            // Consulta para seleccionar todos los nombres de productos
            string query = "SELECT tipo,id FROM Recurso";

            // Crear un comando para ejecutar la consulta
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                // Abrir la conexión
                connection.Open();

                // Ejecutar la consulta y leer los resultados
                SqlDataReader reader = command.ExecuteReader();

                // Limpiar cualquier elemento previo en el ComboBox
                comboBox1.Items.Clear();
                idComboBox.Items.Clear();

                // Agregar cada nombre de producto al ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["id"]);
                    idComboBox.Items.Add(reader["id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los recursos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre del producto seleccionado en el ComboBox
            string nombreProducto = comboBox1.SelectedItem.ToString();

            // Aquí deberías tener tu lógica de conexión a la base de datos
            SqlConnection connection = new SqlConnection(construirCadenaConexión());

            // Consulta para eliminar el producto seleccionado
            string query = "DELETE FROM Recurso WHERE id = @Id";

            // Crear un comando para ejecutar la consulta
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", nombreProducto);

            try
            {
                // Abrir la conexión
                connection.Open();

                // Ejecutar la consulta para eliminar el producto
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Recurso eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el recurso para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el recurso: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
            actualizarDatos();
            cargarCombobox();
        }
        private void actualizarDatos()
        {
            string connectionString = construirCadenaConexión();

            // Inicializar el DataSet y el SqlDataAdapter
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM Recurso", connectionString);

            // Configurar los comandos para insertar, actualizar y eliminar registros
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // Llenar el DataSet con los datos del SqlDataAdapter
            adapter.Fill(dataSet, "Recurso");
            dataGridView1.DataSource = dataSet.Tables["Recurso"];
        }
        private void ActualizarTabla() {
            string campo=comboBoxActualizarCampo.Text;
            string updateQuery = $"UPDATE Recurso SET {campo} = @Valor WHERE id = @Id"; ;

            using (SqlConnection connection = new SqlConnection(construirCadenaConexión()))
            {
                connection.Open();

                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Asignar valores a los parámetros (en este caso, los valores nuevos que quieres asignar a los campos)
                    command.Parameters.AddWithValue("@Valor", textBoxValor.Text);
                    command.Parameters.AddWithValue("@Id", idComboBox.Text);

                    // Ejecutar el comando
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine("Filas actualizadas: " + rowsAffected);
                }
            }
        }
        private bool ActualizarTablaComprobación() {
            bool resultado=false;
            if (idComboBox.SelectedItem != null && comboBoxActualizarCampo.SelectedItem!=null &&textBoxValor.Text!="")
            {
                if (comboBoxActualizarCampo.Text.Equals("Material"))
                {
                    resultado = true;
                }
                else if (comboBoxActualizarCampo.Text.Equals("Tipo"))
                {
                    resultado= true;
                }
                else if (comboBoxActualizarCampo.Text.Equals("Precio"))
                {
                    resultado = true;
                }
                else if (comboBoxActualizarCampo.Text.Equals("Cantidad"))
                {
                    resultado = true;
                }
                else {
                    MessageBox.Show("Selecciona bien los datos");
                }
            }
            else{
                MessageBox.Show("Elije los datos correctamente");
            }

            return resultado;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dataTable);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private bool comprobarAñadir() { 
            bool resultado = false;
            if (textBoxTipo.Text != "" && textBoxPrecio.Text != "" && textBoxMaterial.Text != "")
            {
                resultado = true;
            }
            else {
                MessageBox.Show("Rellena todos los campos correctamente");
            }
            return resultado;
        }
        private void añadirRecurso() {

            // Obtener los valores de los TextBox
            string tipo = textBoxTipo.Text;
            string material = textBoxMaterial.Text;
            double precio = Convert.ToDouble(textBoxPrecio.Text);
            int cantidad = Convert.ToInt32(numericUpDown1.Value);
            DateTime fechacompra = dateTimePicker1.Value;

            // Consulta SQL para insertar un nuevo recurso
            string query = "INSERT INTO Recurso (tipo, material, precio, cantidad,FechaCompra) VALUES (@Tipo, @Material, @Precio,@Cantidad,@FechaCompra)";

            // Crear y configurar el comando SQL
            SqlConnection connection = new SqlConnection(construirCadenaConexión());
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tipo", tipo);
            command.Parameters.AddWithValue("@Material", material);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Cantidad", cantidad);
            command.Parameters.AddWithValue("@FechaCompra", fechacompra);

            try
            {
                // Abrir la conexión
                connection.Open();

                // Ejecutar el comando SQL para insertar el nuevo recurso
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Recurso agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el recurso.");
                    MessageBox.Show(construirCadenaConexión().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el recurso: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
            actualizarDatos();
            cargarCombobox();
            textBoxTipo.Clear();
            textBoxMaterial.Clear();
            textBoxPrecio.Clear();
            numericUpDown1.TabIndex = 0;
        }
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if (comprobarAñadir() == true){
                añadirRecurso();
            }

        }

        private void hacerConsulta(string opcion) {

            using (SqlConnection connection = new SqlConnection(construirCadenaConexión()))
            {
                // Consulta para buscar registros que contengan el valor proporcionado
                string query = $"SELECT * FROM Recurso WHERE {opcion} LIKE @Valor";

                // Crear un comando para ejecutar la consulta
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Configurar el parámetro para la consulta
                    command.Parameters.AddWithValue("@Valor", $"%{textBoxConsulta.Text}%");

                    try
                    {
                        // Abrir la conexión
                        connection.Open();

                        richTextBox1.Clear();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StringBuilder fila = new StringBuilder();

                                // Iterar sobre cada columna y agregar su valor a la cadena
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    fila.Append(reader[i].ToString());

                                    // Agregar un separador entre las columnas (puedes personalizarlo según tu preferencia)
                                    fila.Append("\t");
                                }

                                richTextBox1.AppendText(fila.ToString() + Environment.NewLine);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al consultar el recurso: " + ex.Message);
                    }
                }
            }
            textBoxConsulta.Clear();
        }

        
        private void buttonMaterial_Click(object sender, EventArgs e)
        {
            if (textBoxConsulta.Text != "")
            {
                hacerConsulta("material");
            }
        }

        private void buttonCantidad_Click(object sender, EventArgs e)
        {
            if (textBoxConsulta.Text != "")
            {
                hacerConsulta("cantidad");
               
            }
        }
        private void buttonTipo_Click(object sender, EventArgs e)
        {
            if (textBoxConsulta.Text != "") {
                hacerConsulta("tipo");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click_1(object sender, EventArgs e)
        {
            if (ActualizarTablaComprobación() == true) {
                ActualizarTabla(); 
                idComboBox.Text = "";
                comboBoxActualizarCampo.Text = "";
                textBoxValor.Text = "";
                actualizarDatos();
                cargarCombobox();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void actualizarTodo(object sender, EventArgs e)
        {

            actualizarDatos();

        }
    }
}
