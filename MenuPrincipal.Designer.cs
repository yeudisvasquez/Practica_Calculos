namespace Practica_Calculos
{
    partial class MenuPrincipal
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
            this.BtnPoligonos = new System.Windows.Forms.Button();
            this.BtnJuegos = new System.Windows.Forms.Button();
            this.BtnDeciBinar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPoligonos
            // 
            this.BtnPoligonos.Location = new System.Drawing.Point(153, 44);
            this.BtnPoligonos.Name = "BtnPoligonos";
            this.BtnPoligonos.Size = new System.Drawing.Size(220, 56);
            this.BtnPoligonos.TabIndex = 0;
            this.BtnPoligonos.Text = "Poligonos";
            this.BtnPoligonos.UseVisualStyleBackColor = true;
            this.BtnPoligonos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnJuegos
            // 
            this.BtnJuegos.Location = new System.Drawing.Point(153, 123);
            this.BtnJuegos.Name = "BtnJuegos";
            this.BtnJuegos.Size = new System.Drawing.Size(220, 56);
            this.BtnJuegos.TabIndex = 1;
            this.BtnJuegos.Text = "Juego de Partidas";
            this.BtnJuegos.UseVisualStyleBackColor = true;
            this.BtnJuegos.Click += new System.EventHandler(this.BtnJuegos_Click);
            // 
            // BtnDeciBinar
            // 
            this.BtnDeciBinar.Location = new System.Drawing.Point(153, 208);
            this.BtnDeciBinar.Name = "BtnDeciBinar";
            this.BtnDeciBinar.Size = new System.Drawing.Size(220, 56);
            this.BtnDeciBinar.TabIndex = 2;
            this.BtnDeciBinar.Text = "Decimal y Binario";
            this.BtnDeciBinar.UseVisualStyleBackColor = true;
            this.BtnDeciBinar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(153, 292);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(220, 56);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "Terminar Y Salir";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 384);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnDeciBinar);
            this.Controls.Add(this.BtnJuegos);
            this.Controls.Add(this.BtnPoligonos);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPoligonos;
        private System.Windows.Forms.Button BtnJuegos;
        private System.Windows.Forms.Button BtnDeciBinar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

