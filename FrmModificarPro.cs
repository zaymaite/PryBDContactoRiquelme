using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryBDContacto
{
    public partial class FrmModificarPro : Form
    {
        public FrmModificarPro()
        {
            InitializeComponent();
        }
        #region Menu
        
        private void PicMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick_1(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                panel1.Left -= 10;
                if (panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                panelMenu.Width += 10;
                panel1.Left += 10;

                if (panelMenu.Width >= anchoMaximoMenu)
                {
                    timerMenu.Stop();
                    menuExpandido = true;
                }
            }
        }
        #endregion

        ClsProductos productos = new ClsProductos();
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "" && TxtNombre.Text == "" && TxtPrecio.Text == "")
            {
                MessageBox.Show("❗ Por favor ingrese el nombre y el nuevo precio.");
                return;
            }

            string nombre = TxtNombre.Text;
            if (!decimal.TryParse(TxtPrecio.Text, out decimal nuevoPrecio))
            {
                MessageBox.Show("⚠️ Ingrese un precio válido.");
                return;
            }

            bool actualizado = productos.ActualizarProducto(TxtDescripcion.Text, nombre, nuevoPrecio);

            if (actualizado)
            {
                MessageBox.Show("✅ Producto actualizado correctamente.");
                TxtNombre.Clear();
                TxtPrecio.Clear();
                TxtDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("⚠️ No se encontró un producto con ese nombre.");
            }
        }

        #region AbrirForm
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCon eliminar = new FrmEliminarCon();
            eliminar.Show();
            this.Close();
        }

        private void BtnAgreCont_Click(object sender, EventArgs e)
        {
            FrmAgregarContactos agregar = new FrmAgregarContactos();
            agregar.Show();
            this.Close();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmConsultarStock stock = new FrmConsultarStock();
            stock.Show();
            this.Close();
        }

        private void BtnElimiPro_Click(object sender, EventArgs e)
        {
            FrmEliminarPro eliminar = new FrmEliminarPro();
            eliminar.Show();
            this.Close();
        }

        private void BtnAgregarPro_Click(object sender, EventArgs e)
        {
            FrmAgregarPro agregarPro = new FrmAgregarPro();
            agregarPro.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void FrmModificarPro_Load(object sender, EventArgs e)
        {
            timerMenu.Interval = 15;
        }

       
    }
}
