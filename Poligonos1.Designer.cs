namespace Practica_Calculos
{
    partial class Poligonos1
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.RdBtnTriangulo = new System.Windows.Forms.RadioButton();
            this.RdBtnRectangulo = new System.Windows.Forms.RadioButton();
            this.RdBtnCuadrado = new System.Windows.Forms.RadioButton();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(99, 57);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 26);
            this.txtBase.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(99, 93);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdBtnCuadrado);
            this.groupBox1.Controls.Add(this.RdBtnRectangulo);
            this.groupBox1.Controls.Add(this.RdBtnTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(46, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poligonos";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(42, 341);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(135, 36);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Area del Poligono:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(317, 90);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 26);
            this.txtArea.TabIndex = 7;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(324, 341);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(135, 36);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // RdBtnTriangulo
            // 
            this.RdBtnTriangulo.AutoSize = true;
            this.RdBtnTriangulo.Location = new System.Drawing.Point(27, 40);
            this.RdBtnTriangulo.Name = "RdBtnTriangulo";
            this.RdBtnTriangulo.Size = new System.Drawing.Size(99, 24);
            this.RdBtnTriangulo.TabIndex = 3;
            this.RdBtnTriangulo.TabStop = true;
            this.RdBtnTriangulo.Text = "Triangulo";
            this.RdBtnTriangulo.UseVisualStyleBackColor = true;
            // 
            // RdBtnRectangulo
            // 
            this.RdBtnRectangulo.AutoSize = true;
            this.RdBtnRectangulo.Location = new System.Drawing.Point(27, 70);
            this.RdBtnRectangulo.Name = "RdBtnRectangulo";
            this.RdBtnRectangulo.Size = new System.Drawing.Size(116, 24);
            this.RdBtnRectangulo.TabIndex = 4;
            this.RdBtnRectangulo.TabStop = true;
            this.RdBtnRectangulo.Text = "Rectangulo";
            this.RdBtnRectangulo.UseVisualStyleBackColor = true;
            // 
            // RdBtnCuadrado
            // 
            this.RdBtnCuadrado.AutoSize = true;
            this.RdBtnCuadrado.Location = new System.Drawing.Point(27, 100);
            this.RdBtnCuadrado.Name = "RdBtnCuadrado";
            this.RdBtnCuadrado.Size = new System.Drawing.Size(104, 24);
            this.RdBtnCuadrado.TabIndex = 5;
            this.RdBtnCuadrado.TabStop = true;
            this.RdBtnCuadrado.Text = "Cuadrado";
            this.RdBtnCuadrado.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(183, 341);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(135, 36);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Poligonos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 431);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "Poligonos1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poligonos1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RadioButton RdBtnCuadrado;
        private System.Windows.Forms.RadioButton RdBtnRectangulo;
        private System.Windows.Forms.RadioButton RdBtnTriangulo;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}