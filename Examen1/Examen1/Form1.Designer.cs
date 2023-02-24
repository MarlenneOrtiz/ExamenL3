namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.rbdtriangulo = new System.Windows.Forms.RadioButton();
            this.rbdC = new System.Windows.Forms.RadioButton();
            this.rbdrecta = new System.Windows.Forms.RadioButton();
            this.rbdcuadrado = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el area a Calcular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Altura";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(408, 115);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(125, 27);
            this.txtbase.TabIndex = 7;
            this.txtbase.TextChanged += new System.EventHandler(this.txtbase_TextChanged);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(616, 115);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(125, 27);
            this.txtaltura.TabIndex = 8;
            this.txtaltura.TextChanged += new System.EventHandler(this.txtaltura_TextChanged);
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(485, 211);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(185, 85);
            this.btnconvertir.TabIndex = 9;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // rbdtriangulo
            // 
            this.rbdtriangulo.AutoSize = true;
            this.rbdtriangulo.Location = new System.Drawing.Point(45, 138);
            this.rbdtriangulo.Name = "rbdtriangulo";
            this.rbdtriangulo.Size = new System.Drawing.Size(127, 24);
            this.rbdtriangulo.TabIndex = 10;
            this.rbdtriangulo.TabStop = true;
            this.rbdtriangulo.Text = "Area Triangulo";
            this.rbdtriangulo.UseVisualStyleBackColor = true;
            this.rbdtriangulo.CheckedChanged += new System.EventHandler(this.rbdtriangulo_CheckedChanged);
            // 
            // rbdC
            // 
            this.rbdC.AutoSize = true;
            this.rbdC.Location = new System.Drawing.Point(227, 211);
            this.rbdC.Name = "rbdC";
            this.rbdC.Size = new System.Drawing.Size(111, 24);
            this.rbdC.TabIndex = 11;
            this.rbdC.TabStop = true;
            this.rbdC.Text = "Area Circulo";
            this.rbdC.UseVisualStyleBackColor = true;
            this.rbdC.CheckedChanged += new System.EventHandler(this.rbdC_CheckedChanged);
            // 
            // rbdrecta
            // 
            this.rbdrecta.AutoSize = true;
            this.rbdrecta.Location = new System.Drawing.Point(216, 138);
            this.rbdrecta.Name = "rbdrecta";
            this.rbdrecta.Size = new System.Drawing.Size(140, 24);
            this.rbdrecta.TabIndex = 12;
            this.rbdrecta.TabStop = true;
            this.rbdrecta.Text = "Area Rectangulo";
            this.rbdrecta.UseVisualStyleBackColor = true;
            this.rbdrecta.CheckedChanged += new System.EventHandler(this.rbdrecta_CheckedChanged);
            // 
            // rbdcuadrado
            // 
            this.rbdcuadrado.AutoSize = true;
            this.rbdcuadrado.Location = new System.Drawing.Point(45, 211);
            this.rbdcuadrado.Name = "rbdcuadrado";
            this.rbdcuadrado.Size = new System.Drawing.Size(130, 24);
            this.rbdcuadrado.TabIndex = 13;
            this.rbdcuadrado.TabStop = true;
            this.rbdcuadrado.Text = "Area Cuadrado";
            this.rbdcuadrado.UseVisualStyleBackColor = true;
            this.rbdcuadrado.CheckedChanged += new System.EventHandler(this.rbdcuadrado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbdcuadrado);
            this.Controls.Add(this.rbdrecta);
            this.Controls.Add(this.rbdC);
            this.Controls.Add(this.rbdtriangulo);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbase;
        private TextBox txtaltura;
        private Button btnconvertir;
        private RadioButton rbdtriangulo;
        private RadioButton rbdC;
        private RadioButton rbdrecta;
        private RadioButton rbdcuadrado;
    }
}