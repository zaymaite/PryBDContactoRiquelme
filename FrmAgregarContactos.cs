using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PryBDContacto
{
    public partial class FrmAgregarContactos : Form
    {
        public FrmAgregarContactos()
        {
            InitializeComponent();
        }
        ClsContacto contactos = new ClsContacto();
        ClsCargarCombo Cmb = new ClsCargarCombo();
        private void FrmAgregarContactos_Load(object sender, EventArgs e)
        {
            Cmb.CargarCategorias(CmbCategoria,false);
            HabilitarBtn();
          
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(TxtApellido.Text == null && TxtCorreo.Text == null && TxtNombre.Text == null && TxtTelefono.Text == null && CmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("❗Por favor completa todos los campos.");
            }
            HabilitarBtn();
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string telefono = TxtTelefono.Text;
            string correo = TxtCorreo.Text;
            string categoria = CmbCategoria.SelectedItem.ToString();

            contactos.GuardarContactos(nombre, apellido, telefono, correo, categoria);

            TxtApellido.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            CmbCategoria.SelectedIndex = 0;
            DgvMostrar.DataSource = null;
            DgvMostrar.DataSource = ClsContacto.Mostrar();
        }

        #region HabilitarBtn


        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void HabilitarBtn()
        {
            if (TxtNombre.Text != "" && TxtApellido.Text != "" && TxtTelefono.Text != "" && TxtCorreo.Text != "" && CmbCategoria.SelectedIndex > -1)
            {
                BtnAgregar.Enabled = true;
            }
            else
            {
                BtnAgregar.Enabled = false;
            }
        }
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
           HabilitarBtn();
        }
        #endregion

        #region PanelMenu

        private void PicMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start(); // Inicia animación
        }

        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                panelContenedor.Left -= 10;
                if (panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                panelMenu.Width += 10;
                panelContenedor.Left += 10;

                if (panelMenu.Width >= anchoMaximoMenu)
                {
                    timerMenu.Stop();
                    menuExpandido = true;
                }
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region AbrirForm
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCon eliminar = new FrmEliminarCon();
            eliminar.Show();
            this.Close();
        }

        private void BtnAgrePro_Click(object sender, EventArgs e)
        {
            FrmAgregarPro AgregarProductos = new FrmAgregarPro();
            AgregarProductos.Show();
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPro Modificar = new FrmModificarPro();
            Modificar.Show();
            this.Close();
        }

        private void BtnElimiPro_Click(object sender, EventArgs e)
        {
            FrmEliminarPro eliminarPro = new FrmEliminarPro();
            eliminarPro.Show();
            this.Close();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmConsultarStock Stock = new FrmConsultarStock();
            Stock.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
