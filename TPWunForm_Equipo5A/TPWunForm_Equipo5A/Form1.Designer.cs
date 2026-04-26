namespace TPWunForm_Equipo5B
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnModificar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pboxArticulos = new System.Windows.Forms.PictureBox();
            this.lblBuscarX = new System.Windows.Forms.Label();
            this.cbBusquedaX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrincipal.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrincipal.Location = new System.Drawing.Point(12, 100);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(511, 244);
            this.dgvPrincipal.TabIndex = 0;
            this.dgvPrincipal.SelectionChanged += new System.EventHandler(this.dgvPrincipal_SelectionChanged);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar1.Location = new System.Drawing.Point(12, 363);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(100, 33);
            this.btnAgregar1.TabIndex = 1;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnModificar1
            // 
            this.btnModificar1.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar1.Location = new System.Drawing.Point(131, 363);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(100, 33);
            this.btnModificar1.TabIndex = 2;
            this.btnModificar1.Text = "Modificar";
            this.btnModificar1.UseVisualStyleBackColor = false;
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar1.Location = new System.Drawing.Point(247, 363);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(100, 33);
            this.btnEliminar1.TabIndex = 3;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(234, 71);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txBoxBuscar
            // 
            this.txBoxBuscar.Location = new System.Drawing.Point(283, 68);
            this.txBoxBuscar.Name = "txBoxBuscar";
            this.txBoxBuscar.Size = new System.Drawing.Size(240, 20);
            this.txBoxBuscar.TabIndex = 5;
            this.txBoxBuscar.TextChanged += new System.EventHandler(this.txBoxBuscar_TextChanged);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.Control;
            this.btnMarcas.Location = new System.Drawing.Point(15, 12);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(100, 35);
            this.btnMarcas.TabIndex = 7;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(121, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Categorias";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pboxArticulos
            // 
            this.pboxArticulos.Location = new System.Drawing.Point(545, 100);
            this.pboxArticulos.Name = "pboxArticulos";
            this.pboxArticulos.Size = new System.Drawing.Size(243, 244);
            this.pboxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxArticulos.TabIndex = 9;
            this.pboxArticulos.TabStop = false;
            // 
            // lblBuscarX
            // 
            this.lblBuscarX.AutoSize = true;
            this.lblBuscarX.Location = new System.Drawing.Point(9, 71);
            this.lblBuscarX.Name = "lblBuscarX";
            this.lblBuscarX.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarX.TabIndex = 11;
            this.lblBuscarX.Text = "Buscar:";
            // 
            // cbBusquedaX
            // 
            this.cbBusquedaX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusquedaX.FormattingEnabled = true;
            this.cbBusquedaX.Location = new System.Drawing.Point(58, 68);
            this.cbBusquedaX.Name = "cbBusquedaX";
            this.cbBusquedaX.Size = new System.Drawing.Size(142, 21);
            this.cbBusquedaX.TabIndex = 12;
            this.cbBusquedaX.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.cbBusquedaX);
            this.Controls.Add(this.lblBuscarX);
            this.Controls.Add(this.pboxArticulos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.txBoxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnModificar1);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.dgvPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARTICULOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnModificar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txBoxBuscar;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pboxArticulos;
        private System.Windows.Forms.Label lblBuscarX;
        private System.Windows.Forms.ComboBox cbBusquedaX;
    }
}

