namespace PryBDContacto
{
    partial class FrmModificarPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.PicMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnAgregarPro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnElimiPro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnStock = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnAgreCont = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Controls.Add(this.LblDescripcion);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.LblPrecio);
            this.panel1.Controls.Add(this.DgvProductos);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Location = new System.Drawing.Point(58, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 470);
            this.panel1.TabIndex = 1;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(220, 161);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.TxtDescripcion.TabIndex = 34;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(125, 168);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 33;
            this.LblDescripcion.Text = "Descripción";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(220, 129);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(119, 20);
            this.TxtPrecio.TabIndex = 32;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(88, 132);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(100, 13);
            this.LblPrecio.TabIndex = 31;
            this.LblPrecio.Text = "Precio del Producto";
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(33, 228);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(567, 172);
            this.DgvProductos.TabIndex = 30;
            this.DgvProductos.Visible = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(106)))), ((int)(((byte)(127)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(467, 195);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(118, 25);
            this.BtnModificar.TabIndex = 28;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(178, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 31);
            this.label6.TabIndex = 29;
            this.label6.Text = "Modificar Productos";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(220, 93);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(212, 20);
            this.TxtNombre.TabIndex = 27;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(88, 96);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(107, 13);
            this.LblNombre.TabIndex = 26;
            this.LblNombre.Text = "Nombre del Producto";
            // 
            // PicMenu
            // 
            this.PicMenu.BackColor = System.Drawing.Color.Transparent;
            this.PicMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMenu.Image = ((System.Drawing.Image)(resources.GetObject("PicMenu.Image")));
            this.PicMenu.Location = new System.Drawing.Point(0, 1);
            this.PicMenu.Name = "PicMenu";
            this.PicMenu.Size = new System.Drawing.Size(51, 48);
            this.PicMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMenu.TabIndex = 18;
            this.PicMenu.TabStop = false;
            this.PicMenu.Click += new System.EventHandler(this.PicMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(123)))), ((int)(((byte)(180)))));
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.panel6);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.BtnAgregarPro);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.BtnElimiPro);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.BtnStock);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.BtnAgreCont);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.BtnEliminar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 450);
            this.panelMenu.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel7.Location = new System.Drawing.Point(0, 196);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 39);
            this.panel7.TabIndex = 14;
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
            // BtnAgregarPro
            // 
            this.BtnAgregarPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgregarPro.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnAgregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPro.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarPro.Location = new System.Drawing.Point(1, 288);
            this.BtnAgregarPro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarPro.Name = "BtnAgregarPro";
            this.BtnAgregarPro.Size = new System.Drawing.Size(220, 39);
            this.BtnAgregarPro.TabIndex = 14;
            this.BtnAgregarPro.Text = "Agregar Productos";
            this.BtnAgregarPro.UseVisualStyleBackColor = false;
            this.BtnAgregarPro.Click += new System.EventHandler(this.BtnAgregarPro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel2.Location = new System.Drawing.Point(-4, 241);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 39);
            this.panel2.TabIndex = 13;
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
            this.panel3.Size = new System.Drawing.Size(0, 39);
            this.panel3.TabIndex = 11;
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.ForeColor = System.Drawing.Color.Black;
            this.BtnStock.Location = new System.Drawing.Point(4, 196);
            this.BtnStock.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(217, 39);
            this.BtnStock.TabIndex = 10;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel4.Location = new System.Drawing.Point(-4, 149);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 39);
            this.panel4.TabIndex = 9;
            // 
            // BtnAgreCont
            // 
            this.BtnAgreCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgreCont.FlatAppearance.BorderSize = 0;
            this.BtnAgreCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnAgreCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgreCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgreCont.ForeColor = System.Drawing.Color.Black;
            this.BtnAgreCont.Location = new System.Drawing.Point(1, 149);
            this.BtnAgreCont.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgreCont.Name = "BtnAgreCont";
            this.BtnAgreCont.Size = new System.Drawing.Size(220, 39);
            this.BtnAgreCont.TabIndex = 8;
            this.BtnAgreCont.Text = "Agregar Contactos";
            this.BtnAgreCont.UseVisualStyleBackColor = false;
            this.BtnAgreCont.Click += new System.EventHandler(this.BtnAgreCont_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.panel8.Location = new System.Drawing.Point(-4, 104);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(13, 39);
            this.panel8.TabIndex = 7;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(4, 104);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(217, 39);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar Contactos";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 15;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick_1);
            // 
            // FrmModificarPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.PicMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Name = "FrmModificarPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FrmModificarPro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.PictureBox PicMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAgregarPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnElimiPro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAgreCont;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
    }
}