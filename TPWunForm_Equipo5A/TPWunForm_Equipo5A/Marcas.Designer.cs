namespace TPWunForm_Equipo5B
{
    partial class Marcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnInsertarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnVolverMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 40);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(223, 235);
            this.dgvMarcas.TabIndex = 0;
            // 
            // btnInsertarMarca
            // 
            this.btnInsertarMarca.Location = new System.Drawing.Point(241, 40);
            this.btnInsertarMarca.Name = "btnInsertarMarca";
            this.btnInsertarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarMarca.TabIndex = 1;
            this.btnInsertarMarca.Text = "Agregar";
            this.btnInsertarMarca.UseVisualStyleBackColor = true;
            this.btnInsertarMarca.Click += new System.EventHandler(this.btnInsertarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(241, 89);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 2;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(241, 138);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnVolverMarcas
            // 
            this.btnVolverMarcas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverMarcas.Location = new System.Drawing.Point(241, 220);
            this.btnVolverMarcas.Name = "btnVolverMarcas";
            this.btnVolverMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMarcas.TabIndex = 4;
            this.btnVolverMarcas.Text = "Volver";
            this.btnVolverMarcas.UseVisualStyleBackColor = true;
            this.btnVolverMarcas.Click += new System.EventHandler(this.btnVolverMarcas_Click);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolverMarcas;
            this.ClientSize = new System.Drawing.Size(339, 287);
            this.Controls.Add(this.btnVolverMarcas);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnInsertarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnInsertarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnVolverMarcas;
    }
}