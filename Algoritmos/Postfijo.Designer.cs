namespace Algoritmos
{
    partial class Postfijo
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
            this.txtExpresionInfija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtExpresionPostfija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtExpresionInfija
            // 
            this.txtExpresionInfija.Location = new System.Drawing.Point(212, 42);
            this.txtExpresionInfija.Name = "txtExpresionInfija";
            this.txtExpresionInfija.Size = new System.Drawing.Size(243, 23);
            this.txtExpresionInfija.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digitar expresion infija: ";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(212, 110);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtExpresionPostfija
            // 
            this.txtExpresionPostfija.Location = new System.Drawing.Point(212, 177);
            this.txtExpresionPostfija.Name = "txtExpresionPostfija";
            this.txtExpresionPostfija.Size = new System.Drawing.Size(243, 23);
            this.txtExpresionPostfija.TabIndex = 3;
            // 
            // Postfijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExpresionPostfija);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpresionInfija);
            this.Name = "Postfijo";
            this.Text = "Postfijo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtExpresionInfija;
        private Label label1;
        private Button btnConvertir;
        private TextBox txtExpresionPostfija;
    }
}