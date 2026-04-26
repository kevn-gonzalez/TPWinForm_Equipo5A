using ClasesArt;
using System;
using System.Windows.Forms;
using Negocio;
using System.IO;
using System.Configuration;

namespace TPWunForm_Equipo5B
{
    public partial class Agregar : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public Agregar()
        {
            InitializeComponent();
        }
        public Agregar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
        }


        private void btnCancelar_agregar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool soloNumeros(string cadena)
        {
            if (string.IsNullOrEmpty(tbPrecioAg.Text))
            {
                MessageBox.Show("El campo de Precio no debe estar vacio");
                return false;
            }

            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter))
                {
                    MessageBox.Show("Ingrese solo números en el campo 'Precio'");
                    return false;
                }
            }
            return true;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        { 
            ArticulosNegocio neg = new ArticulosNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(tbCodartAg.Text))
                {
                    MessageBox.Show("No se ingreso ningun codigo, por favor insertelo.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbNombreAg.Text))
                {
                    MessageBox.Show("No se ingreso ningun nombre, por favor insertelo.");
                    return;
                }

                if (!(soloNumeros(tbPrecioAg.Text)))
                {
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulos();
                }
                articulo.Codigo = tbCodartAg.Text;
                articulo.Nombre = tbNombreAg.Text;
                articulo.Descripcion = tbDescripcionAg.Text;
                articulo.Precio = decimal.Parse(tbPrecioAg.Text);
                articulo.ImagenUrl = tbUrlAg.Text;
                articulo.IdMarca = (Marca)cbMarcaAg.SelectedItem;
                articulo.IdCategoria = (Categoria)cbCategoriaAg.SelectedItem;

                if (articulo.Id != 0)
                {
                    neg.Modificar(articulo);
                    MessageBox.Show("Articulo modificado");
                }
                else
                {
                    neg.Agregar(articulo);
                    MessageBox.Show("Articulo agregado");
                }

                if (archivo != null && !(tbUrlAg.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagen"] + archivo.SafeFileName);
                }

                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbMarcaAg.DataSource = marcaNegocio.listarmarcas();
                cbCategoriaAg.ValueMember = "Id";
                cbCategoriaAg.DisplayMember = "Descripcion";
                cbMarcaAg.ValueMember = "Id";
                cbMarcaAg.DisplayMember = "Descripcion";
                cbCategoriaAg.DataSource = categoriaNegocio.listarCategoria();

                if(articulo != null)
                {
                    tbCodartAg.Text = articulo.Codigo;
                    tbNombreAg.Text = articulo.Nombre;
                    tbDescripcionAg.Text = articulo.Descripcion;

                    tbPrecioAg.Text = articulo.Precio.ToString(); 
                    
                    tbUrlAg.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    if (articulo.IdCategoria != null)
                    {
                        cbCategoriaAg.SelectedValue = articulo.IdCategoria.Id;
                    }
                    if (articulo.IdMarca != null)
                    {
                        cbMarcaAg.SelectedValue = articulo.IdMarca.Id;
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbUrlAg_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbUrlAg.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboxAg.Load(imagen);
            }
            catch (Exception ex)
            {
                pboxAg.Load("https://ih1.redbubble.net/image.1693090018.7934/pp,504x498-pad,600x600,f8f8f8.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            try
            {
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    tbUrlAg.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void tbPrecioAg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
