namespace WindowsFormsApplication7
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
            this.lbnum1 = new System.Windows.Forms.Label();
            this.txtescribir = new System.Windows.Forms.TextBox();
            this.btmensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.Location = new System.Drawing.Point(35, 58);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(64, 13);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.Text = "escribe algo";
            // 
            // txtescribir
            // 
            this.txtescribir.Location = new System.Drawing.Point(121, 51);
            this.txtescribir.Name = "txtescribir";
            this.txtescribir.Size = new System.Drawing.Size(100, 20);
            this.txtescribir.TabIndex = 2;
            // 
            // btmensaje
            // 
            this.btmensaje.Location = new System.Drawing.Point(111, 177);
            this.btmensaje.Name = "btmensaje";
            this.btmensaje.Size = new System.Drawing.Size(75, 25);
            this.btmensaje.TabIndex = 3;
            this.btmensaje.Text = "presions";
            this.btmensaje.UseVisualStyleBackColor = true;
            this.btmensaje.Click += new System.EventHandler(this.btmensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btmensaje);
            this.Controls.Add(this.txtescribir);
            this.Controls.Add(this.lbnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.TextBox txtescribir;
        private System.Windows.Forms.Button btmensaje;
    }
}

