namespace ejemplo_1
{
    partial class Form1
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
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(436, 104);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(290, 200);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPokemon.TabIndex = 0;
            this.pbPokemon.TabStop = false;
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokemon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPokemon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPokemon.Location = new System.Drawing.Point(12, 12);
            this.dgvPokemon.MaximumSize = new System.Drawing.Size(418, 350);
            this.dgvPokemon.MinimumSize = new System.Drawing.Size(418, 350);
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.RowHeadersVisible = false;
            this.dgvPokemon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPokemon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(418, 350);
            this.dgvPokemon.TabIndex = 1;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::ejemplo_1.Properties.Resources.Ip1XY;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(436, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ejemplo_1.Properties.Resources.Pokemon_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(728, 374);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPokemon);
            this.Controls.Add(this.pbPokemon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 413);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 413);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.Button btnAgregar;
    }
}

