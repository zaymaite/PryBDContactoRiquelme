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
    public class ClsCargarCombo
    {
        public  void CargarCategorias(ComboBox combo, bool usarID)
        {
            //Libera la conexion al final
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "SELECT Id, Nombre FROM Categorias";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader leer = comando.ExecuteReader(); //ejecuta la consulta y devuelve SqlDataReader
                    if(usarID)
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(leer);
                        combo.DataSource = tabla;
                        combo.DisplayMember = "Nombre"; 
                        combo.ValueMember = "Id"; //qué columna del origen de datos se usará como "valor" interno
                    }
                    else
                    {
                        while (leer.Read())
                        {
                            combo.Items.Add(leer["Nombre"].ToString());
                        }
                    }
                    

                    leer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar categorías: " + ex.Message);
                }

            }
        }

    }
}
