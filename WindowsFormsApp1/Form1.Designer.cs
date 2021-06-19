namespace WindowsFormsApp1
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
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.txtNumDiscos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(276, 156);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(96, 65);
            this.BtnMostrar.TabIndex = 0;
            this.BtnMostrar.Text = "Mostrar Pasos";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(443, 45);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(321, 393);
            this.txtPasos.TabIndex = 1;
            // 
            // txtNumDiscos
            // 
            this.txtNumDiscos.Location = new System.Drawing.Point(92, 177);
            this.txtNumDiscos.Multiline = true;
            this.txtNumDiscos.Name = "txtNumDiscos";
            this.txtNumDiscos.Size = new System.Drawing.Size(55, 35);
            this.txtNumDiscos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumDiscos);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.BtnMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.TextBox txtNumDiscos;
    }
}

