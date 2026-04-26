using ClasesArt;
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

namespace TPWunForm_Equipo5B
{
    public partial class Marcas : Form
    {
        private List<Marca> listaMarcas;
        public Marcas()
        {
            InitializeComponent();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionado;
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                insertarMarca insertar = new insertarMarca(seleccionado);
                insertar.ShowDialog();
                cargarMarca();
            }
            else
            {
                MessageBox.Show("Ninguna marca seleccionada, por favor, seleccione una.");
            }
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }
        private void cargarMarca()
        {
            try
            {
                MarcaNegocio negocio = new MarcaNegocio();
                listaMarcas = negocio.listarmarcas();
                dgvMarcas.DataSource = listaMarcas;
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnInsertarMarca_Click(object sender, EventArgs e)
        {
            insertarMarca insertar = new insertarMarca();
            insertar.ShowDialog();
            cargarMarca();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                MarcaNegocio neg = new MarcaNegocio();
                Marca seleccionado;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Esta seguro que quiere eliminar esta marca?", "Eliminando marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                        if (neg.marcaEnUso(seleccionado.Id))
                        {
                            MessageBox.Show("No se puede eliminar la marca por que hay articulos que la usan. Elimine los articulos o cambieles la marca.");
                        }
                        else
                        {
                        neg.eliminarMarca(seleccionado.Id);
                        MessageBox.Show("Marca eliminada de la lista");
                        }
                        cargarMarca();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnVolverMarcas_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
