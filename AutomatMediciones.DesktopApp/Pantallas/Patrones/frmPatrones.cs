using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    public partial class frmPatrones : DevExpress.XtraEditors.XtraForm
    {
        private readonly PatronService _patronService;
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

  
        ICollection<PatronDto> patrones = new List<PatronDto>();
        public frmPatrones(PatronService patronService)
        {
            InitializeComponent();
            _patronService = patronService;

            CargarPatrones();
        }

        private void CargarPatrones()
        {
            var resultado = _patronService.ObtenerPatrones();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var patronesRespuesta = resultado.Data;
            patrones = patronesRespuesta;

            gcPatrones.DataSource = patrones;

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {patrones.Count}";
            lblTotal.Visible = true;
        }

        private void btnAgregarNuevoPatron_Click(object sender, System.EventArgs e)
        {
            var frmNuevoPatron = new frmNuevoPatron(TipoTransaccion.Insertar, serviceProvider.GetService<PatronService>(),
                serviceProvider.GetService<VariableMedicionService>());
            frmNuevoPatron.OnPatronAgregado += OnPatronAgregado;
            frmNuevoPatron.ShowDialog();
        }

        private void OnPatronAgregado(PatronDto patron)
        {
           
        }
    }
}