namespace Calculadora
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
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btsumar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btresta = new System.Windows.Forms.Button();
            this.btmulti = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(69, 34);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 0;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(69, 80);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 1;
            this.tbB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btsumar
            // 
            this.btsumar.Location = new System.Drawing.Point(69, 145);
            this.btsumar.Name = "btsumar";
            this.btsumar.Size = new System.Drawing.Size(100, 23);
            this.btsumar.TabIndex = 2;
            this.btsumar.Text = "Sumar";
            this.btsumar.UseVisualStyleBackColor = true;
            this.btsumar.Click += new System.EventHandler(this.btsumar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(91, 116);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // btresta
            // 
            this.btresta.Location = new System.Drawing.Point(69, 174);
            this.btresta.Name = "btresta";
            this.btresta.Size = new System.Drawing.Size(100, 23);
            this.btresta.TabIndex = 4;
            this.btresta.Text = "Resta";
            this.btresta.UseVisualStyleBackColor = true;
            this.btresta.Click += new System.EventHandler(this.btresta_Click);
            // 
            // btmulti
            // 
            this.btmulti.Location = new System.Drawing.Point(69, 203);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(100, 23);
            this.btmulti.TabIndex = 5;
            this.btmulti.Text = "Multiplicar";
            this.btmulti.UseVisualStyleBackColor = true;
            this.btmulti.Click += new System.EventHandler(this.btmulti_Click);
            // 
            // btdiv
            // 
            this.btdiv.Location = new System.Drawing.Point(69, 232);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(100, 23);
            this.btdiv.TabIndex = 6;
            this.btdiv.Text = "Dividir";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.btdiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 281);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.btresta);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btsumar);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btsumar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btresta;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button btdiv;
    }
}

