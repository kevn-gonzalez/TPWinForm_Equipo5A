using ClasesArt;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWunForm_Equipo5B
{
    public partial class insertarCategoria : Form
    {
        private Categoria categoria = null;
        public insertarCategoria(Categoria seleccionado)
        {
            InitializeComponent();
            this.categoria = seleccionado;
            Text = "Modificar";
        }
        public insertarCategoria()
        {
            InitializeComponent();
        }

        private void insertarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                tbinsertarCategoria.Text = categoria.Descripcion;
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(tbinsertarCategoria.Text))
                {
                    MessageBox.Show("No se ingreso nada, por favor complete el casillero.");
                    return;
                }

                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Descripcion = tbinsertarCategoria.Text;

                if (categoria.Id != 0)
                {
                    negocio.ModificarCategoria(categoria);
                    MessageBox.Show("Categoria modificada");
                }
                else
                {
                    negocio.AgregarCategoria(categoria);
                    MessageBox.Show("Categoria agregada");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarInsertarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
