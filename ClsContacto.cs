using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PryBDContacto
{
    internal class ClsContacto
    {
        public void GuardarContactos(string nombre, string apellido, string telefono, string correo, string categoria)
        {
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO Contacto(Nombre, Apellido, Telefono, Correo, Categoria)" +
                                   "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Categoria)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Correo", correo);
                    comando.Parameters.AddWithValue("@Categoria", categoria);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("✅ Contacto agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se pudo agregar el contacto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        public static DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Comercio;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre, Apellido, Telefono, Correo, Categoria FROM Contacto";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al obtener contactos: " + ex.Message);
                }
            }
            return tabla;
        }

        public static void EliminarContactos(string nombre, string apellido)
        {
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "DELETE FROM Contacto WHERE Nombre = @Nombre AND Apellido = @Apellido";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("✅ Contacto eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se encontró un contacto con ese nombre y apellido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
