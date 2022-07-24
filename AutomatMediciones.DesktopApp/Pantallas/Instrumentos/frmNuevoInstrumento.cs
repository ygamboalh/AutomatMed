using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        public delegate void InstrumentoModificado(InstrumentoDto instrumento);
        public event InstrumentoModificado OnInstrumentoModificado;

        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;
        private readonly InstrumentoService _instrumentoService;
        private readonly MarcaService _marcaService;
        private readonly ModeloService _modeloService;
        private readonly TipoDeInstrumentoService _tipoDeInstrumentoService;
        private readonly EmpresaService _empresaService;
        private readonly CeldaService _celdaService;

        public TipoTransaccion TipoTransaccion { get; set; }

        private EmpresaDto EmpresaSeleccionada { get; set; }

        public InstrumentoDto NuevoInstrumento { get; set; }

        List<ClasificacionDto> clasificaciones = new List<ClasificacionDto>();
        List<TipoInstrumentoDto> tiposInstrumentos = new List<TipoInstrumentoDto>();
        List<MarcaDto> marcas = new List<MarcaDto>();
        List<ModeloDto> modelos = new List<ModeloDto>();
        List<CeldaDto> celdas = new List<CeldaDto>();


        ctlEncabezadoPantalla ctlEncabezadoPantalla3;

        public frmNuevoInstrumento(TipoTransaccion tipoTransaccion,
                                   ClasificacionInstrumentoService clasificacionInstrumentoService,
                                   InstrumentoService instrumentoService,
                                   MarcaService marcaService,
                                   ModeloService modeloService,
                                   TipoDeInstrumentoService tipoDeInstrumentoService,
                                   EmpresaService empresaService,
                                   CeldaService celdaService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;

            if (TipoTransaccion == TipoTransaccion.Actualizar)
            {
                btnNuevaVinculacion.Visible = true;
                btnPrepararCertificado.Visible = true;
                btnHistorialDeCertificados.Visible = true;
            }
            _clasificacionInstrumentoService = clasificacionInstrumentoService;
            _instrumentoService = instrumentoService;
            _marcaService = marcaService;
            _modeloService = modeloService;
            _tipoDeInstrumentoService = tipoDeInstrumentoService;
            _empresaService = empresaService;
            _celdaService = celdaService;
            CargarClasificacionesDeInstrumentos();
            CargarCeldas();

            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonPorDefecto();

            NuevoInstrumento = new InstrumentoDto();

            btnEditar.Click += btnEditarClick;
            btnDesactivar.Click += btnDesactivarClick;
            btnDesactivarRegistro.Click += btnDesactivarRegistroVariable;

        }

        private void btnDesactivarRegistroVariable(object sender, EventArgs e)
        {
            var variableInstrumento = gvVariablesInstrumentos.GetFocusedRow() as VariableInstrumentoDto;
            if (variableInstrumento == null) return;

            var respuesta = _instrumentoService.DesactivarVariableInstrumento(variableInstrumento.VariableInstrumentoId);
            if (respuesta.Type != TypeResponse.Ok) 
            {
                Notificaciones.MensajeError(respuesta.Message);
                return;
            }

            CargarVariablesInstrumentos();
            Notificaciones.MensajeConfirmacion("¡La vinculación se eliminó exitosamente!");
        }

        private void btnDesactivarClick(object sender, EventArgs e)
        {
            var celdaInstrumento = gvCeldasVinculadas.GetFocusedRow() as CeldaInstrumentoDto;
            if (celdaInstrumento == null) return;

            if (celdaInstrumento.Id == 0)
            {
                NuevoInstrumento.CeldasInstrumentos = NuevoInstrumento.CeldasInstrumentos.Where(x => x.CeldaId != celdaInstrumento.CeldaId).ToList();
                gcCeldasVinculadas.DataSource = NuevoInstrumento.CeldasInstrumentos;
                gcCeldasVinculadas.RefreshDataSource();
                return;
            }


            var frmExtraccion = new frmExtraccionCelda(serviceProvider.GetService<InstrumentoService>());
            frmExtraccion.CeldaInstrumento = celdaInstrumento;
            frmExtraccion.ShowDialog();


        }

        private void btnEditarClick(object sender, EventArgs e)
        {
            var variableInstrumento = gvVariablesInstrumentos.GetFocusedRow() as VariableInstrumentoDto;
            if (variableInstrumento == null) return;

            var frmNuevaVariableMedicion = new frmInstrumentoVariable(TipoTransaccion.Actualizar, serviceProvider.GetService<InstrumentoService>(), serviceProvider.GetService<VariableMedicionService>());

            frmNuevaVariableMedicion.NuevaVariableInstrumento = variableInstrumento;
            frmNuevaVariableMedicion.SetearValoresParaActualizar();
            frmNuevaVariableMedicion.OnVariableInstrumentoActualizada += OnVariableMedicionModificada;
            frmNuevaVariableMedicion.ShowDialog();
        }

        private void OnVariableMedicionModificada(VariableInstrumentoDto variableInstrumentoDto)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            CargarVariablesInstrumentos();
        }

        public void SetearValoresParaActualizar()
        {
            memoComentarios.Text = NuevoInstrumento.Comentarios;
            txtDescripcionInstrumento.Text = NuevoInstrumento.Descripcion;
            txtEmpresaInstrumento.Text = NuevoInstrumento.NombreEmpresa;
            leTipoInstrumento.EditValue = NuevoInstrumento.Clasificacion.TipoInstrumentoId;
            leMarcas.EditValue = NuevoInstrumento.Clasificacion.MarcaId;
            leModelos.EditValue = NuevoInstrumento.Clasificacion.ModeloId;
            txtNumeroSerie.Text = NuevoInstrumento.NumeroSerie;
            dateFechaCompraCliente.EditValue = NuevoInstrumento.FechaCompraCliente.HasValue ? NuevoInstrumento.FechaCompraCliente.Value : null;
            dateFechaCompraFabricante.EditValue = NuevoInstrumento.FechaCompraFabricante.HasValue ? NuevoInstrumento.FechaCompraCliente.Value : null;
            nmGarantia.Value = NuevoInstrumento.Garantia;

            EmpresaSeleccionada = _empresaService.ObtenerEmpresaPorId(NuevoInstrumento.EmpresaId).Data;

            gcCeldasVinculadas.DataSource = NuevoInstrumento.CeldasInstrumentos;
            gcCeldasVinculadas.RefreshDataSource();

        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Instrumento" : "Editar Instrumento";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        public void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            if (empresa == null) return;

            EmpresaSeleccionada = empresa;
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            if (!PrepararNuevoInstrumentoParaGuardar())
            {
                return;
            }

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                CargarClasificacionesDeInstrumentos();
                NuevoInstrumento.Clasificacion = clasificaciones.FirstOrDefault(x => x.ClasificacionId == NuevoInstrumento.ClasificacionId);

                SplashScreenManager.ShowForm(typeof(frmLoadingSave));
                if (GuardarInstrumento())
                {
                    Notificaciones.MensajeConfirmacion("¡El instrumento se ha registrado exitosamente!");
                    OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
                    this.Close();
                }
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(frmLoadingSave));
                if (ActualizarInstrumento())
                {
                    Notificaciones.MensajeConfirmacion("¡El instrumento se ha actualizado exitosamente!");
                    OnInstrumentoModificado?.Invoke(NuevoInstrumento);
                    this.Close();
                }

                SplashScreenManager.CloseForm();
            }


        }



        private bool ActualizarInstrumento()
        {
            try
            {
                var resultado = _instrumentoService.ActualizarInstrumento(NuevoInstrumento);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
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

            PrepararDataSourceClasificaciones(resultado.Data);
        }

        private void CargarCeldas()
        {
            var resultado = _celdaService.ObtenerCeldas();
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }

            celdas = resultado.Data;

            leCelda.Properties.DataSource = celdas;
            leCelda.Properties.DisplayMember = "TipoCelda.Descripcion";
            leCelda.Properties.ValueMember = "Id";
        }


        private void PrepararDataSourceClasificaciones(List<ClasificacionInstrumentoDto> clasificacionInstrumentos)
        {
            clasificaciones.Clear();
            clasificacionInstrumentos.ForEach(x =>
            {
                ClasificacionDto clasificacionDto = new ClasificacionDto
                {
                    Activo = x.Activo,
                    ClasificacionId = x.ClasificacionId,
                    MarcaId = x.MarcaId,
                    ModeloId = x.ModeloId,
                    TipoInstrumentoId = x.TipoInstrumentoId,
                    DescripcionCompuesta = $"{x.TipoInstrumento.Descripcion} / {x.Marca.Descripcion} / {x.Modelo.Descripcion}",
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    PeriodoDeCalibracion = x.PeriodoDeCalibracion,
                    TipoInstrumento = x.TipoInstrumento
                };

                clasificaciones.Add(clasificacionDto);
            });

            tiposInstrumentos = clasificaciones.GroupBy(y => y.TipoInstrumentoId).Select(x => x.First().TipoInstrumento).ToList();
            marcas = clasificaciones.GroupBy(y => y.MarcaId).Select(x => x.First().Marca).Distinct().ToList();
            modelos = clasificaciones.GroupBy(y => y.ModeloId).Select(x => x.First().Modelo).Distinct().ToList();

            AsignarConfiguracionComboBoxes();
        }

        private bool GuardarInstrumento()
        {

            try
            {
                var resultado = _instrumentoService.RegistrarInstrumento(NuevoInstrumento);
                if (resultado.Type == TypeResponse.ErrorValidation)
                {
                    if (Notificaciones.PreguntaConfirmacion($"{resultado.Message} ¿Desea actualizar la empresa vinculada al instrumento?") == DialogResult.Yes)
                    {
                        var instrumento = _instrumentoService.ObtenerInstrumento(NuevoInstrumento.Clasificacion.MarcaId, NuevoInstrumento.Clasificacion.ModeloId,
                                                                                 NuevoInstrumento.Clasificacion.TipoInstrumentoId, NuevoInstrumento.NumeroSerie);

                        TipoTransaccion = TipoTransaccion.Actualizar;
                        ctlEncabezadoPantalla3.lblTitulo.Text = "Editar Instrumento";

                        NuevoInstrumento = instrumento.Data;
                        CargarVariablesInstrumentos();
                        SetearValoresParaActualizar();
                    }
                    return false;
                }
                if (resultado.Type != TypeResponse.Ok && resultado.Type != TypeResponse.ErrorValidation)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                NuevoInstrumento = resultado.Data;
                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void AsignarConfiguracionComboBoxes()
        {
            leTipoInstrumento.Properties.DataSource = tiposInstrumentos;
            leTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
            leTipoInstrumento.Properties.DisplayMember = "Descripcion";

            leMarcas.Properties.DataSource = marcas;
            leMarcas.Properties.ValueMember = "MarcaId";
            leMarcas.Properties.DisplayMember = "Descripcion";

            leModelos.Properties.DataSource = modelos;
            leModelos.Properties.ValueMember = "ModeloId";
            leModelos.Properties.DisplayMember = "Descripcion";
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

        private bool PrepararNuevoInstrumentoParaGuardar()
        {
            var tipoInstrumentoSeleccionado = leTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            var marcaSeleccionada = leMarcas.GetSelectedDataRow() as MarcaDto;
            var modeloSeleccionado = leModelos.GetSelectedDataRow() as ModeloDto;

            if (tipoInstrumentoSeleccionado == null || marcaSeleccionada == null || modeloSeleccionado == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que rellene campos obligatorios, para poder continuar.");
                return false;
            }

            var clasificacionSegunFiltrosSeleccionados = clasificaciones.FirstOrDefault(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId &&
                                                                                             x.MarcaId == marcaSeleccionada.MarcaId &&
                                                                                             x.ModeloId == modeloSeleccionado.ModeloId);

            if (clasificacionSegunFiltrosSeleccionados == null)
            {
                Notificaciones.MensajeAdvertencia("No se pudo encontrar una clasificación con el tipo de instrumento, marca y modelo seleccionados.");

                return false;
            }

            NuevoInstrumento.Comentarios = memoComentarios.Text;
            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = EmpresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = EmpresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.ClasificacionId = clasificacionSegunFiltrosSeleccionados.ClasificacionId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.EditValue != null ? (DateTime)dateFechaCompraFabricante.EditValue : null;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.EditValue != null ? (DateTime)dateFechaCompraCliente.EditValue : null;
            NuevoInstrumento.Garantia = (int)nmGarantia.Value;

            return true;
        }

        private void glTipoInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            var tipoInstrumentoSeleccionado = leTipoInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            if (tipoInstrumentoSeleccionado != null)
            {
                marcas = clasificaciones.Where(x => x.TipoInstrumentoId.Equals(tipoInstrumentoSeleccionado.TipoInstrumentoId)).Select(x => x.Marca).ToList();
                leMarcas.Properties.DataSource = marcas;
            }
        }

        private void glMarcas_EditValueChanged(object sender, EventArgs e)
        {
            var marcaSeleccionada = leMarcas.GetSelectedDataRow() as MarcaDto;
            if (marcaSeleccionada != null)
            {
                modelos = clasificaciones.Where(x => x.MarcaId.Equals(marcaSeleccionada.MarcaId)).Select(x => x.Modelo).ToList();
                leModelos.Properties.DataSource = modelos;
            }
        }

        private void btnAgregarClasificacion_Click(object sender, EventArgs e)
        {
            var frmClasificaciones = new frmNuevaClasificacion(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>(), serviceProvider.GetService<MarcaService>(),
                serviceProvider.GetService<ModeloService>(), serviceProvider.GetService<TipoDeInstrumentoService>());

            frmClasificaciones.OnClasificacionInstrumentoAgregada += OnClasificacionInstrumentoAgregada;
            frmClasificaciones.Modelos = CargarModelos();
            frmClasificaciones.Marcas = CargarMarcas();
            frmClasificaciones.TiposDeInstrumento = CargarTiposDeInstrumentos();
            frmClasificaciones.InicializarMaestros();
            frmClasificaciones.Show();
        }

        private List<MarcaDto> CargarMarcas()
        {
            var resultado = _marcaService.ObtenerMarcas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var marcasRespuesta = resultado.Data;
            return marcasRespuesta;

        }

        private List<ModeloDto> CargarModelos()
        {
            var resultado = _modeloService.ObtenerModelos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            return modelosRespuesta;

        }

        private List<TipoInstrumentoDto> CargarTiposDeInstrumentos()
        {
            var resultado = _tipoDeInstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void OnClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto tipoInstrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            CargarClasificacionesDeInstrumentos();
            this.Focus();
        }

        private void btnAbrirPopupEmpresaPorInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAbrirPopupEmpresaPorInstrumento, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnAgregarClasificacion_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAgregarClasificacion, "Presione para ir la a pantalla que le permite agregar una nueva clasificación");
        }

        private void btnNuevaVinculacion_Click(object sender, EventArgs e)
        {
            if (TipoTransaccion == TipoTransaccion.Actualizar)
            {
                frmInstrumentoVariable frmInstrumentoVariable = new frmInstrumentoVariable(TipoTransaccion.Insertar, serviceProvider.GetService<InstrumentoService>(), serviceProvider.GetService<VariableMedicionService>());
                frmInstrumentoVariable.InstrumentoId = NuevoInstrumento.InstrumentoId;
                frmInstrumentoVariable.OnVariableInstrumentoAgregado += OnVariableInstrumentoAgregado;
                frmInstrumentoVariable.ShowDialog();
            }
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnNuevaVinculacion.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnNuevaVinculacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnNuevaVinculacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");

            btnPrepararCertificado.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnPrepararCertificado.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnPrepararCertificado.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void OnVariableInstrumentoAgregado(VariableInstrumentoDto variableInstrumentoDto)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            CargarVariablesInstrumentos();
        }

        public void CargarVariablesInstrumentos()
        {
            var resultado = _instrumentoService.ObtenerVariablesInstrumentos(NuevoInstrumento.InstrumentoId);
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }

            gcVariablesInstrumentos.DataSource = resultado.Data;
            gcVariablesInstrumentos.RefreshDataSource();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            var frmNuevoCertificadoCalibracion = new frmNuevoCertificadoCalibracion(NuevoInstrumento.InstrumentoId,
                serviceProvider.GetService<CertificadoCalibracionService>(),
                 serviceProvider.GetService<UsuarioService>(),
                 serviceProvider.GetService<PatronService>(),
                 serviceProvider.GetService<InstrumentoService>()
                );
            frmNuevoCertificadoCalibracion.ShowDialog();
        }

        private void txtEmpresaInstrumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serviceProvider = Program.services.BuildServiceProvider();
                var frmEmpresas = new frmEmpresas(serviceProvider.GetService<EmpresaService>());
                frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
                frmEmpresas.txtBusqueda.Text = txtEmpresaInstrumento.Text;
                frmEmpresas.CargarDatosDeEmpresas();
                frmEmpresas.ShowDialog();
            }
        }

        private void btnAgregarCelda_Click(object sender, EventArgs e)
        {
            if (leCelda.EditValue == null || string.IsNullOrEmpty(leCelda.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una celda para vincularla al instrumento.");
                return;
            }

            if (string.IsNullOrEmpty(dateFechaColocacion.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que ingrese una fecha de colocación para la celda.");
                return;
            }

            var celdaSeleccionada = celdas.FirstOrDefault(x => x.Id == (int)leCelda.EditValue);
            if (celdaSeleccionada == null)
            {
                Notificaciones.MensajeAdvertencia($"No fue posible encontrar una Celda en almacén de datos, que coincida con Celda seleccionada: {leCelda.EditValue}.");
                return;
            }

            if (NuevoInstrumento.CeldasInstrumentos.Any(x => x.CeldaId == celdaSeleccionada.Id))
            {
                Notificaciones.MensajeAdvertencia($"La celda seleccionada ya está vinculada a este instrumento.");
                return;
            }

            NuevoInstrumento.CeldasInstrumentos.Add(new CeldaInstrumentoDto
            {
                CeldaId = celdaSeleccionada.Id,
                FechaColocacion = (DateTime)dateFechaColocacion.EditValue,
                Celda = celdaSeleccionada
            });

            gcCeldasVinculadas.DataSource = NuevoInstrumento.CeldasInstrumentos;
            gcCeldasVinculadas.RefreshDataSource();

        }

        private void btnHistorialDeCertificados_Click(object sender, EventArgs e)
        {

            var frmHistorialCertificados = new frmCertificadosDeCalibracion(serviceProvider.GetService<CertificadoCalibracionService>());
            frmHistorialCertificados.InstrumentoId = NuevoInstrumento.InstrumentoId;
            frmHistorialCertificados.CargarCertificadosDeCalibracionPorInstrumento();
            frmHistorialCertificados.ShowDialog();
        }
    }
}