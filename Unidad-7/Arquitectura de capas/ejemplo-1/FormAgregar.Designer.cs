namespace ejemplo_1
{
    partial class FormAgregar
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
            this.nombre = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.urlimagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.Debilidad = new System.Windows.Forms.Label();
            this.cbDebilidad = new System.Windows.Forms.ComboBox();
            this.pbPokenew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokenew)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombre.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.nombre.Location = new System.Drawing.Point(254, 113);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(79, 19);
            this.nombre.TabIndex = 10;
            this.nombre.Text = "Nombre:";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcion
            // 
            this.descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripcion.AutoSize = true;
            this.descripcion.BackColor = System.Drawing.Color.Transparent;
            this.descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descripcion.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descripcion.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.descripcion.Location = new System.Drawing.Point(253, 150);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(112, 19);
            this.descripcion.TabIndex = 11;
            this.descripcion.Text = "Descripcion:";
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urlimagen
            // 
            this.urlimagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urlimagen.AutoSize = true;
            this.urlimagen.BackColor = System.Drawing.Color.Transparent;
            this.urlimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlimagen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlimagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urlimagen.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.urlimagen.Location = new System.Drawing.Point(253, 185);
            this.urlimagen.Name = "urlimagen";
            this.urlimagen.Size = new System.Drawing.Size(101, 19);
            this.urlimagen.TabIndex = 12;
            this.urlimagen.Text = "UrlImagen:";
            this.urlimagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.pictureBox1.Location = new System.Drawing.Point(141, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 317);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Location = new System.Drawing.Point(339, 114);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.Location = new System.Drawing.Point(371, 151);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(133, 20);
            this.tbDescripcion.TabIndex = 2;
            this.tbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUrlImagen
            // 
            this.tbUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUrlImagen.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUrlImagen.Location = new System.Drawing.Point(360, 186);
            this.tbUrlImagen.Name = "tbUrlImagen";
            this.tbUrlImagen.Size = new System.Drawing.Size(144, 20);
            this.tbUrlImagen.TabIndex = 3;
            this.tbUrlImagen.Text = "Link";
            this.tbUrlImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUrlImagen.Enter += new System.EventHandler(this.tbUrlImagen_Enter);
            this.tbUrlImagen.Leave += new System.EventHandler(this.tbUrlImagen_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(248, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(429, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(510, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "POKEDEX";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // numero
            // 
            this.numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.Color.Transparent;
            this.numero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numero.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numero.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.numero.Location = new System.Drawing.Point(253, 79);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(80, 19);
            this.numero.TabIndex = 9;
            this.numero.Text = "Numero:";
            this.numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNumero
            // 
            this.tbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNumero.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumero.Location = new System.Drawing.Point(339, 80);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(165, 20);
            this.tbNumero.TabIndex = 0;
            this.tbNumero.Text = "Sin 0\'s";
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumero.Enter += new System.EventHandler(this.tbNumero_Enter);
            this.tbNumero.Leave += new System.EventHandler(this.tbNumero_Leave);
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipo.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.tipo.Location = new System.Drawing.Point(161, 237);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(52, 19);
            this.tipo.TabIndex = 13;
            this.tipo.Text = "Tipo:";
            this.tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(219, 238);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 5;
            // 
            // Debilidad
            // 
            this.Debilidad.AutoSize = true;
            this.Debilidad.BackColor = System.Drawing.Color.Transparent;
            this.Debilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Debilidad.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debilidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Debilidad.Image = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.Debilidad.Location = new System.Drawing.Point(349, 237);
            this.Debilidad.Name = "Debilidad";
            this.Debilidad.Size = new System.Drawing.Size(92, 19);
            this.Debilidad.TabIndex = 14;
            this.Debilidad.Text = "Debilidad:";
            this.Debilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDebilidad
            // 
            this.cbDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDebilidad.FormattingEnabled = true;
            this.cbDebilidad.Location = new System.Drawing.Point(447, 238);
            this.cbDebilidad.Name = "cbDebilidad";
            this.cbDebilidad.Size = new System.Drawing.Size(121, 21);
            this.cbDebilidad.TabIndex = 6;
            // 
            // pbPokenew
            // 
            this.pbPokenew.BackColor = System.Drawing.Color.Transparent;
            this.pbPokenew.BackgroundImage = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.pbPokenew.Location = new System.Drawing.Point(145, 114);
            this.pbPokenew.Name = "pbPokenew";
            this.pbPokenew.Size = new System.Drawing.Size(111, 90);
            this.pbPokenew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokenew.TabIndex = 15;
            this.pbPokenew.TabStop = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ejemplo_1.Properties.Resources.Pokemon_BG;
            this.ClientSize = new System.Drawing.Size(728, 374);
            this.Controls.Add(this.pbPokenew);
            this.Controls.Add(this.cbDebilidad);
            this.Controls.Add(this.Debilidad);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbUrlImagen);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.urlimagen);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 413);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 413);
            this.Name = "FormAgregar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokenew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label urlimagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbUrlImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label Debilidad;
        private System.Windows.Forms.ComboBox cbDebilidad;
        private System.Windows.Forms.PictureBox pbPokenew;
    }
}