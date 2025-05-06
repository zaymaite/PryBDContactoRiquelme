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
            using (SqlConnection conexion = ClsConexion.ObtenerConexion())
            {
                try
                {
                    string query = "SELECT Id, Nombre FROM Categorias";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataReader leer = comando.ExecuteReader();
                    if(usarID)
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(leer);
                        combo.DataSource = tabla;
                        combo.DisplayMember = "Nombre";
                        combo.ValueMember = "Id";
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

        public void CargarCmbConId(ComboBox combo)
        {

        }
    }
}
