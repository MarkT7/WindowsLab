namespace WindowsLab.PracticaVectores
{
    partial class Caso4Vec
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtNombre4 = new System.Windows.Forms.TextBox();
            this.txtNombre5 = new System.Windows.Forms.TextBox();
            this.txtEdad1 = new System.Windows.Forms.TextBox();
            this.txtEdad2 = new System.Windows.Forms.TextBox();
            this.txtEdad3 = new System.Windows.Forms.TextBox();
            this.txtEdad4 = new System.Windows.Forms.TextBox();
            this.txtEdad5 = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblEdades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Informar adultos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(252, 89);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 20);
            this.txtNombre1.TabIndex = 1;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(252, 140);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 20);
            this.txtNombre2.TabIndex = 2;
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(252, 194);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(100, 20);
            this.txtNombre3.TabIndex = 3;
            // 
            // txtNombre4
            // 
            this.txtNombre4.Location = new System.Drawing.Point(252, 242);
            this.txtNombre4.Name = "txtNombre4";
            this.txtNombre4.Size = new System.Drawing.Size(100, 20);
            this.txtNombre4.TabIndex = 4;
            // 
            // txtNombre5
            // 
            this.txtNombre5.Location = new System.Drawing.Point(252, 287);
            this.txtNombre5.Name = "txtNombre5";
            this.txtNombre5.Size = new System.Drawing.Size(100, 20);
            this.txtNombre5.TabIndex = 5;
            this.txtNombre5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(422, 89);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(100, 20);
            this.txtEdad1.TabIndex = 6;
            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(422, 140);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(100, 20);
            this.txtEdad2.TabIndex = 7;
            // 
            // txtEdad3
            // 
            this.txtEdad3.Location = new System.Drawing.Point(422, 194);
            this.txtEdad3.Name = "txtEdad3";
            this.txtEdad3.Size = new System.Drawing.Size(100, 20);
            this.txtEdad3.TabIndex = 8;
            // 
            // txtEdad4
            // 
            this.txtEdad4.Location = new System.Drawing.Point(422, 242);
            this.txtEdad4.Name = "txtEdad4";
            this.txtEdad4.Size = new System.Drawing.Size(100, 20);
            this.txtEdad4.TabIndex = 9;
            // 
            // txtEdad5
            // 
            this.txtEdad5.Location = new System.Drawing.Point(422, 287);
            this.txtEdad5.Name = "txtEdad5";
            this.txtEdad5.Size = new System.Drawing.Size(100, 20);
            this.txtEdad5.TabIndex = 10;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(280, 39);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 11;
            this.lblNombres.Text = "Nombres";
            // 
            // lblEdades
            // 
            this.lblEdades.AutoSize = true;
            this.lblEdades.Location = new System.Drawing.Point(452, 39);
            this.lblEdades.Name = "lblEdades";
            this.lblEdades.Size = new System.Drawing.Size(43, 13);
            this.lblEdades.TabIndex = 12;
            this.lblEdades.Text = "Edades";
            // 
            // Caso4Vec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdades);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtEdad5);
            this.Controls.Add(this.txtEdad4);
            this.Controls.Add(this.txtEdad3);
            this.Controls.Add(this.txtEdad2);
            this.Controls.Add(this.txtEdad1);
            this.Controls.Add(this.txtNombre5);
            this.Controls.Add(this.txtNombre4);
            this.Controls.Add(this.txtNombre3);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.button1);
            this.Name = "Caso4Vec";
            this.Text = "Caso4Vec";
            this.Load += new System.EventHandler(this.Caso4Vec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.TextBox txtNombre4;
        private System.Windows.Forms.TextBox txtNombre5;
        private System.Windows.Forms.TextBox txtEdad1;
        private System.Windows.Forms.TextBox txtEdad2;
        private System.Windows.Forms.TextBox txtEdad3;
        private System.Windows.Forms.TextBox txtEdad4;
        private System.Windows.Forms.TextBox txtEdad5;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblEdades;
    }
}