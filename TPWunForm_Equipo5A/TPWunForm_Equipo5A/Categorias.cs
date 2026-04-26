using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesArt;

namespace TPWunForm_Equipo5B
{
    public partial class Categorias : Form
    {
        private List<Categoria> listaCategorias;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void cargarCategoria()
        {
            try
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                listaCategorias = negocio.listarCategoria();
                dgvCategorias.DataSource = listaCategorias;
                dgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnInsertarCategoria_Click(object sender, EventArgs e)
        {
            insertarCategoria insertar = new insertarCategoria();
            insertar.ShowDialog();
            cargarCategoria();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado;
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                insertarCategoria insertar = new insertarCategoria(seleccionado);
                insertar.ShowDialog();
                cargarCategoria();
            }
            else
            {
                MessageBox.Show("Ninguna categoria seleccionada, por favor, seleccione una.");
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                CategoriaNegocio neg = new CategoriaNegocio();
                Categoria seleccionado;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar esta categoria?", "Eliminando categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                        if (neg.categoriaEnUso(seleccionado.Id))
                        {
                            MessageBox.Show("No se puede eliminar esta categoria por que hay articulos que la usan. Elimine los articulos o cambieles la categoria.");
                        }
                        else
                        {
                            neg.eliminarCategoria(seleccionado.Id);
                            MessageBox.Show("Categoria eliminada de la lista");
                        }
                        cargarCategoria();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnVolverCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
