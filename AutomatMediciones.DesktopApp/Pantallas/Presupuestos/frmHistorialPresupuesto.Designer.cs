namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos
{
    partial class frmHistorialPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServicioTecnico = new FontAwesome.Sharp.IconButton();
            this.btnFiltroTodos = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcHistorialPresupuesto = new DevExpress.XtraGrid.GridControl();
            this.gvHistorialPresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregarProductosSeleccionados = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.colCodigoPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHistorialPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPresupuesto)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnServicioTecnico);
            this.panel1.Controls.Add(this.btnFiltroTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnServicioTecnico
            // 
            this.btnServicioTecnico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServicioTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioTecnico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServicioTecnico.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnServicioTecnico.IconColor = System.Drawing.Color.Black;
            this.btnServicioTecnico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicioTecnico.IconSize = 20;
            this.btnServicioTecnico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicioTecnico.Location = new System.Drawing.Point(145, 11);
            this.btnServicioTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServicioTecnico.Name = "btnServicioTecnico";
            this.btnServicioTecnico.Size = new System.Drawing.Size(127, 30);
            this.btnServicioTecnico.TabIndex = 160;
            this.btnServicioTecnico.Text = "Cliente";
            this.btnServicioTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnServicioTecnico.UseVisualStyleBackColor = true;
            // 
            // btnFiltroTodos
            // 
            this.btnFiltroTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltroTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroTodos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltroTodos.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltroTodos.IconColor = System.Drawing.Color.Black;
            this.btnFiltroTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroTodos.IconSize = 20;
            this.btnFiltroTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroTodos.Location = new System.Drawing.Point(12, 11);
            this.btnFiltroTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltroTodos.Name = "btnFiltroTodos";
            this.btnFiltroTodos.Size = new System.Drawing.Size(127, 30);
            this.btnFiltroTodos.TabIndex = 159;
            this.btnFiltroTodos.Text = "Instrumento";
            this.btnFiltroTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroTodos.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(278, 11);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(127, 30);
            this.iconButton1.TabIndex = 161;
            this.iconButton1.Text = "Modelo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcHistorialPresupuesto);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel2.Size = new System.Drawing.Size(725, 375);
            this.panel2.TabIndex = 1;
            // 
            // gcHistorialPresupuesto
            // 
            this.gcHistorialPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHistorialPresupuesto.Location = new System.Drawing.Point(10, 0);
            this.gcHistorialPresupuesto.MainView = this.gvHistorialPresupuesto;
            this.gcHistorialPresupuesto.Name = "gcHistorialPresupuesto";
            this.gcHistorialPresupuesto.Size = new System.Drawing.Size(705, 304);
            this.gcHistorialPresupuesto.TabIndex = 0;
            this.gcHistorialPresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHistorialPresupuesto});
            // 
            // gvHistorialPresupuesto
            // 
            this.gvHistorialPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoPresupuesto,
            this.colDescripcion,
            this.colCantidad,
            this.colPrecio});
            this.gvHistorialPresupuesto.GridControl = this.gcHistorialPresupuesto;
            this.gvHistorialPresupuesto.Name = "gvHistorialPresupuesto";
            this.gvHistorialPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gvHistorialPresupuesto.OptionsView.ShowIndicator = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAgregarProductosSeleccionados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 326);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel5.Size = new System.Drawing.Size(705, 44);
            this.panel5.TabIndex = 207;
            // 
            // btnAgregarProductosSeleccionados
            // 
            this.btnAgregarProductosSeleccionados.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarProductosSeleccionados.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductosSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductosSeleccionados.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarProductosSeleccionados.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAgregarProductosSeleccionados.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProductosSeleccionados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProductosSeleccionados.IconSize = 30;
            this.btnAgregarProductosSeleccionados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductosSeleccionados.Location = new System.Drawing.Point(430, 0);
            this.btnAgregarProductosSeleccionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductosSeleccionados.Name = "btnAgregarProductosSeleccionados";
            this.btnAgregarProductosSeleccionados.Size = new System.Drawing.Size(275, 39);
            this.btnAgregarProductosSeleccionados.TabIndex = 128;
            this.btnAgregarProductosSeleccionados.Text = "Agregar Productos Seleccionados";
            this.btnAgregarProductosSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProductosSeleccionados.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 304);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 22);
            this.panel3.TabIndex = 208;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(6, 12);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // colCodigoPresupuesto
            // 
            this.colCodigoPresupuesto.Caption = "Código Presupuesto";
            this.colCodigoPresupuesto.Name = "colCodigoPresupuesto";
            this.colCodigoPresupuesto.Visible = true;
            this.colCodigoPresupuesto.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            // 
            // frmHistorialPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHistorialPresupuesto";
            this.Text = "Historial de Presupuesto";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHistorialPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPresupuesto)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnServicioTecnico;
        private FontAwesome.Sharp.IconButton btnFiltroTodos;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcHistorialPresupuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHistorialPresupuesto;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnAgregarProductosSeleccionados;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
    }
}