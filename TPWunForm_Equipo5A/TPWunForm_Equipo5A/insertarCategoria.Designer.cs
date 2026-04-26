namespace TPWunForm_Equipo5B
{
    partial class insertarCategoria
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
            this.btnCancelarInsertarCategoria = new System.Windows.Forms.Button();
            this.lblEscribaCategoria = new System.Windows.Forms.Label();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.tbinsertarCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarInsertarCategoria
            // 
            this.btnCancelarInsertarCategoria.Location = new System.Drawing.Point(138, 73);
            this.btnCancelarInsertarCategoria.Name = "btnCancelarInsertarCategoria";
            this.btnCancelarInsertarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarInsertarCategoria.TabIndex = 7;
            this.btnCancelarInsertarCategoria.Text = "Cancelar";
            this.btnCancelarInsertarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarInsertarCategoria.Click += new System.EventHandler(this.btnCancelarInsertarCategoria_Click);
            // 
            // lblEscribaCategoria
            // 
            this.lblEscribaCategoria.AutoSize = true;
            this.lblEscribaCategoria.Location = new System.Drawing.Point(22, 17);
            this.lblEscribaCategoria.Name = "lblEscribaCategoria";
            this.lblEscribaCategoria.Size = new System.Drawing.Size(103, 13);
            this.lblEscribaCategoria.TabIndex = 6;
            this.lblEscribaCategoria.Text = "Escriba la categoria:";
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(22, 73);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCategoria.TabIndex = 5;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // tbinsertarCategoria
            // 
            this.tbinsertarCategoria.Location = new System.Drawing.Point(22, 40);
            this.tbinsertarCategoria.Name = "tbinsertarCategoria";
            this.tbinsertarCategoria.Size = new System.Drawing.Size(191, 20);
            this.tbinsertarCategoria.TabIndex = 4;
            // 
            // insertarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 114);
            this.Controls.Add(this.btnCancelarInsertarCategoria);
            this.Controls.Add(this.lblEscribaCategoria);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.tbinsertarCategoria);
            this.Name = "insertarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "insertarCategoria";
            this.Load += new System.EventHandler(this.insertarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarInsertarCategoria;
        private System.Windows.Forms.Label lblEscribaCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.TextBox tbinsertarCategoria;
    }
}