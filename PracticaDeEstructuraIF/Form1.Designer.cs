namespace PracticaDeEstructuraIF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDivision = new System.Windows.Forms.RadioButton();
            this.btnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.btnResta = new System.Windows.Forms.RadioButton();
            this.btnSuma = new System.Windows.Forms.RadioButton();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnMultiplicacion);
            this.groupBox1.Controls.Add(this.btnResta);
            this.groupBox1.Controls.Add(this.btnSuma);
            this.groupBox1.Location = new System.Drawing.Point(95, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Location = new System.Drawing.Point(18, 108);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(76, 20);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.CheckedChanged += new System.EventHandler(this.btnDivision_CheckedChanged);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.AutoSize = true;
            this.btnMultiplicacion.Location = new System.Drawing.Point(18, 82);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.CheckedChanged += new System.EventHandler(this.btnMultiplicacion_CheckedChanged);
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Location = new System.Drawing.Point(18, 56);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(64, 20);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.CheckedChanged += new System.EventHandler(this.btnResta_CheckedChanged);
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Location = new System.Drawing.Point(18, 30);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(63, 20);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.CheckedChanged += new System.EventHandler(this.btnSuma_CheckedChanged);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(50, 68);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 1;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(173, 74);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(14, 16);
            this.lblOperacion.TabIndex = 2;
            this.lblOperacion.Text = "+";
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Location = new System.Drawing.Point(346, 71);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(14, 16);
            this.lbligual.TabIndex = 3;
            this.lbligual.Text = "=";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(216, 68);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(390, 68);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(47, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Ingrese los valores y seleccione una opción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Practica Estructura IF por Aimee Matias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnDivision;
        private System.Windows.Forms.RadioButton btnMultiplicacion;
        private System.Windows.Forms.RadioButton btnResta;
        private System.Windows.Forms.RadioButton btnSuma;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTitulo;
    }
}

