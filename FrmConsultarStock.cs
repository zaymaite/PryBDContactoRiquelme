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
    public partial class FrmConsultarStock : Form
    {
        public FrmConsultarStock()
        {
            InitializeComponent();
        }

        #region Menu
        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick(object sender, EventArgs e)
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

        private void PicMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        #endregion

        ClsProductos productos = new ClsProductos();
        ClsCargarCombo cmb = new ClsCargarCombo();
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == null && TxtNombre.Text == "" && CmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("❗ Por favor seleccione una categoria o agregue un nombre");
            }
            int codigo = 0;
            if (!string.IsNullOrWhiteSpace(TxtCodigo.Text))
            {
                int.TryParse(TxtCodigo.Text.Trim(), out codigo);
            }
            string categoria = CmbCategoria.SelectedValue?.ToString() ?? "";
            DataTable resultado = productos.ConsultarProductos(codigo, TxtNombre.Text, categoria);
            if (resultado != null && resultado.Rows.Count > 0)
            {
                DgvProductos.DataSource = null;
                DgvProductos.DataSource = resultado;
                DgvProductos.Visible = true;
            }
            else
            {
                MessageBox.Show("⚠️ No se encontraron productos.");
                DgvProductos.Visible = false;
            }
            TxtNombre.Clear();
            CmbCategoria.SelectedIndex = -1;
        }

        private void FrmConsultarStock_Load(object sender, EventArgs e)
        {
            timerMenu.Interval = 15;
            cmb.CargarCategorias(CmbCategoria, true);
            CmbCategoria.SelectedIndex = -1;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarCon eliminarCon = new FrmEliminarCon();
            eliminarCon.Show();
            this.Close();
        }

        private void BtnAgreCont_Click(object sender, EventArgs e)
        {
            FrmAgregarPro  agregar = new FrmAgregarPro();
            agregar.Show();
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPro modificar = new FrmModificarPro();
            modificar.Show();
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
    }

}
