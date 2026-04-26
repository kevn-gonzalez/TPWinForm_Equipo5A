namespace TPWunForm_Equipo5B
{
    partial class Categorias
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
            this.btnVolverCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnInsertarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCategoria
            // 
            this.btnVolverCategoria.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverCategoria.Location = new System.Drawing.Point(231, 206);
            this.btnVolverCategoria.Name = "btnVolverCategoria";
            this.btnVolverCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCategoria.TabIndex = 9;
            this.btnVolverCategoria.Text = "Volver";
            this.btnVolverCategoria.UseVisualStyleBackColor = true;
            this.btnVolverCategoria.Click += new System.EventHandler(this.btnVolverCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(231, 123);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 8;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(231, 74);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 7;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnInsertarCategoria
            // 
            this.btnInsertarCategoria.Location = new System.Drawing.Point(231, 25);
            this.btnInsertarCategoria.Name = "btnInsertarCategoria";
            this.btnInsertarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarCategoria.TabIndex = 6;
            this.btnInsertarCategoria.Text = "Agregar";
            this.btnInsertarCategoria.UseVisualStyleBackColor = true;
            this.btnInsertarCategoria.Click += new System.EventHandler(this.btnInsertarCategoria_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 25);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(213, 235);
            this.dgvCategorias.TabIndex = 5;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolverCategoria;
            this.ClientSize = new System.Drawing.Size(342, 284);
            this.Controls.Add(this.btnVolverCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnInsertarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnInsertarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}