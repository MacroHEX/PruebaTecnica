using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica
{
    public partial class Pedidos : Form
    {
        // Defino una variable con la url de la api
        string url = "https://localhost:7253/api/";

        public Pedidos()
        {
            InitializeComponent();
        }

        // Este es el metodo que se ejecuta al cargar el formulario
        private void Pedidos_Load(object sender, EventArgs e)
        {
            
        }

        // Este codigo solicita los datos al presionar el botón
        private async void btnLista_Click(object sender, EventArgs e)
        {
            try
            {
                // Este codigo trae la informacion de los prodcutos y la convierte en una lista para su visualización
                string respuesta = await GetHttp("productos/all");
                List<Detalles> lista = JsonConvert.DeserializeObject<List<Detalles>>(respuesta);
                dataGridView1.DataSource = lista;

                // Este codigo bindea la información de la lista a las columnas especificas
                dataGridView1.Columns[0].DataPropertyName = "codArt";
                dataGridView1.Columns[1].DataPropertyName = "descripcion";
                dataGridView1.Columns[2].DefaultCellStyle.NullValue = "0";
                dataGridView1.Columns[3].DataPropertyName = "precioUni";

                // Este codigo trae la informacion del cliente
                //respuesta = await GetHttp("clientes/all");
                //List<Cliente> lista2 = JsonConvert.DeserializeObject<List<Cliente>>(respuesta);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Servicio no inicializado.");
                this.Close();
            }
        }

        // Este metodo se encarga de la llamada HTTP
        public async Task<string> GetHttp(string request)
        {
            // Este codigo realiza una solicitud a una URI
            WebRequest oRequest = WebRequest.Create(url + request);
            WebResponse oResponse = oRequest.GetResponse();

            // Este codigo realiza una solicitud especifica de HTTP
            HttpWebRequest hRequest = (HttpWebRequest)WebRequest.Create(url + request);
            HttpWebResponse hResponse = (HttpWebResponse)hRequest.GetResponse();

            StreamReader sr = new StreamReader(oResponse.GetResponseStream());

            // Este codigo visualiza las descripciones de las solicitudes HTTP
            if (hResponse.StatusDescription == "OK")
            {
                MessageBox.Show("Datos recibidos con éxito");
            }

            return await sr.ReadToEndAsync();
        }

        #region 

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
