using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;

        ContactoDto contactoSeleccionado;
        EmpresaDto empresaSeleccionada;
        CorreoElectronicoDto correoSeleccionado;
        TipoTrabajoDto tipoTrabajoSeleccionado;

        ICollection<IngresoInstrumentoDto> instrumentosSeleccionados;

        public IngresoDto Ingreso { get; set; }

        public frmIngresos()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            _ = CargarDatosTiposDeTrabajo();

            Ingreso = new IngresoDto();
            instrumentosSeleccionados = new List<IngresoInstrumentoDto>();

            chkSeleccionarInstrumento.EditValueChanged += onSeleccionaInstrumento;
        }

        private void onSeleccionaInstrumento(object sender, EventArgs e)
        {
            var checkSeleccionado = sender as DevExpress.XtraEditors.CheckEdit;

            if (checkSeleccionado.EditValue == null) return;

            var estaSeleccionadoElInstrumento = (bool)checkSeleccionado.EditValue;

            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as InstrumentoDto;

            if (instrumento == null) return;

            var yaFueSeleccionado = YaFueSeleccionadoElInstrumento(instrumento.InstrumentoId);

            if (!estaSeleccionadoElInstrumento && yaFueSeleccionado) QuitarInstrumentoDeListaDeSeleccionados(instrumento.InstrumentoId);

            if (estaSeleccionadoElInstrumento && !yaFueSeleccionado) AgregarInstrumentoEnListaDeSeleccionados(instrumento);

            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {instrumentosSeleccionados.Count}";
        }

        private void AgregarInstrumentoEnListaDeSeleccionados(InstrumentoDto instrumento)
        {
            instrumentosSeleccionados.Add(new IngresoInstrumentoDto());
        }

        private void QuitarInstrumentoDeListaDeSeleccionados(int instrumentoId)
        {
            instrumentosSeleccionados = instrumentosSeleccionados.Where(x => x.InstrumentoId != instrumentoId).ToList();
        }

        private bool YaFueSeleccionadoElInstrumento(int instrumentoId)
        {
            var instrumentosIds = instrumentosSeleccionados.Select(x => x.InstrumentoId);
            if (instrumentosIds.Contains(instrumentoId))
            {
                return true;
            }

            return false;
        }

        private async Task CargarDatosTiposDeTrabajo()
        {
            string uri = "/tipos-de-trabajo";
            var tiposTrabajo = await HttpHelper.Get<TipoTrabajoDto>(rutaApi, uri, "");

            glTiposTrabajo.Properties.DataSource = tiposTrabajo;
            glTiposTrabajo.Properties.DisplayMember = "Descripcion";
            glTiposTrabajo.Properties.ValueMember = "TipoTrabajoId";
        }

        private async Task<List<InstrumentoDto>> ObtenerInstrumentosParaEmpresaSeleccionada()
        {
            string uri = $"/instrumentos/por-empresa/{empresaSeleccionada.NombreEmpresa}";
            var instrumentos = await HttpHelper.Get<InstrumentoDto>(rutaApi, uri, "");

            gcInstrumentosDeEmpresa.DataSource = instrumentos;
            return instrumentos;
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardarIngreso.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarIngreso.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarIngreso.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "Ingresos";
            this.Text = titulo;
            this.ctlEncabezadoPantalla1.lblTitulo.Text = "Creación de Ingreso";
            this.ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, System.EventArgs e)
        {
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private async void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            if (empresa == null) return;

            empresaSeleccionada = empresa;
            txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
            var instrumentos = await ObtenerInstrumentosParaEmpresaSeleccionada();

            AsignarInstrumentosDeEmpresa(instrumentos);
            ObtenerContactosDeEmpresaSeleccionada();
        }

        private void AsignarInstrumentosDeEmpresa(List<InstrumentoDto> instrumentos)
        {
            gcInstrumentosDeEmpresa.DataSource = null;
            gcInstrumentosDeEmpresa.DataSource = instrumentos;
            lblTotalInstrumentos.Visible = true;
            lblInstrumentosSeleccionados.Visible = true;
            lblTotalInstrumentos.Text = $"Total Instrumentos: {instrumentos.Count}";
            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {instrumentosSeleccionados.Count}";
        }

        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            glContacto.Properties.DataSource = empresaSeleccionada.Contactos;
            glContacto.Properties.DisplayMember = "Nombre";
            glContacto.Properties.ValueMember = "ContactoId";
        }

        public void ObtenerCorreoElectronicoDeContacto()
        {

            LimpiarCorreos();
            glCorreoElectronico.Properties.DataSource = contactoSeleccionado.CorreosElectronicos;
            glCorreoElectronico.Properties.DisplayMember = "Direccion";
            glCorreoElectronico.Properties.ValueMember = "RegistroId";
        }

        private void glContacto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = glContactos.GetFocusedRow() as ContactoDto;
            ObtenerCorreoElectronicoDeContacto();
        }

        private void LimpiarContactos()
        {
            glContacto.Properties.DataSource = null;
            contactoSeleccionado = null;
            LimpiarCorreos();
        }

        private void LimpiarCorreos()
        {
            glCorreoElectronico.Properties.DataSource = null;
        }

        private void btnAgregarNuevInstrumento_Click(object sender, EventArgs e)
        {
            frmNuevoInstrumento frmNuevoInstrumento = new frmNuevoInstrumento();
            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            frmNuevoInstrumento.Show();
        }

        private async void OnInstrumentoAgregado(InstrumentoDto empresa)
        {
            if (empresaSeleccionada != null)
            {
                await ObtenerInstrumentosParaEmpresaSeleccionada();
            }
        }

        private void PrepararNuevoIngreso()
        {
            Ingreso.EmpresaId = empresaSeleccionada.EmpresaId;
            Ingreso.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            Ingreso.ContactoId = contactoSeleccionado.ContactoId;
            Ingreso.NombreContacto = contactoSeleccionado.Nombre;
            Ingreso.CorreoElectronicoId = correoSeleccionado.RegistroId;
            Ingreso.DireccionCorreoElectronico = correoSeleccionado.Direccion;
            Ingreso.IngresosInstrumentos = instrumentosSeleccionados;
            Ingreso.EstadoId = (int)Estados.Ingresado;
            Ingreso.TipoTrabajoId = tipoTrabajoSeleccionado.TipoTrabajoId;
            Ingreso.Comentarios = memoComentarios.Text;
            Ingreso.Prioridad = trackBarControl1.Value;
        }

        private void glCorreoElectronico_EditValueChanged(object sender, EventArgs e)
        {
            correoSeleccionado = glCorreo.GetFocusedRow() as CorreoElectronicoDto;
        }

        private bool SeLlenaronCamposObligatorios(out string mensaje)
        {

            if (empresaSeleccionada == null)
            {
                mensaje = "Es necesario que seleccione una empresa para continuar";
                return false;
            }

            if (contactoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un contacto para continuar";
                return false;
            }

            if (correoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un correo para continuar";
                return false;
            }

            if (!instrumentosSeleccionados.Any())
            {
                mensaje = "Es necesario que seleccione al menos un instrumento para continuar";
                return false;
            }

            if (tipoTrabajoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un tipo de trabajo para continuar";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private async void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (!SeLlenaronCamposObligatorios(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            PrepararNuevoIngreso();

            if ((await GuardarIngreso()))
            {
                MessageBox.Show("¡El ingreso se ha guardado exitosamente!", "Tactica Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private async Task<bool> GuardarIngreso()
        {
            bool guardado = false;
            string uri = "/ingresos";

            try
            {
                guardado = await HttpHelper.Post<IngresoDto>(Ingreso, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return guardado;
        }

        private void glTiposTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            tipoTrabajoSeleccionado = glTipoTrabajo.GetFocusedRow() as TipoTrabajoDto;
        }

        private void LimpiarFormulario()
        {
            txtEmpresa.ResetText();
            glContacto.EditValue = null;
            glCorreoElectronico.EditValue = null;
            instrumentosSeleccionados.Clear();
            gcInstrumentosDeEmpresa.DataSource = null;
            lblInstrumentosSeleccionados.Text = "";
            lblTotalInstrumentos.Text = "";
            lblTotalInstrumentos.Visible = false;
            lblInstrumentosSeleccionados.Visible = false;
            glTiposTrabajo.EditValue = null;
            memoComentarios.Text = "";
            trackBarControl1.Value = 1;
            empresaSeleccionada = null;
            tipoTrabajoSeleccionado = null;
            contactoSeleccionado = null;
            correoSeleccionado = null;
            Ingreso = new IngresoDto();
        }
    }
}

