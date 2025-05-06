namespace PryBDContacto
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BtnAgreContacto = new System.Windows.Forms.Button();
            this.BtnEliminarCont = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnAgregarPro = new System.Windows.Forms.Button();
            this.BtnEliminarPro = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgreContacto
            // 
            this.BtnAgreContacto.BackColor = System.Drawing.Color.White;
            this.BtnAgreContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgreContacto.FlatAppearance.BorderSize = 0;
            this.BtnAgreContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgreContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgreContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgreContacto.Location = new System.Drawing.Point(52, 256);
            this.BtnAgreContacto.Name = "BtnAgreContacto";
            this.BtnAgreContacto.Size = new System.Drawing.Size(183, 62);
            this.BtnAgreContacto.TabIndex = 0;
            this.BtnAgreContacto.Text = "Agregar Contactos";
            this.BtnAgreContacto.UseVisualStyleBackColor = false;
            this.BtnAgreContacto.Click += new System.EventHandler(this.BtnAgreContacto_Click);
            // 
            // BtnEliminarCont
            // 
            this.BtnEliminarCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarCont.FlatAppearance.BorderSize = 0;
            this.BtnEliminarCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnEliminarCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCont.Location = new System.Drawing.Point(313, 256);
            this.BtnEliminarCont.Name = "BtnEliminarCont";
            this.BtnEliminarCont.Size = new System.Drawing.Size(173, 62);
            this.BtnEliminarCont.TabIndex = 1;
            this.BtnEliminarCont.Text = "Eliminar Contactos";
            this.BtnEliminarCont.UseVisualStyleBackColor = true;
            this.BtnEliminarCont.Click += new System.EventHandler(this.BtnEliminarCont_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(63, 348);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 62);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar Productos";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(313, 348);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(173, 62);
            this.BtnStock.TabIndex = 3;
            this.BtnStock.Text = "Consultar Stock";
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnAgregarPro
            // 
            this.BtnAgregarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarPro.FlatAppearance.BorderSize = 0;
            this.BtnAgregarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnAgregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPro.Location = new System.Drawing.Point(582, 256);
            this.BtnAgregarPro.Name = "BtnAgregarPro";
            this.BtnAgregarPro.Size = new System.Drawing.Size(173, 62);
            this.BtnAgregarPro.TabIndex = 4;
            this.BtnAgregarPro.Text = "Agrergar Productos";
            this.BtnAgregarPro.UseVisualStyleBackColor = true;
            this.BtnAgregarPro.Click += new System.EventHandler(this.BtnAgregarPro_Click);
            // 
            // BtnEliminarPro
            // 
            this.BtnEliminarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarPro.FlatAppearance.BorderSize = 0;
            this.BtnEliminarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(136)))), ((int)(((byte)(184)))));
            this.BtnEliminarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarPro.Location = new System.Drawing.Point(582, 348);
            this.BtnEliminarPro.Name = "BtnEliminarPro";
            this.BtnEliminarPro.Size = new System.Drawing.Size(173, 62);
            this.BtnEliminarPro.TabIndex = 5;
            this.BtnEliminarPro.Text = "Eliminar Productos";
            this.BtnEliminarPro.UseVisualStyleBackColor = true;
            this.BtnEliminarPro.Click += new System.EventHandler(this.BtnEliminarPro_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 348);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(260, 348);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(528, 348);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.Blue;
            this.LblHora.Location = new System.Drawing.Point(247, 32);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(0, 73);
            this.LblHora.TabIndex = 15;
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // Hora
            // 
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(4, 256);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 62);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(260, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.BtnAgreContacto);
            this.Controls.Add(this.BtnEliminarPro);
            this.Controls.Add(this.BtnEliminarCont);
            this.Controls.Add(this.BtnAgregarPro);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.pictureBox5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgreContacto;
        private System.Windows.Forms.Button BtnEliminarCont;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnAgregarPro;
        private System.Windows.Forms.Button BtnEliminarPro;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

