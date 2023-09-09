namespace ejercicio7
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
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(164, 59);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(442, 20);
            this.txt_resultado.TabIndex = 0;
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Location = new System.Drawing.Point(310, 180);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(75, 23);
            this.bt_iniciar.TabIndex = 1;
            this.bt_iniciar.Text = "Comenzar";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_iniciar);
            this.Controls.Add(this.txt_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button bt_iniciar;
    }
}

