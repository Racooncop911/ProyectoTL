namespace calculadora
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
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Divi = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.txtbxA = new System.Windows.Forms.TextBox();
            this.txtbxB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OperationResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(12, 64);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 0;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(93, 64);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 1;
            this.Resta.Text = "Resta";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Divi
            // 
            this.Divi.Location = new System.Drawing.Point(174, 64);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(75, 23);
            this.Divi.TabIndex = 2;
            this.Divi.Text = "Divi";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(255, 64);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(75, 23);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "Multi";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // txtbxA
            // 
            this.txtbxA.Location = new System.Drawing.Point(12, 12);
            this.txtbxA.Name = "txtbxA";
            this.txtbxA.Size = new System.Drawing.Size(318, 20);
            this.txtbxA.TabIndex = 4;
            // 
            // txtbxB
            // 
            this.txtbxB.Location = new System.Drawing.Point(12, 38);
            this.txtbxB.Name = "txtbxB";
            this.txtbxB.Size = new System.Drawing.Size(318, 20);
            this.txtbxB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OperationResult);
            this.groupBox1.Location = new System.Drawing.Point(73, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // OperationResult
            // 
            this.OperationResult.AutoSize = true;
            this.OperationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationResult.Location = new System.Drawing.Point(81, 37);
            this.OperationResult.Name = "OperationResult";
            this.OperationResult.Size = new System.Drawing.Size(41, 31);
            this.OperationResult.TabIndex = 0;
            this.OperationResult.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbxB);
            this.Controls.Add(this.txtbxA);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.TextBox txtbxA;
        private System.Windows.Forms.TextBox txtbxB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OperationResult;
    }
}

