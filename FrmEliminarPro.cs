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
    public partial class FrmEliminarPro : Form
    {
        public FrmEliminarPro()
        {
            InitializeComponent();
        }
        ClsProductos productos = new ClsProductos();
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            
            if (nombre != "")
            {
                DialogResult confirmacion = MessageBox.Show($"¿Eliminar a {nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    productos.EliminarProductos(nombre);
                    DgvProductos.DataSource = productos.Mostrar(); // Recarga la grilla

                }
               
            }
            else
            {
                MessageBox.Show("⚠️ Completá el nombre del producto para eliminar.");
            }
            TxtNombre.Clear();
            
        }
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
          
        }

        #region Menu
        private void PicMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                panelEliminar.Left -= 10;
                if (panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                panelMenu.Width += 10;
                panelEliminar.Left += 10;

                if (panelMenu.Width >= anchoMaximoMenu)
                {
                    timerMenu.Stop();
                    menuExpandido = true;
                }
            }
        }

        #endregion

        private void FrmEliminarPro_Load(object sender, EventArgs e)
        {
            timerMenu.Interval = 15;
        }
        #region AbrirForm
        private void BtnEliminarCon_Click(object sender, EventArgs e)
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPro modificar = new FrmModificarPro();
            modificar.Show();
            this.Close();
        }

        private void BtnAgregarPro_Click(object sender, EventArgs e)
        {
            FrmAgregarPro pro = new FrmAgregarPro();   
            pro.Show();
            this.Close();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmConsultarStock stock = new FrmConsultarStock();
            stock.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
