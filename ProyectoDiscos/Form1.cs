using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DiscoDato dato = new DiscoDato();
            listaDisco = dato.listar();
            dataGridDisco.DataSource = listaDisco;
            dataGridDisco.Columns["UrlImagenTapa"].Visible = false;
            cargarImagen(listaDisco[0].UrlImagenTapa);

            
        }

        private void dataGridDisco_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dataGridDisco.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
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


    }
}
