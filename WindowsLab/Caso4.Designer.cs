namespace WindowsLab
{
    partial class Caso4
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
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.txtBaseODiametro = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblBaseODiametro = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(316, 265);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(117, 23);
            this.btnRectangulo.TabIndex = 0;
            this.btnRectangulo.Text = "Area del Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(471, 265);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(110, 23);
            this.btnTriangulo.TabIndex = 1;
            this.btnTriangulo.Text = "Area del Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(617, 265);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(105, 23);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Area del Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // txtBaseODiametro
            // 
            this.txtBaseODiametro.Location = new System.Drawing.Point(316, 72);
            this.txtBaseODiametro.Name = "txtBaseODiametro";
            this.txtBaseODiametro.Size = new System.Drawing.Size(100, 20);
            this.txtBaseODiametro.TabIndex = 3;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(316, 137);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // lblBaseODiametro
            // 
            this.lblBaseODiametro.AutoSize = true;
            this.lblBaseODiametro.Location = new System.Drawing.Point(172, 72);
            this.lblBaseODiametro.Name = "lblBaseODiametro";
            this.lblBaseODiametro.Size = new System.Drawing.Size(126, 13);
            this.lblBaseODiametro.TabIndex = 5;
            this.lblBaseODiametro.Text = "Ingrese Base o Diametro:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(172, 137);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(75, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Ingrese Altura:";
            // 
            // Caso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBaseODiametro);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBaseODiametro);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Name = "Caso4";
            this.Text = "Caso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.TextBox txtBaseODiametro;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblBaseODiametro;
        private System.Windows.Forms.Label lblAltura;
    }
}