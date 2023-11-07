namespace Presentacion
{
    partial class Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.pbMarco = new System.Windows.Forms.PictureBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lbCampo = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lbCriterio = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulo.Location = new System.Drawing.Point(37, 141);
            this.dgvArticulo.MaximumSize = new System.Drawing.Size(429, 263);
            this.dgvArticulo.MinimumSize = new System.Drawing.Size(429, 263);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.ReadOnly = true;
            this.dgvArticulo.RowHeadersVisible = false;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(429, 263);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.Location = new System.Drawing.Point(666, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 29);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightCyan;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModificar.Location = new System.Drawing.Point(559, 375);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 29);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightYellow;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(472, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 29);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.BackColor = System.Drawing.Color.Transparent;
            this.pbArticulo.Location = new System.Drawing.Point(533, 187);
            this.pbArticulo.MaximumSize = new System.Drawing.Size(158, 127);
            this.pbArticulo.MinimumSize = new System.Drawing.Size(158, 127);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(158, 127);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // lbRegistro
            // 
            this.lbRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRegistro.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegistro.Location = new System.Drawing.Point(37, 27);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(719, 37);
            this.lbRegistro.TabIndex = 7;
            this.lbRegistro.Text = "REGISTRO DE DATOS";
            this.lbRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMarco
            // 
            this.pbMarco.BackColor = System.Drawing.Color.Transparent;
            this.pbMarco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMarco.BackgroundImage")));
            this.pbMarco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMarco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMarco.Location = new System.Drawing.Point(517, 173);
            this.pbMarco.Name = "pbMarco";
            this.pbMarco.Size = new System.Drawing.Size(191, 155);
            this.pbMarco.TabIndex = 8;
            this.pbMarco.TabStop = false;
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(37, 114);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 1;
            // 
            // lbCampo
            // 
            this.lbCampo.BackColor = System.Drawing.Color.Transparent;
            this.lbCampo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCampo.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCampo.Location = new System.Drawing.Point(37, 90);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(121, 21);
            this.lbCampo.TabIndex = 10;
            this.lbCampo.Text = "Campo";
            this.lbCampo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(164, 115);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(118, 21);
            this.cbCriterio.TabIndex = 2;
            // 
            // lbCriterio
            // 
            this.lbCriterio.BackColor = System.Drawing.Color.Transparent;
            this.lbCriterio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCriterio.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriterio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbCriterio.Location = new System.Drawing.Point(164, 90);
            this.lbCriterio.Name = "lbCriterio";
            this.lbCriterio.Size = new System.Drawing.Size(118, 21);
            this.lbCriterio.TabIndex = 12;
            this.lbCriterio.Text = "Criterio";
            this.lbCriterio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(288, 116);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(101, 20);
            this.tbFiltro.TabIndex = 3;
            this.tbFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFiltro
            // 
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFiltro.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbFiltro.Location = new System.Drawing.Point(288, 90);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(101, 21);
            this.lbFiltro.TabIndex = 14;
            this.lbFiltro.Text = "Filtro";
            this.lbFiltro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MistyRose;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Location = new System.Drawing.Point(394, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 446);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lbCriterio);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lbCampo);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lbRegistro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.pbMarco);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(797, 485);
            this.Name = "Presentacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de datos";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMarco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.PictureBox pbMarco;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lbCriterio;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Button btnSearch;
    }
}

