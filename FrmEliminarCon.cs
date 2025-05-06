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
    public partial class FrmEliminarCon : Form
    {
        public FrmEliminarCon()
        {
            InitializeComponent();
        }
       
        private void FrmEliminarCon_Load(object sender, EventArgs e)
        {
            //Para el panel
            timerMenu.Interval = 15;
            HabilitarBtn();
        }

        #region PanelMenu

        bool menuExpandido = false;
        int anchoMaximoMenu = 200;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                panelMenu.Width -= 10;
                panelEliminar.Left -= 10;
                if(panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuExpandido=false;
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

        private void PicMenu_Click_1(object sender, EventArgs e)
        {
            timerMenu.Start();
            
        }
        #endregion

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //para eliminar el contacto
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();

            if (nombre != "" && apellido != "")
            {
                DialogResult confirmacion = MessageBox.Show($"¿Eliminar a {nombre} {apellido}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    ClsContacto.EliminarContactos(nombre, apellido);
                    DgvContactos.DataSource = ClsContacto.Mostrar(); // Recarga la grilla
                    
                }
                HabilitarBtn();
            }
            else
            {
               MessageBox.Show("⚠️ Completá nombre y apellido para eliminar.");
            }
            TxtNombre.Clear();
            TxtApellido.Clear();
        }
        #region habilitarBtn
        public void HabilitarBtn()
        {
            if (TxtNombre.Text != "" && TxtApellido.Text != "")
            {
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnEliminar.Enabled = false;
            }
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtn();
        }
        #endregion

        #region AbrirForms
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarContactos agregarCon = new FrmAgregarContactos();
            agregarCon.Show();
            this.Close();
        }

        private void BtnAgrePro_Click(object sender, EventArgs e)
        {
            FrmAgregarPro AgrePro = new FrmAgregarPro();
            AgrePro.Show();
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
            FrmEliminarPro Eliminar = new FrmEliminarPro();
            Eliminar.Show();
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

        private void panelEliminar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
