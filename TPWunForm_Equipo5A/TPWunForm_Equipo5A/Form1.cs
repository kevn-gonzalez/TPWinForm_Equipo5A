using Negocio;
using ClasesArt;
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
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
       

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbBusquedaX.Items.Add("todos");
            cbBusquedaX.Items.Add("por nombre");
            cbBusquedaX.Items.Add("por descripcion");
            cbBusquedaX.Items.Add("por marca");
            cbBusquedaX.Items.Add("por categoria");
            cbBusquedaX.SelectedIndex = 0;
            cargar();
        }
        private void txBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaParcial;
            string filtro = txBoxBuscar.Text;
            if (filtro.Length >1 )
            {
                string seleccion = cbBusquedaX.SelectedItem.ToString();
                switch (seleccion)
                {
                    case "por nombre":
                        {
                        listaParcial = listaArticulos.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    case "por descripcion":
                        {
                            listaParcial = listaArticulos.FindAll(item => item.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    case "por marca":
                        {
                            listaParcial = listaArticulos.FindAll(item => item.IdMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    case "por categoria":
                        {
                            listaParcial = listaArticulos.FindAll(item => item.IdCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    default:
                        listaParcial = listaArticulos.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()) || item.Descripcion.ToUpper().Contains(filtro.ToUpper()) || item.IdCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || item.IdMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                        break;
                }
            }
            else
            {
                listaParcial = listaArticulos;
            }

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = listaParcial;
            ocultar();
        }

        private void cargar()
        {
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                listaArticulos = negocio.Listar();
                dgvPrincipal.DataSource = listaArticulos;
                dgvPrincipal.Columns["Precio"].DefaultCellStyle.Format = "N2";
                ocultar();
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }



        private void ocultar()
        {
            dgvPrincipal.Columns["ImagenUrl"].Visible = false;
            dgvPrincipal.Columns["Id"].Visible = false;
        }



        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
            Articulos seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxArticulos.Load("https://ih1.redbubble.net/image.1693090018.7934/pp,504x498-pad,600x600,f8f8f8.jpg");
            }
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            Agregar alta = new Agregar();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
            
            Agregar modificar = new Agregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            ArticulosNegocio neg = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta a punto de eliminar un articulo. ¿Esta seguro?", "Eliminando articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
                    neg.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Marcas alta = new Marcas();
            alta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Categorias alta = new Categorias();
            alta.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
