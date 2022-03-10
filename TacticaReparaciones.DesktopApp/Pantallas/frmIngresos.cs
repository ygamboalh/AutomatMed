using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        public frmIngresos()
        {
            InitializeComponent();
            EstablecerNombreYTituloDePantalla();
            CargarDatosDeEmpresas();
        }

        

        private async  void CargarDatosDeEmpresas()
        {
           
            var options = new RestClientOptions("http://localhost:65168")
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);

            var request = new RestRequest("/empresas",Method.Get);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.GetAsync(request);

            /*string api = "http://localhost:65168";
            RestClient restClient = new RestClient(api);
           

            var request = HttpHelper.Get("empresas", "", out string mensaje);
            if (mensaje != "Ok")
            {
                MessageBox.Show(mensaje, "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);
            }

                var response = restClient.ExecuteAsync<EmpresaDto>(request, CancellationToken.None).GetAwaiter().GetResult();
                if (response.StatusCode == 0)
                {
                    MessageBox.Show($"Error. {response.ErrorMessage}", "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("No se ha podido iniciar sesión.", "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show($"Error. {response.StatusDescription}", "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);           
                    return;
                }

                if (response.StatusCode == 0)
                {
                
                    MessageBox.Show("Se agoto el tiempo de conexión.", "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!response.IsSuccessful)
                {
                    MessageBox.Show(response.StatusDescription, "Falla en Respuesta HTTP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            var data = response.Data;*/
        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "Ingresos";
            this.Text = titulo;
            this.ctlEncabezadoPantalla1.lblTitulo.Text = titulo;
            this.ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, System.EventArgs e)
        {

        }

        private void frmIngresos_Load(object sender, System.EventArgs e)
        {

        }
    }
}

