using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmPresupuestos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ProductoService _productoService;
        private readonly PresupuestoService _presupuestoService;

        public frmPresupuestos(ProductoService productoService, PresupuestoService presupuestoService)
        {
            InitializeComponent();
            _productoService = productoService;
            _presupuestoService = presupuestoService;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarPresupuestoItems();
        }

        private void CargarProductos()
        {
            var resultado = _productoService.ObtenerProductos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;



        }

        private void CargarPresupuestoItems()
        {
            var resultado = _presupuestoService.ObtenerPresupuestosDetalle();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
        }

        private void CargarPresupuestos()
        {
            var resultado = _presupuestoService.ObtenerPresupuestos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
        }

    }
}