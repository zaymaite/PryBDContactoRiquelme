namespace PryBDContacto
{
    partial class FrmEliminarCon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarCon));
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvContactos = new System.Windows.Forms.DataGridView();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnElimiPro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAgrePro = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PicMenu = new System.Windows.Forms.PictureBox();
            this.panelEliminar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            this.panelEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(317, 100);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 22);
            this.BtnEliminar.TabIndex = 24;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(156, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Eliminar Contactos";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(93, 70);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(182, 22);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(93, 100);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(182, 22);
            this.TxtApellido.TabIndex = 20;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(28, 102);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 15;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(29, 73);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 14;
            this.LblNombre.Text = "Nombre";
            // 
            // DgvContactos
            // 
            this.DgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContactos.Location = new System.Drawing.Point(9, 170);
            this.DgvContactos.Name = "DgvContactos";
            this.DgvContactos.Size = new System.Drawing.Size(505, 221);
            this.DgvContactos.TabIndex = 26;
            // 
            // timerMenu
            // 
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(123)))), ((int)(((byte)(180)))));
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.BtnStock);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.BtnElimiPro);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.BtnModificar);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.BtnAgrePro);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.BtnAgregar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 512);
            this.panelMenu.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel6.Location = new System.Drawing.Point(-4, 335);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 39);
            this.panel6.TabIndex = 17;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Black;
            this.BtnHome.Location = new System.Drawing.Point(1, 335);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(220, 39);
            this.BtnHome.TabIndex = 16;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel5.Location = new System.Drawing.Point(-4, 288);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 39);
            this.panel5.TabIndex = 15;
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.ForeColor = System.Drawing.Color.Black;
            this.BtnStock.Location = new System.Drawing.Point(1, 288);
            this.BtnStock.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(220, 39);
            this.BtnStock.TabIndex = 14;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel1.Location = new System.Drawing.Point(-4, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 39);
            this.panel1.TabIndex = 13;
            // 
            // BtnElimiPro
            // 
            this.BtnElimiPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnElimiPro.FlatAppearance.BorderSize = 0;
            this.BtnElimiPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnElimiPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimiPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimiPro.ForeColor = System.Drawing.Color.Black;
            this.BtnElimiPro.Location = new System.Drawing.Point(1, 241);
            this.BtnElimiPro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnElimiPro.Name = "BtnElimiPro";
            this.BtnElimiPro.Size = new System.Drawing.Size(220, 39);
            this.BtnElimiPro.TabIndex = 12;
            this.BtnElimiPro.Text = "Eliminar Productos";
            this.BtnElimiPro.UseVisualStyleBackColor = false;
            this.BtnElimiPro.Click += new System.EventHandler(this.BtnElimiPro_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel3.Location = new System.Drawing.Point(-4, 196);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 39);
            this.panel3.TabIndex = 11;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(4, 196);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(217, 39);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar Productos";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel2.Location = new System.Drawing.Point(-4, 149);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 39);
            this.panel2.TabIndex = 9;
            // 
            // BtnAgrePro
            // 
            this.BtnAgrePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgrePro.FlatAppearance.BorderSize = 0;
            this.BtnAgrePro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnAgrePro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgrePro.ForeColor = System.Drawing.Color.Black;
            this.BtnAgrePro.Location = new System.Drawing.Point(1, 149);
            this.BtnAgrePro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgrePro.Name = "BtnAgrePro";
            this.BtnAgrePro.Size = new System.Drawing.Size(220, 39);
            this.BtnAgrePro.TabIndex = 8;
            this.BtnAgrePro.Text = "Agregar Productos";
            this.BtnAgrePro.UseVisualStyleBackColor = false;
            this.BtnAgrePro.Click += new System.EventHandler(this.BtnAgrePro_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel4.Location = new System.Drawing.Point(-4, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 39);
            this.panel4.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.Location = new System.Drawing.Point(4, 104);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(217, 39);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar Contactos";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PicMenu
            // 
            this.PicMenu.BackColor = System.Drawing.Color.Transparent;
            this.PicMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMenu.Image = ((System.Drawing.Image)(resources.GetObject("PicMenu.Image")));
            this.PicMenu.Location = new System.Drawing.Point(1, -1);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(49, 49);
            this.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMenu.TabIndex = 29;
            this.PicMenu.TabStop = false;
            this.PicMenu.Click += new System.EventHandler(this.PicMenu_Click_1);
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.BtnEliminar);
            this.panelEliminar.Controls.Add(this.label6);
            this.panelEliminar.Controls.Add(this.DgvContactos);
            this.panelEliminar.Controls.Add(this.TxtNombre);
            this.panelEliminar.Controls.Add(this.TxtApellido);
            this.panelEliminar.Controls.Add(this.LblApellido);
            this.panelEliminar.Controls.Add(this.LblNombre);
            this.panelEliminar.Location = new System.Drawing.Point(56, -1);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(529, 517);
            this.panelEliminar.TabIndex = 30;
            this.panelEliminar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEliminar_Paint);
            // 
            // FrmEliminarCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 512);
            this.Controls.Add(this.panelEliminar);
            this.Controls.Add(this.PicMenu);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEliminarCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Contactos";
            this.Load += new System.EventHandler(this.FrmEliminarCon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactos)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DgvContactos;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnElimiPro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAgrePro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox PicMenu;
        private System.Windows.Forms.Panel panelEliminar;
    }
}