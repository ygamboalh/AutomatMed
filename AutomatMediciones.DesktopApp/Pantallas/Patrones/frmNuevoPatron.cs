using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    public partial class frmNuevoPatron : DevExpress.XtraEditors.XtraForm
    {
        private readonly PatronService _patronService;
        private readonly VariableMedicionService _variableMedicionService;

        public delegate void PatronAgregado(PatronDto patron);
        public event PatronAgregado OnPatronAgregado;

        public TipoTransaccion TipoTransaccion { get; set; }

        public PatronDto NuevoPatron { get; set; }
        public List<VariablePatronDto> VariablesPatrones { get; set; }

        VariableMedicionDto variableMedicionSeleccionada;


        public frmNuevoPatron(TipoTransaccion tipoTransaccion, PatronService patronService, VariableMedicionService variableMedicionService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;

            NuevoPatron = new PatronDto();

            VariablesPatrones = new List<VariablePatronDto>();

            _patronService = patronService;
            _variableMedicionService = variableMedicionService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            CargarVariablesDeMedicion();

            btnEliminar.Click += btnEliminarClick;
        }

        public void SetearValoresParaActualizar()
        {
            txtNombreRango.Text = NuevoPatron.Nombre;
            dateFechaCaducidad.Value = NuevoPatron.FechaCaducidad;
            txtRutaArchivo.Text = NuevoPatron.Link;

            VariablesPatrones = NuevoPatron.VariablesPatrones.ToList();
            gcVariablesDeMedicion.DataSource = VariablesPatrones;
            gcVariablesDeMedicion.RefreshDataSource();
        }

        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccioanda = gvVariablesDeMedicion.GetFocusedRow() as VariablePatronDto;
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                VariablesPatrones = VariablesPatrones.Where(x => x.VariableMeicionId != filaSeleccioanda.VariableMeicionId &&
                                                                 x.ValorPatron == filaSeleccioanda.ValorPatron &&
                                                                 x.Tolerancia == filaSeleccioanda.Tolerancia).ToList();


                gcVariablesDeMedicion.DataSource = VariablesPatrones;
                gcVariablesDeMedicion.RefreshDataSource();
            }
            else
            {
                if (filaSeleccioanda != null)
                {
                    var result = _patronService.DesactivarVariablePatron(filaSeleccioanda);
                    if (result.Type != TypeResponse.Ok)
                    {
                        Notificaciones.MensajeError(result.Message);
                        return;
                    }
                    VariablesPatrones = VariablesPatrones.Where(x => x.VariablePatronId != filaSeleccioanda.VariablePatronId).ToList();
                    gcVariablesDeMedicion.DataSource = VariablesPatrones;
                    gcVariablesDeMedicion.RefreshDataSource();

                }
                else
                {
                    VariablesPatrones = VariablesPatrones.Where(x => x.VariableMeicionId != filaSeleccioanda.VariableMeicionId &&
                                                                 x.ValorPatron == filaSeleccioanda.ValorPatron &&
                                                                 x.Tolerancia == filaSeleccioanda.Tolerancia).ToList();


                    gcVariablesDeMedicion.DataSource = VariablesPatrones;
                    gcVariablesDeMedicion.RefreshDataSource();
                }

            }
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Patrón" : "Modificar Patrón";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardar.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardar.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardar.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnAgregarTipoDeInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnVincularVariableMedicion, "Presione para vincular la variable de medición al patrón");

        }

        private bool ExiteVariableEnLista(VariablePatronDto variablePatronDto)
        {
            return VariablesPatrones.Any(x => x.VariableMeicionId == variablePatronDto.VariableMeicionId && x.ValorPatron == variablePatronDto.ValorPatron && x.Tolerancia == variablePatronDto.Tolerancia);
        }

        private void btnVincularVariableMedicion_Click(object sender, EventArgs e)
        {
            if (variableMedicionSeleccionada == null) return;

            var variablePatron = new VariablePatronDto
            {
                VariableDeMedicion = variableMedicionSeleccionada,
                Tolerancia = nmTolerancia.Value,
                ValorPatron = nmValorPatron.Value,
                VariableMeicionId = variableMedicionSeleccionada.VariableMedicionId,
            };

            if (ExiteVariableEnLista(variablePatron))
            {
                Notificaciones.MensajeAdvertencia("¡La variable ingresada ya existe!");
                return;
            }

            VariablesPatrones.Add(variablePatron);
            gcVariablesDeMedicion.DataSource = VariablesPatrones;
            gcVariablesDeMedicion.RefreshDataSource();
        }

        private void CargarVariablesDeMedicion()
        {
            var resultado = _variableMedicionService.ObtenerVariablesDeMedicionActivas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            lookupVariableMedicion.Properties.DataSource = resultado.Data;
            lookupVariableMedicion.Properties.DisplayMember = "Descripcion";
            lookupVariableMedicion.Properties.ValueMember = "VariableMedicionId";
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoPatron.Nombre))
            {
                mensaje = "Es necesario ingresar un nombre para el patrón.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoPatron.Link))
            {
                mensaje = "Es necesario ingresar el archivo adjunto que corresponde al patrón.";
                return false;
            }


            mensaje = "Ok";
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PrepararNuevoPatron();
            if (!EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarPatron())
                {
                    Notificaciones.MensajeConfirmacion("¡El patrón se ha registrado exitosamente!");
                    OnPatronAgregado?.Invoke(NuevoPatron);
                    this.Close();
                }

            }
            else
            {
                if (ActualizarPatron())
                {
                    Notificaciones.MensajeConfirmacion("¡El patrón se ha actualizado exitosamente!");
                    OnPatronAgregado?.Invoke(NuevoPatron);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();
        }

        private bool GuardarPatron()
        {
            try
            {
                var resultado = _patronService.RegistrarPatron(NuevoPatron);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarPatron()
        {
            try
            {
                var resultado = _patronService.ActualizarPatron(NuevoPatron);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevoPatron()
        {
            NuevoPatron.Nombre = txtNombreRango.Text;
            NuevoPatron.FechaCaducidad = dateFechaCaducidad.Value;
            NuevoPatron.Link = txtRutaArchivo.Text;
            NuevoPatron.VariablesPatrones = VariablesPatrones;
        }

        private void btnAdjunto_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdjunto, "Presione para iniciar búsqueda de archivo adjunto.");
        }

        private void glVariablesDeMedicion_EditValueChanged(object sender, EventArgs e)
        {
            variableMedicionSeleccionada = lookupVariableMedicion.GetSelectedDataRow() as VariableMedicionDto;
        }

        private void frmNuevoPatron_Load(object sender, EventArgs e)
        {

        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF files | *.pdf";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                txtRutaArchivo.Text = path;
            }
        }
    }

}