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
using Negocio;

namespace TPWunForm_Equipo5B
{
    public partial class insertarMarca : Form
    {
        private Marca marca = null;
        public insertarMarca(Marca seleccionado)
        {
            InitializeComponent();
            this.marca = seleccionado;
            Text = "Modificar";
        }

        public insertarMarca()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(tbinsertarMarca.Text))
                {
                    MessageBox.Show("No se ingreso nada, por favor complete el casillero.");
                    return;
                }

                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Descripcion = tbinsertarMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.ModificarMarca(marca);
                    MessageBox.Show("Marca modificada");
                }
                else
                {
                    negocio.AgregarMarca(marca);
                    MessageBox.Show("Marca agregada");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void insertarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                tbinsertarMarca.Text = marca.Descripcion;
            }
        }

        private void btnCancelarInsertarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
