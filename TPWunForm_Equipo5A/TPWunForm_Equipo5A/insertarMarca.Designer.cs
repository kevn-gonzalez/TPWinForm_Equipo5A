namespace TPWunForm_Equipo5B
{
    partial class insertarMarca
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
            this.tbinsertarMarca = new System.Windows.Forms.TextBox();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.lblEscribaMarca = new System.Windows.Forms.Label();
            this.btnCancelarInsertarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbinsertarMarca
            // 
            this.tbinsertarMarca.Location = new System.Drawing.Point(12, 32);
            this.tbinsertarMarca.Name = "tbinsertarMarca";
            this.tbinsertarMarca.Size = new System.Drawing.Size(179, 20);
            this.tbinsertarMarca.TabIndex = 0;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.Location = new System.Drawing.Point(12, 65);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMarca.TabIndex = 1;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // lblEscribaMarca
            // 
            this.lblEscribaMarca.AutoSize = true;
            this.lblEscribaMarca.Location = new System.Drawing.Point(12, 9);
            this.lblEscribaMarca.Name = "lblEscribaMarca";
            this.lblEscribaMarca.Size = new System.Drawing.Size(88, 13);
            this.lblEscribaMarca.TabIndex = 2;
            this.lblEscribaMarca.Text = "Escriba la marca:";
            // 
            // btnCancelarInsertarMarca
            // 
            this.btnCancelarInsertarMarca.Location = new System.Drawing.Point(116, 65);
            this.btnCancelarInsertarMarca.Name = "btnCancelarInsertarMarca";
            this.btnCancelarInsertarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarInsertarMarca.TabIndex = 3;
            this.btnCancelarInsertarMarca.Text = "Cancelar";
            this.btnCancelarInsertarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarInsertarMarca.Click += new System.EventHandler(this.btnCancelarInsertarMarca_Click);
            // 
            // insertarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 100);
            this.Controls.Add(this.btnCancelarInsertarMarca);
            this.Controls.Add(this.lblEscribaMarca);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.tbinsertarMarca);
            this.Name = "insertarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "insertarMarca";
            this.Load += new System.EventHandler(this.insertarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbinsertarMarca;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Label lblEscribaMarca;
        private System.Windows.Forms.Button btnCancelarInsertarMarca;
    }
}