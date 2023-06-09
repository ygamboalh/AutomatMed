﻿using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Enums;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.DesktopApp.Reportes.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using IngresoInstrumento = AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos.IngresoInstrumento;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    public partial class frmPresupuestos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ProductoService _productoService;
        private readonly PresupuestoService _presupuestoService;
        private readonly IngresoService _ingresoService;
        public PresupuestoDto presupuestoSeleccionado { get; set; } 

        List<IngresoInstrumento> ingresosInstrumentos = new List<IngresoInstrumento>();
        
        public frmPresupuestos(IngresoService ingresoService, ProductoService productoService, PresupuestoService presupuestoService)
        {
            InitializeComponent();
            _productoService = productoService;
            _presupuestoService = presupuestoService;
            _ingresoService = ingresoService;

            btnEditPresupuesto.Click += btnEditPresupuestoClick;
            btnDeletePresupuesto.Click += btnDeletePresupuestoClick;
            btnVerReportePresupuesto.Click += btnVerReportePresupuesto_Click;
            btnEnviarCorreo.Click += BtnEnviarCorreo_Click;
            ObtenerIngresoInstrumento();
            CargarPresupuestos();
            EstablecerNombreYTitulo();
            SetearTotales();
        }

        private void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = Notificaciones.PreguntaConfirmacion("¿Está seguro que desea enviar el reporte por correo electrónico?");
            SplashScreenManager.ShowForm(typeof(frmSaving));
            if (resultado == DialogResult.Yes)
            {
              EnviarCorreoConReporte();
              Notificaciones.MensajeInformativo("El reporte se envió por correo satisfactoriamente");
            }
            SplashScreenManager.CloseForm();
            return;
        }
        private void EnviarCorreoConReporte() 
        {
            var reporte = CrearReporteDePresupuesto();
            var presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
            if (presupuestoSeleccionado == null) return;

            string clienteId = presupuestoSeleccionado.ClienteId;
            string[] nombreCompleto = presupuestoSeleccionado.NombreCliente.Split(" ");
            string nombre = nombreCompleto[0];
            string apellido = nombreCompleto[1];
            var contacto = _presupuestoService.ObtenerListaContactos(clienteId).Data.Find(x => x.Nombre == nombre);
            if (apellido == contacto.Apellido)
            {
                presupuestoSeleccionado.CorreoUsuario = contacto.Correo;
            }

            MemoryStream reportStream = new MemoryStream();
            reporte.ExportToPdf(reportStream);

            var diccionarioAdjuntos = new Dictionary<string, Stream>();
            diccionarioAdjuntos.Add(reporte.DisplayName, reportStream);

            var configuraciones = serviceProvider.GetRequiredService<ConfiguracionNotificacionService>().ObtenerConfiguraciones().Data;
            string cuerpoCorreo = ConvertirTextoPlanoEmailHaciaHtml(nombre+" "+apellido, presupuestoSeleccionado.Nombre);

            CorreoNotificacionDto correoNotificacionDto = new CorreoNotificacionDto()
            {
                Body = cuerpoCorreo,
                NombreEmpresa = presupuestoSeleccionado.ClienteId,
                IngresoId = presupuestoSeleccionado.IngresoId,
                Adjuntos = diccionarioAdjuntos,
                CopiasEnCorreo = new List<string> {
                    configuraciones.CorreoOrigen
                },
                AdjuntoMediaType = "application/pdf",
                NombreDestinatario = nombre + " " + apellido,
                CorreoDestinatario = contacto.Correo,
                Configuracion = new ConfiguracionNotificacionDto
                {
                    Puerto = configuraciones.Puerto,
                    CorreoOrigen = configuraciones.CorreoOrigen,
                    Servidor = configuraciones.Servidor,
                    Asunto = $"Presupuesto para N° Servicio {presupuestoSeleccionado.Nombre}",
                    Password = configuraciones.Password,
                },
            };
            Helpers.CorreoHelper helper = new CorreoHelper();
            helper.EnviarCorreo(correoNotificacionDto); 
        }

        private rptPresupuesto CrearReporteDePresupuesto()
        {
            var presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
            if (presupuestoSeleccionado == null) return null;

            rptPresupuesto rptPresupuesto = new rptPresupuesto();

            int ingresoId = presupuestoSeleccionado.IngresoId;
            string recId = presupuestoSeleccionado.RecID;
            var productosIngreso = _presupuestoService.ObtenerProductosIngresos(ingresoId, recId);
            string clienteId = presupuestoSeleccionado.ClienteId;
            string[] nombreCompleto = presupuestoSeleccionado.NombreCliente.Split(" ");
            string nombre = nombreCompleto[0];
            string apellido = nombreCompleto[1];
            decimal totalProductos = 0;
            var contacto = _presupuestoService.ObtenerListaContactos(clienteId).Data.Find(x => x.Nombre == nombre);
            if (apellido == contacto.Apellido)
            {
                presupuestoSeleccionado.CorreoUsuario = contacto.Correo;
            }

            for (int i = 0; i < productosIngreso.Data.Count; i++)
            {
                totalProductos += productosIngreso.Data[i].Precio;
            }
            presupuestoSeleccionado.PrecioTotaldeProductos = totalProductos;

            rptPresupuesto.objectDataSource1.DataSource = presupuestoSeleccionado;
            rptPresupuesto.objectDataSource2.DataSource = productosIngreso.Data;

            return rptPresupuesto;
        }

        private void btnVerReportePresupuesto_Click(object sender, EventArgs e)
        {
            var presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
            if (presupuestoSeleccionado == null) return;
                
            SplashScreenManager.ShowForm(typeof(frmSaving));

            rptPresupuesto rptPresupuesto = CrearReporteDePresupuesto();
                
            rptPresupuesto.DisplayName = $"Presupuesto {presupuestoSeleccionado.Nombre}";
            ReportPrintTool printTool = new ReportPrintTool(rptPresupuesto);
            printTool.ShowRibbonPreview();
                
            SplashScreenManager.CloseForm();
        }

        public string ConvertirTextoPlanoEmailHaciaHtml(string persona, string servicio)
        {
            StringBuilder textoEmail = new StringBuilder();
            bool yaInicioLasLineasDeFirmaParaElEmail = false;

            List<string> cuerpoCorreo = new List<string>()
            {
                $"Estimado {persona}",
                $"Le compartimos el presupuesto resultante para el número de servicio {servicio}.",
                "Saludos Cordiales",
                "Automat Medición S.R.L.",
                "Dr.Rafael Bielsa 175 - C1427AZA - Buenos Aires",
                "TEL: +54 11 4555 - 0055",
                "Whatsapp + 54 9 11 2466 4500",
                "Visite nuestra web: www.automat.com.ar",
            };
            textoEmail.AppendLine();
            textoEmail.AppendLine($"<p style style={"line-height: 100%"}>");
            foreach (var line in cuerpoCorreo)
            {
                if (line.Contains("Saludos Cordiales"))
                {
                    yaInicioLasLineasDeFirmaParaElEmail = true;
                }

                if (line.Contains("Automat Medición S.R.L.") || line.Contains("Whatsapp"))
                {
                    string pararrafo = $"<strong> {line.Replace(Environment.NewLine, "<br />\r\n")} </strong><br>";

                    pararrafo = Regex.Replace(pararrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                    pararrafo = Regex.Replace(pararrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");
                    textoEmail.AppendLine(pararrafo);
                }
                else if (string.IsNullOrEmpty(line))
                {
                    textoEmail.AppendLine("<br>");
                }
                else
                {
                    if (yaInicioLasLineasDeFirmaParaElEmail)
                    {
                        string parrafo = line.Replace(Environment.NewLine, "<br />\r\n");

                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");
                        textoEmail.AppendLine($"{parrafo}<br>");
                    }
                    else
                    {
                        string parrafo = line.Replace(Environment.NewLine, "<br />\r\n");

                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");

                        if (line.Contains("."))
                        {
                            parrafo = $"{parrafo} <br>";
                        }
                        textoEmail.AppendLine(parrafo);
                    }
                }
            }

            textoEmail.AppendLine("</p>");

            return textoEmail.ToString();
        }
        private void btnDeletePresupuestoClick(object sender, EventArgs e)
        {
            DialogResult resultado= Notificaciones.PreguntaConfirmacion("¿Está seguro que desea desactivar el presupuesto?");
            if (resultado == DialogResult.Yes) { 
            
                var presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
                int presupustoControlId = Int16.Parse(ObtenerPosicionesDeCadena(presupuestoSeleccionado.RecID));
                var presupuestoControl = _presupuestoService.ObtenerPresupuestoControl(presupustoControlId);
                var presupuestoControlItems = _presupuestoService.ObtenerPresupuestoControlItems(presupustoControlId);
                var productosIngresos = _presupuestoService.ObtenerProductosIngresos()
                    .Data.Where(x => x.PresupuestoControlId == presupustoControlId);

                _presupuestoService.DesactivarPresupuesto(presupuestoSeleccionado.RecID);
                CargarPresupuestos();
            }
            else { return; }
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

        public string ObtenerPosicionesDeCadena(string cadena)
        {
            string numerosFinales = "";
            int indice = cadena.Length - 1;
            if(cadena.Length == 12 && cadena.StartsWith("a"))
            {
                while (indice >= 0 && Char.IsDigit(cadena[indice]))
                {
                    numerosFinales = cadena[indice] + numerosFinales;
                    indice--;
                }
            }
            if (numerosFinales.Length == 0)
                return cadena;
            return numerosFinales;
        }
        
        private List<PresupuestoDto> CargarPresupuestos()
        { 
            var resultado = _presupuestoService.ObtenerPresupuestos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            List<PresupuestoDto> presupuestos = new List<PresupuestoDto>();
            foreach (var presupuesto in modelosRespuesta)
            {                 
                    string id = presupuesto.RecID;
                    PresupuestoControl presupuestoControl = null;
                    ProductoIngreso productoIngreso = null;
                    IngresoDto ingreso = null;
                    int presupuestoIdControl = 0;
                    short resultadoParse;
                    if ((Int16.TryParse(ObtenerPosicionesDeCadena(id), out resultadoParse)))
                    {
                        presupuestoIdControl = Int16.Parse(ObtenerPosicionesDeCadena(id));
                        var mensajePC = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Message;
                        var presupuestoContr = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl);
                        if (mensajePC == "" && presupuestoContr != null && presupuestoContr.Data.Estado == 1)
                        {
                            presupuestoControl = _presupuestoService.ObtenerPresupuestoControl(presupuestoIdControl).Data;
                            var mensajePI = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Message;
                            var productoIngr = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id);
                            if (mensajePI == "" && productoIngr != null)
                            {
                                productoIngreso = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id).Data;
                                var mensajeI = _ingresoService.ObtenerIngreso(productoIngreso.IngresoId).Message;
                                var productoIng = _presupuestoService.ObtenerProductoIngreso(presupuestoControl.Id);
                                if (mensajeI == "" && productoIng != null)
                                {
                                    ingreso = _ingresoService.ObtenerIngresos().Data.FirstOrDefault(x => x.IngresoId == productoIngreso.IngresoId);
                                    presupuesto.IngresoId = ingreso.IngresoId;
                                    var ingresoInstrumento = ingresosInstrumentos.FirstOrDefault(x => x.IngresoId == presupuesto.IngresoId);
                                    presupuesto.ClienteId = ingresoInstrumento.Ingreso.NombreEmpresa;
                                    string nombreContacto = ingresoInstrumento.Ingreso.NombreContacto;
                                    string apellidoContacto = ingresoInstrumento.Ingreso.ApellidoContacto;
                                    presupuesto.NombreCliente = nombreContacto + " " + apellidoContacto;

                                    
                                    string numeroServiciosTecnicos = ingresoInstrumento.NumeroServicioTecnico;
                                    string ClasificacionInstrumento = $"{ingresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion} / {ingresoInstrumento.Instrumento.Clasificacion.Marca.Descripcion} / {ingresoInstrumento.Instrumento.Clasificacion.Modelo.Descripcion}";

                                    presupuesto.NoServicioTecnico = numeroServiciosTecnicos;
                                    presupuesto.ClasificacionInstrumento = ClasificacionInstrumento;
                                    presupuestos.Add(presupuesto);
                                }
                            }
                        }
                    }               
            }
            gcPresupuestos.DataSource = presupuestos;
            gcPresupuestos.RefreshDataSource();
            return presupuestos;
        }

        
        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantallaPres = new ctlEncabezadoPantalla();
            ctlEncabezadoPantallaPres.Parent = this;
            ctlEncabezadoPantallaPres.Height = 43;
            ctlEncabezadoPantallaPres.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantallaPres.lblTitulo.Text = "Presupuestos";
            ctlEncabezadoPantallaPres.EstablecerColoresDeFondoYLetra();
        }
        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvPresupuesto.RowCount}";
            lblTotal.Visible = true;
        }
        private void ObtenerIngresoInstrumento()
        {
            var resultado = _ingresoService.ObtenerIngresos();
            if (resultado.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultado.Message);
                return;
            }
            ingresosInstrumentos = resultado.Data.SelectMany(x => x.IngresosInstrumentos).Select(y => new IngresoInstrumento
            {
                Activo = y.Activo,
                IngresoId = y.IngresoId,
                IngresoInstrumentoId = y.IngresoInstrumentoId,
                InstrumentoId = y.InstrumentoId,
                Comentarios = y.Comentarios,
                Ingreso = y.Ingreso,
                Instrumento = y.Instrumento,
                EstadoId = y.EstadoId,
                Estado = y.Estado,
                TipoTrabajo = y.TipoTrabajo,
                Prioridad = y.Prioridad,
                TipoTrabajoId = y.TipoTrabajoId,
                Responsable = y.Responsable,
                Diagnostico = y.Diagnostico,
                FechaInicio = y.FechaInicio,
                FechaFin = y.FechaFin,
                TiempoConsumido = y.TiempoConsumido,
                ResponsableId = y.ResponsableId,
                FechaEntregaRequerida = y.FechaEntregaRequerida,
                NumeroServicioTecnico = y.NumeroServicioTecnico,
                ClasificacionConcatenada = $"{y.Instrumento.Clasificacion.TipoInstrumento.Descripcion} / {y.Instrumento.Clasificacion.Marca.Descripcion} / {y.Instrumento.Clasificacion.Modelo.Descripcion}"
            }).OrderBy(y => y.Prioridad).ToList();

            SetearTotales();
        }
        private void btnEditPresupuestoClick(object sender, EventArgs e)
        {
            presupuestoSeleccionado = gvPresupuesto.GetFocusedRow() as PresupuestoDto;
            if (presupuestoSeleccionado == null) return;
            var presupuestoDb = CargarPresupuestos().Where(x => x.ID == presupuestoSeleccionado.ID).FirstOrDefault(x => x.ID == presupuestoSeleccionado.ID);
            var frmEditarPresupuesto = new frmEditarPresupuesto(presupuestoDb, serviceProvider.GetService<IngresoService>(),
                                                    serviceProvider.GetService<ProductoService>(),
                                                    serviceProvider.GetService<PresupuestoService>(),
                                                    serviceProvider.GetService<MonedaService>()
                                                    );
            frmEditarPresupuesto.Text = "Editar Presupuesto";
            frmEditarPresupuesto.Presupuesto = presupuestoDb;
            frmEditarPresupuesto.ShowDialog();
            frmEditarPresupuesto.MdiParent = this.ParentForm;
        }
    }
}