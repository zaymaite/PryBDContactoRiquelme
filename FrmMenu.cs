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
    public partial class FrmMenu : Form
    {
        private Timer horaTimer;

        public FrmMenu()
        {
            InitializeComponent();
            horaTimer = new Timer();
            horaTimer.Interval = 1000;
            horaTimer.Tick += Hora_Tick;
            horaTimer.Start();
        }

        #region AbrirForms

        private void BtnEliminarPro_Click(object sender, EventArgs e)
        {
            FrmEliminarPro Eliminar = new FrmEliminarPro();
            Eliminar.Show();
        }

        private void BtnAgregarPro_Click(object sender, EventArgs e)
        {
            FrmAgregarPro agregarPro = new FrmAgregarPro();
            agregarPro.Show();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmConsultarStock stock = new FrmConsultarStock();
            stock.Show();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarPro Modificar  = new FrmModificarPro(); 
            Modificar.Show();
        }

        private void BtnEliminarCont_Click(object sender, EventArgs e)
        {
            FrmEliminarCon eliminarCon = new FrmEliminarCon();
            eliminarCon.Show();
            
        }
        private void BtnAgreContacto_Click(object sender, EventArgs e)
        {
            FrmAgregarContactos AgreCont = new FrmAgregarContactos();
            AgreCont.Show();
            
        }
        #endregion

        private void Hora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("T");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }

    }
}
