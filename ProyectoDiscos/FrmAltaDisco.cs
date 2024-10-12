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
using System.Configuration;
using System.IO;


namespace ProyectoDiscos
{
    public partial class FrmAltaDisco : Form
    {

        private Disco disco = null;
        private OpenFileDialog archivo = null;
        public FrmAltaDisco()
        {
            InitializeComponent();
        }

        public FrmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscoDato discoDato = new DiscoDato();

            try
            {   
                if(disco == null) 
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFecha.Value;
                disco.CantidadCanciones = int.Parse(txtCantidad.Text);
                disco.UrlImagenTapa = txtUrlImagen.Text;
                disco.Genero = (Estilo)cboEstilo.SelectedItem;
                disco.Formato = (TipoEdicion)cboTipoEdicion.SelectedItem;


                if (disco.Id != 0)
                {

                    discoDato.modificar(disco);
                    MessageBox.Show("Agregado exitosamente");

                }
                else
                {
                    discoDato.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                    }
                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaDisco_Load(object sender, EventArgs e)
        {
            TipoEdicionDato tipoEdicionDato = new TipoEdicionDato();
            EstiloDato estiloDato = new EstiloDato();
            try
            {
                cboTipoEdicion.DataSource = tipoEdicionDato.listar();
                cboTipoEdicion.ValueMember = "Id";
                cboTipoEdicion.DisplayMember = "Descripcion";
                cboEstilo.DataSource = estiloDato.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFecha.Value = disco.FechaLanzamiento;
                    txtCantidad.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboTipoEdicion.SelectedValue = disco.Formato.id;
                    cboEstilo.SelectedValue = disco.Genero.id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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

        private void btnagregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png;|jpeg|*.jpeg";
            
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);


                
            }
        }
    }



}
