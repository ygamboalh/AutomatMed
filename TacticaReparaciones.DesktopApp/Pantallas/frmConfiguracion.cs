﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Pantallas.Marcas;
using TacticaReparaciones.DesktopApp.Pantallas.Modelos;
using TacticaReparaciones.DesktopApp.Pantallas.TiposDeInstrumento;
using TacticaReparaciones.DesktopApp.Pantallas.Clasificaciones;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void tipoInstrumentoMenu_Click(object sender, EventArgs e)
        {
            XtraForm frmTiposDeInstrumento = new frmTiposDeInstrumento();
            AgregarPantalla(ref frmTiposDeInstrumento);
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
            XtraForm frmMarcas = new frmMarcas();
            AgregarPantalla(ref frmMarcas);
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            XtraForm frmModelos = new frmModelos();
            AgregarPantalla(ref frmModelos);
        }

        private void clasificacionInstrumentoMenu_Click(object sender, EventArgs e)
        {
            XtraForm frmClasificaciones = new frmClasificaciones();
            AgregarPantalla(ref frmClasificaciones);
        }
    }
}