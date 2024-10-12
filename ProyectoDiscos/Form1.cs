using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using data; 


namespace ProyectoDiscos
{
    public partial class Form1 : Form

       
    {
        private List<Disco> listaDisco;
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Titulo");
            cboCampo.Items.Add("FechaLanzamiento");
            cboCampo.Items.Add("CantidadCanciones");
        }

        private void dataGridDisco_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridDisco.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dataGridDisco.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        private void cargar()
        {
            DiscoDato dato = new DiscoDato();
            try
            {
                listaDisco = dato.listar();
                dataGridDisco.DataSource = listaDisco;
                ocultarColumnas();
                cargarImagen(listaDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void ocultarColumnas()
        {
            dataGridDisco.Columns["UrlImagenTapa"].Visible = false;
            dataGridDisco.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxDisco.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxDisco.Load("https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?t=st=1725326394~exp=1725329994~hmac=834bbc3e61a77a5c9576de7233133dafd0bbd4f512493002c0e257761b54f8ee&w=740");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaDisco alta = new FrmAltaDisco();
            alta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dataGridDisco. CurrentRow.DataBoundItem;

            FrmAltaDisco alta = new FrmAltaDisco(seleccionado);
            alta.ShowDialog();
            cargar();
        }

        private void btneliminarFisico_Click(object sender, EventArgs e)
        {


            DiscoDato dato = new DiscoDato();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dataGridDisco.CurrentRow.DataBoundItem;
                    dato.eliminar(seleccionado.Id);
                    cargar();

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un campo y un criterio.");
                return;
            }

            DiscoDato disco = new DiscoDato();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtfiltroAvanzado.Text;
                dataGridDisco.DataSource = disco.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {

                listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Genero.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaDisco;

            }

            dataGridDisco.DataSource = null;
            dataGridDisco.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Titulo")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
            if(opcion == "CantidadCanciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            if (opcion == "FechaLanzamiento")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Año Mayor a");
                cboCriterio.Items.Add("Año Menor a");
                cboCriterio.Items.Add("Año Igual a");
            }



        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar solo los campos de texto del filtro rápido y avanzado
                txtfiltroAvanzado?.Clear();
                txtFiltro?.Clear();

                // Obtener todos los registros sin filtro
                DiscoDato disco = new DiscoDato();
                dataGridDisco.DataSource = disco.Restablecer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restablecer los filtros: " + ex.Message);
            }
        }



    }
}
