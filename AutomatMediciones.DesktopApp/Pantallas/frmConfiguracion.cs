﻿using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.Patrones;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void tipoInstrumentoMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmTipoInstrumento = new frmTiposDeInstrumento(serviceProvider.GetService<TipoDeInstrumentoService>());
            XtraForm tiposDeInstrumento = frmTipoInstrumento;
            AgregarPantalla(ref tiposDeInstrumento);
            SplashScreenManager.CloseForm();
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (pantalla.Created)
            {
                pantalla.Focus();
            }
            else
            {
                pantalla.MdiParent = this.ParentForm;
                pantalla.Show();
            }
        }

        private void marcaMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmMarcas = new frmMarcas(serviceProvider.GetService<MarcaService>());
            XtraForm marcas = frmMarcas;
            AgregarPantalla(ref marcas);
            SplashScreenManager.CloseForm();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmModelos = new frmModelos(serviceProvider.GetService<ModeloService>());
            XtraForm modelos = frmModelos;
            AgregarPantalla(ref modelos);
            SplashScreenManager.CloseForm();
        }

        private void clasificacionInstrumentoMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmClasificaciones = new frmClasificaciones(serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                            serviceProvider.GetService<MarcaService>(),
                                                            serviceProvider.GetService<ModeloService>(),
                                                            serviceProvider.GetService<TipoDeInstrumentoService>()
                                                            );
            XtraForm clasificaciones = frmClasificaciones;
            AgregarPantalla(ref clasificaciones);
            SplashScreenManager.CloseForm();
        }

        private void instrumentosMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmInstrumentos = new frmInstrumentos(serviceProvider.GetService<InstrumentoService>());
            XtraForm nuevoInstrumento = frmInstrumentos;
            AgregarPantalla(ref nuevoInstrumento);
            SplashScreenManager.CloseForm();
        }

        private void variableMedicionMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmVariablesDeMedicion = new frmVariablesDeMedicion(serviceProvider.GetService<VariableMedicionService>());
            XtraForm variablesMedicion = frmVariablesDeMedicion;
            AgregarPantalla(ref variablesMedicion);
            SplashScreenManager.CloseForm();
        }

        private void patronesMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmPatrones = new frmPatrones(serviceProvider.GetService<PatronService>());
            XtraForm patrones = frmPatrones;
            AgregarPantalla(ref patrones);
            SplashScreenManager.CloseForm();
        }
    }
}