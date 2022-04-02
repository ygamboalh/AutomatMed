using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas.Clasificaciones
{
    public partial class frmClasificaciones : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<ClasificacionInstrumentoDto> clasificaciones = new List<ClasificacionInstrumentoDto>();
        ICollection<ModeloDto> modelos = new List<ModeloDto>();
        ICollection<MarcaDto> marcas = new List<MarcaDto>();
        ICollection<TipoInstrumentoDto> tiposDeInstrumento = new List<TipoInstrumentoDto>();

        public frmClasificaciones()
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarClasificaciones();
            CargarMarcas();
            CargarModelos();
            CargarTiposDeInstrumentos();

            cmdEditar.Click += OnSeleccionaMarcaParaModificar;
        }

        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var clasificacionInstrumento = gvClasificaciones.GetFocusedRow() as ClasificacionInstrumentoDto;
            frmNuevaClasificacion frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Actualizar);
            frmNuevaClasificacion.NuevaClasificacion = clasificacionInstrumento;
            frmNuevaClasificacion.modelos = modelos;
            frmNuevaClasificacion.marcas = marcas;
            frmNuevaClasificacion.tiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.SetearValoresParaActualizar();
            frmNuevaClasificacion.OnClasificacionInstrumentoModificada += OnClasificacionInstrumentoModificada;
            frmNuevaClasificacion.Show();
        }

        private void OnClasificacionInstrumentoModificada(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            clasificaciones = clasificaciones.Where(x => x.ClasificacionId != clasificacionInstrumentoDto.ClasificacionId).ToList();
            clasificaciones.Add(clasificacionInstrumentoDto);

            gcClasificaciones.DataSource = clasificaciones;
            gcClasificaciones.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {clasificaciones.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla3.lblTitulo.Text = "Clasificaciones de Instrumentos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnNuevaClasificacion.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnNuevaClasificacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnNuevaClasificacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void CargarClasificaciones()
        {
            string uri = "/clasificaciones-instrumentos";
            var clasificacionesRespuesta = await HttpHelper.Get<ClasificacionInstrumentoDto>(rutaApi, uri, "");
            clasificaciones = clasificacionesRespuesta;

            gcClasificaciones.DataSource = clasificaciones;

            SetearTotales();
        }


        private async void CargarMarcas()
        {
            string uri = "/marcas";
            var marcasRespuesta = await HttpHelper.Get<MarcaDto>(rutaApi, uri, "");
            marcas = marcasRespuesta;

           

            SetearTotales();
        }


        private async void CargarModelos()
        {
            string uri = "/Modelos";
            var ModelosRespuesta = await HttpHelper.Get<ModeloDto>(rutaApi, uri, "");
            modelos = ModelosRespuesta;

         

            SetearTotales();
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-de-instrumento";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");
            tiposDeInstrumento = tiposDeInstrumentos;

        
            SetearTotales();
        }

        private void OnClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto clasificacionInstrumentoDto)
        {
            clasificaciones.Add(clasificacionInstrumentoDto);
            gcClasificaciones.DataSource = clasificacionInstrumentoDto;
            gcClasificaciones.RefreshDataSource();

            SetearTotales();
        }

        private void btnNuevaClasificacion_Click(object sender, EventArgs e)
        {
            frmNuevaClasificacion frmNuevaClasificacion = new frmNuevaClasificacion(TipoTransaccion.Insertar);
            frmNuevaClasificacion.OnClasificacionInstrumentoAgregada += OnClasificacionInstrumentoAgregada;
            frmNuevaClasificacion.modelos = modelos;
            frmNuevaClasificacion.marcas = marcas;
            frmNuevaClasificacion.tiposDeInstrumento = tiposDeInstrumento;
            frmNuevaClasificacion.InicializarMaestros();
            frmNuevaClasificacion.Show();
        }
    }
}