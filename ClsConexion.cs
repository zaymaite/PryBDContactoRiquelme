using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PryBDContacto
{
    public class ClsConexion
    {
        private static string ConexionBD = "Server=localhost\\SQLEXPRESS;Database=Comercio;Trusted_Connection=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(ConexionBD);
            try
            {
                conexion.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }

            return conexion;
        }
    }
}
