namespace WinXpath
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txPagina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txXpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txXpathVal = new System.Windows.Forms.TextBox();
            this.txXpathValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txArchivoResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar dato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(771, 269);
            this.textBox1.TabIndex = 1;
            // 
            // txPagina
            // 
            this.txPagina.Location = new System.Drawing.Point(82, 12);
            this.txPagina.Name = "txPagina";
            this.txPagina.Size = new System.Drawing.Size(698, 20);
            this.txPagina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Página";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xpath";
            // 
            // txXpath
            // 
            this.txXpath.Location = new System.Drawing.Point(82, 38);
            this.txXpath.Name = "txXpath";
            this.txXpath.Size = new System.Drawing.Size(698, 20);
            this.txXpath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xpath valida";
            // 
            // txXpathVal
            // 
            this.txXpathVal.Location = new System.Drawing.Point(82, 64);
            this.txXpathVal.Name = "txXpathVal";
            this.txXpathVal.Size = new System.Drawing.Size(328, 20);
            this.txXpathVal.TabIndex = 6;
            // 
            // txXpathValor
            // 
            this.txXpathValor.Location = new System.Drawing.Point(486, 64);
            this.txXpathValor.Name = "txXpathValor";
            this.txXpathValor.Size = new System.Drawing.Size(294, 20);
            this.txXpathValor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Archivo";
            // 
            // txArchivoResultado
            // 
            this.txArchivoResultado.Location = new System.Drawing.Point(82, 90);
            this.txArchivoResultado.Name = "txArchivoResultado";
            this.txArchivoResultado.Size = new System.Drawing.Size(698, 20);
            this.txArchivoResultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txArchivoResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txXpathValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txXpathVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txXpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPagina);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Xpath valida";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txXpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txXpathVal;
        private System.Windows.Forms.TextBox txXpathValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txArchivoResultado;
    }
}

