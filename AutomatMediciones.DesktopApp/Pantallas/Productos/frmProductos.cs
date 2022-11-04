using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Productos
{
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ProductoService _productoService;

        List<ArbolCarpetaDto> arbolCarpetas = new List<ArbolCarpetaDto>();
        public frmProductos(ProductoService productoService)
        {
            InitializeComponent();
            EstablecerNombreYTitulo();
            _productoService = productoService;
            CargarProductos();
            CargarArbolCarpetas();         
        }

        private void CargarProductos()
        {
            var resultado = _productoService.ObtenerProductos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            gcProductos.DataSource = resultado.Data;
            lblTotal.Visible = true;
            lblTotal.Text = $"Total Registros: {resultado.Data.Count()}";

        }

        private void CargarArbolCarpetas()
        {
            var resultado = _productoService.ObtenerArbolCarpetas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            arbolCarpetas = resultado.Data;

            var arboles = arbolCarpetas.Where(x => x.Nivel == 0).ToList();
            arboles.ForEach(x => {
                TreeNode rootNode = new TreeNode();
                rootNode.Text = x.Nombre;
                rootNode.Name = x.RecId;
                treeView1.Nodes.Add(rootNode);
                ObtenerNiveles(x, treeView1);
            });

            arbolCarpetas = resultado.Data;
           
        }

        public List<ArbolCarpetaDto> ObtenerNiveles(ArbolCarpetaDto arbolCarpetaDto, TreeView treeView)
        {          
            var arboles =  arbolCarpetas.Where(x => x.RecId == arbolCarpetaDto.RecId).ToList();
            arboles.ForEach(x => {
                var niveles = ObtenerNiveles(x, treeView);

                niveles.ForEach(x =>
                {
                    TreeNode rootNode = new TreeNode();
                    rootNode.Text = x.Nombre;
                    rootNode.Name = x.RecId;
                    treeView.Nodes.Add(rootNode);
                });
            });

            return arboles;
        }


        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Productos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
    }
}