namespace ServiciosWE.Practica.Net.client
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
            this.components = new System.ComponentModel.Container();
            this.BasetextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AlturatextBox2 = new System.Windows.Forms.TextBox();
            this.Calculabutton = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BasetextBox1
            // 
            this.BasetextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasetextBox1.Location = new System.Drawing.Point(269, 119);
            this.BasetextBox1.Name = "BasetextBox1";
            this.BasetextBox1.Size = new System.Drawing.Size(111, 30);
            this.BasetextBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // AlturatextBox2
            // 
            this.AlturatextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlturatextBox2.Location = new System.Drawing.Point(411, 119);
            this.AlturatextBox2.Name = "AlturatextBox2";
            this.AlturatextBox2.Size = new System.Drawing.Size(111, 24);
            this.AlturatextBox2.TabIndex = 3;
            // 
            // Calculabutton
            // 
            this.Calculabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculabutton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Calculabutton.Location = new System.Drawing.Point(313, 180);
            this.Calculabutton.Name = "Calculabutton";
            this.Calculabutton.Size = new System.Drawing.Size(162, 39);
            this.Calculabutton.TabIndex = 4;
            this.Calculabutton.Text = "Calcular";
            this.Calculabutton.UseVisualStyleBackColor = true;
            this.Calculabutton.Click += new System.EventHandler(this.Calculabutton_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(257, 258);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(16, 17);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 525);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Calculabutton);
            this.Controls.Add(this.AlturatextBox2);
            this.Controls.Add(this.BasetextBox1);
            this.Name = "Form1";
            this.Text = "Calcula Areaa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BasetextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox AlturatextBox2;
        private System.Windows.Forms.Button Calculabutton;
        private System.Windows.Forms.Label Resultado;
    }
}

