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
    internal class ClsProductos
    {
        public void GuardarProductos(string Nombre, string Descripcion, string Precio, string Stock, string Categoria)
        {
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO Productos(Nombre, Descripcion, Precio, Stock, Categoria)" +
                                   "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Categoria)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", Descripcion);
                    comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(Precio));
                    comando.Parameters.AddWithValue("@Stock", Convert.ToInt32(Stock));
                    comando.Parameters.AddWithValue("@Categoria", Convert.ToInt32(Categoria));

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("✅ Producto agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se pudo agregar el producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }


        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Nombre, Descripcion, Precio, Stock, Categoria FROM Productos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    adapter.Fill(tabla);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al obtener los productos: " + ex.Message);
                    
                }
            }
            return tabla;
        }

        public void EliminarProductos(string nombre)
        {
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "DELETE FROM Productos WHERE Nombre = @Nombre";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                   
                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("✅ Producto eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se encontró un producto con ese nombre.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al eliminar: " + ex.Message);
                }
            }
        }

        public DataTable ConsultarProductos(int codigo, string nombre, string categoria)
        {
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    List<string> condiciones = new List<string>(); // representa una lista de strings que guardará las partes del WHERE,
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;

                    if (codigo != 0)
                    {
                        condiciones.Add("Codigo = @Codigo");
                        comando.Parameters.AddWithValue("@Codigo", codigo);
                    }

                    if (nombre != "")
                    {
                        condiciones.Add("Nombre = @Nombre");
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                    }

                    if (categoria != "")
                    {
                        condiciones.Add("Categoria = @Categoria");
                        comando.Parameters.AddWithValue("@Categoria", categoria);
                    }

                    string query = "SELECT * FROM Productos";

                    if (condiciones.Count > 0)
                    {                        //une las condiciones
                        query += " WHERE " + string.Join(" AND ", condiciones);
                    }

                    comando.CommandText = query;

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al consultar productos: " + ex.Message);
                    return null;
                }
            }
        }

        public bool ActualizarProducto(string descripcion, string nombre, decimal nuevoPrecio)
        {
            using (SqlConnection conn = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string updateQuery = "UPDATE Productos SET Precio = @precio, Descripcion = @descripcion WHERE Nombre = @nombre";
                    SqlCommand comando = new SqlCommand(updateQuery, conn);
                    comando.Parameters.AddWithValue("@precio", nuevoPrecio);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al actualizar: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
