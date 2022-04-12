using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;
        private readonly InstrumentoService _instrumentoService;

        EmpresaDto empresaSeleccionada;
        public InstrumentoDto NuevoInstrumento { get; set; }

        List<ClasificacionDto> clasificaciones = new List<ClasificacionDto>();
        List<TipoInstrumentoDto> tiposInstrumentos = new List<TipoInstrumentoDto>();
        List<MarcaDto> marcas = new List<MarcaDto>();
        List<ModeloDto> modelos = new List<ModeloDto>();

        public frmNuevoInstrumento(ClasificacionInstrumentoService clasificacionInstrumentoService, InstrumentoService instrumentoService)
        {
            InitializeComponent();

            _clasificacionInstrumentoService = clasificacionInstrumentoService;
            _instrumentoService = instrumentoService;

            CargarClasificacionesDeInstrumentos();

            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();

            NuevoInstrumento = new InstrumentoDto();

        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoAgregarInstrumento.lblTitulo.Text = "Agregar Instrumento";
            ctlEncabezadoAgregarInstrumento.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            empresaSeleccionada = empresa;
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevoInstrumentoParaGuardar();

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (GuardarInstrumento())
            {
                Notificaciones.MensajeConfirmacion("¡El instrumento se ha registrado exitosamente!");

                OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
                this.Close();
            }
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            var frmEmpresas = serviceProvider.GetService<frmEmpresas>();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private void CargarClasificacionesDeInstrumentos()
        {


            var resultado = _clasificacionInstrumentoService.ObtenerClasificacionesActivas();
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }


            if (clasificaciones != null)
            {
                clasificaciones.ForEach(x => x.DescripcionCompuesta = $"{x.TipoInstrumento.Descripcion} / {x.Marca.Descripcion} / {x.Modelo.Descripcion}");
            }

            marcas = clasificaciones.Select(x => x.Marca).ToList();
            modelos = clasificaciones.Select(x => x.Modelo).ToList();
            tiposInstrumentos = clasificaciones.Select(x => x.TipoInstrumento).ToList();

            AsignarConfiguracionComboBoxes();
        }

        private bool GuardarInstrumento()
        {

            try
            {
                var resultado = _instrumentoService.RegistrarInstrumento(NuevoInstrumento);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(Exceptions.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void AsignarConfiguracionComboBoxes()
        {
            glTipoInstrumento.Properties.DataSource = tiposInstrumentos;
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
            glTipoInstrumento.Properties.DisplayMember = "Descripcion";

            glMarcas.Properties.DataSource = marcas;
            glMarcas.Properties.ValueMember = "MarcaId";
            glMarcas.Properties.DisplayMember = "Descripcion";

            glModelos.Properties.DataSource = modelos;
            glModelos.Properties.ValueMember = "ModeloId";
            glModelos.Properties.DisplayMember = "Descripcion";
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoInstrumento.NombreEmpresa))
            {
                mensaje = "Es necesario ingresar un nombre de empresa para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoInstrumento.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el instrumento.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void PrepararNuevoInstrumentoParaGuardar()
        {
            var tipoInstrumentoSeleccionado = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            var marcaSeleccionada = glMarcas.GetSelectedDataRow() as MarcaDto;
            var modeloSeleccionado = glModelos.GetSelectedDataRow() as ModeloDto;

            if (tipoInstrumentoSeleccionado == null || marcaSeleccionada == null || modeloSeleccionado == null)
            {
                MessageBox.Show("Es necesario que rellene campos obligatorios, para poder continuar.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var clasificacionSegunFiltrosSeleccionados = clasificaciones.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId &&
                                                                                             x.MarcaId == marcaSeleccionada.MarcaId &&
                                                                                             x.ModeloId == modeloSeleccionado.ModeloId);

            if (clasificacionSegunFiltrosSeleccionados == null)
            {
                MessageBox.Show("No se pudo encontrar una clasificación con el tipo de instrumento, marca y modelo seleccionados.", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = empresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.ClasificacionId = clasificacionSegunFiltrosSeleccionados.ClasificacionId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.Value;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.Value;
            NuevoInstrumento.Garantia = txtGarantia.Text;
        }

        private void glTipoInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            var tipoInstrumentoSeleccionado = glTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            if (tipoInstrumentoSeleccionado != null)
            {
                marcas = clasificaciones.Where(x => x.TipoInstrumentoId.Equals(tipoInstrumentoSeleccionado.TipoInstrumentoId)).Select(x => x.Marca).ToList();
                glMarcas.Properties.DataSource = marcas;
            }
        }

        private void glMarcas_EditValueChanged(object sender, EventArgs e)
        {
            var marcaSeleccionada = glMarcas.GetSelectedDataRow() as MarcaDto;
            if (marcaSeleccionada != null)
            {
                modelos = clasificaciones.Where(x => x.MarcaId.Equals(marcaSeleccionada.MarcaId)).Select(x => x.Modelo).ToList();
                glModelos.Properties.DataSource = modelos;
            }
        }

        private void glModelos_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}