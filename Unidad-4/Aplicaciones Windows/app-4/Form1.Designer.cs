namespace app_4
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
            this.caja1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.caja2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caja1
            // 
            this.caja1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.caja1.Location = new System.Drawing.Point(362, 144);
            this.caja1.MaxLength = 20;
            this.caja1.Multiline = true;
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(100, 124);
            this.caja1.TabIndex = 0;
            this.caja1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caja1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caja2
            // 
            this.caja2.Location = new System.Drawing.Point(232, 274);
            this.caja2.Multiline = true;
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(342, 124);
            this.caja2.TabIndex = 2;
            this.caja2.Leave += new System.EventHandler(this.caja2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caja1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox caja2;
    }
}

