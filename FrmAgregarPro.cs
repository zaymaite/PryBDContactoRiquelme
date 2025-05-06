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
    public partial class FrmAgregarPro : Form
    {
        public FrmAgregarPro()
        {
            InitializeComponent();
        }
        #region AbrirForms
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCon elimicon = new FrmEliminarCon();
            elimicon.Show();
            this.Close();
        }

        private void BtnAgreCont_Click(object sender, EventArgs e)
        {
            FrmAgregarContactos AgreCont = new FrmAgregarContactos();
            AgreCont.Show();
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPro modificar = new FrmModificarPro();  
            modificar.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {;
            this.Close();
        }

        private void BtnElimiPro_Click(object sender, EventArgs e)
        {
            FrmEliminarPro eliminar = new FrmEliminarPro();
            eliminar.Show();
            this.Close();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmConsultarStock stock = new FrmConsultarStock();  
            stock.Show();
            this.Close();
        }

        #endregion

        ClsCargarCombo Cmb = new ClsCargarCombo();
        ClsProductos productos = new ClsProductos();    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (TxtDescripcion.Text == "" && TxtPrecio.Text == "" && TxtNombre.Text == "" && TxtStock.Text == "" && CmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("❗Por favor completa todos los campos.");
            }
            HabilitarBtn();
            productos.GuardarProductos(TxtNombre.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtStock.Text, CmbCategoria.SelectedValue.ToString());

            TxtDescripcion.Clear();
            TxtNombre.Clear();
            TxtStock.Clear();
            TxtPrecio.Clear();
            CmbCategoria.SelectedIndex = 0;
            DgvGrilla.DataSource = null;
            DgvGrilla.DataSource = productos.Mostrar();
        }

        private void FrmAgregarPro_Load(object sender, EventArgs e)
        {
            timerMenu.Interval = 15;
            Cmb.CargarCategorias(CmbCategoria, true);
            CmbCategoria.SelectedIndex = -1;
            DgvGrilla.DataSource = null;
            DgvGrilla.DataSource = productos.Mostrar();
            HabilitarBtn();
        }

        #region HabilitarBtn
        private void HabilitarBtn()
        {
            if (TxtNombre.Text != "" && TxtDescripcion.Text != "" && TxtPrecio.Text != "" && TxtStock.Text != "" && CmbCategoria.SelectedIndex > -1)
            {
                BtnAgregar.Enabled = true;
            }
            else
            {
                BtnAgregar.Enabled = false;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }
        #endregion

        private void panelAgrePro_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Menu

        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                panelAgrePro.Left -= 10;
                if (panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuExpandido = false;
                }
            }
            else
            {
                panelMenu.Width += 10;
                panelAgrePro.Left += 10;

                if (panelMenu.Width >= anchoMaximoMenu)
                {
                    timerMenu.Stop();
                    menuExpandido = true;
                }
            }
        }

        private void PicMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        #endregion
    }
}
