
namespace TacticaReparaciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    partial class frmNuevaVariableMedicion
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
            this.btnGuardarVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.nmPrimerValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.nmSegundoValorRango = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nmTolerancia = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarVariableMedicion
            // 
            this.btnGuardarVariableMedicion.FlatAppearance.BorderSize = 0;
            this.btnGuardarVariableMedicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVariableMedicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarVariableMedicion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarVariableMedicion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarVariableMedicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarVariableMedicion.IconSize = 30;
            this.btnGuardarVariableMedicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVariableMedicion.Location = new System.Drawing.Point(332, 368);
            this.btnGuardarVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarVariableMedicion.Name = "btnGuardarVariableMedicion";
            this.btnGuardarVariableMedicion.Size = new System.Drawing.Size(301, 52);
            this.btnGuardarVariableMedicion.TabIndex = 130;
            this.btnGuardarVariableMedicion.Text = "Guardar Variable de Medición";
            this.btnGuardarVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVariableMedicion.UseVisualStyleBackColor = true;
            this.btnGuardarVariableMedicion.Click += new System.EventHandler(this.btnGuardarVariableMedicion_Click);
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(676, 38);
            this.ctlEncabezadoPantalla1.TabIndex = 129;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(29, 70);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 127;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(29, 93);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(604, 30);
            this.txtDescripcion.TabIndex = 128;
            // 
            // nmPrimerValorRango
            // 
            this.nmPrimerValorRango.DecimalPlaces = 2;
            this.nmPrimerValorRango.Location = new System.Drawing.Point(29, 161);
            this.nmPrimerValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPrimerValorRango.Name = "nmPrimerValorRango";
            this.nmPrimerValorRango.Size = new System.Drawing.Size(150, 23);
            this.nmPrimerValorRango.TabIndex = 141;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 139);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 17);
            this.labelControl3.TabIndex = 140;
            this.labelControl3.Text = "Primer Valor Rango";
            // 
            // nmSegundoValorRango
            // 
            this.nmSegundoValorRango.DecimalPlaces = 2;
            this.nmSegundoValorRango.Location = new System.Drawing.Point(29, 231);
            this.nmSegundoValorRango.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSegundoValorRango.Name = "nmSegundoValorRango";
            this.nmSegundoValorRango.Size = new System.Drawing.Size(150, 23);
            this.nmSegundoValorRango.TabIndex = 143;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 209);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 17);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Segundo Valor Rango";
            // 
            // nmTolerancia
            // 
            this.nmTolerancia.DecimalPlaces = 2;
            this.nmTolerancia.Location = new System.Drawing.Point(29, 302);
            this.nmTolerancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmTolerancia.Name = "nmTolerancia";
            this.nmTolerancia.Size = new System.Drawing.Size(150, 23);
            this.nmTolerancia.TabIndex = 145;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 280);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 144;
            this.labelControl2.Text = "Tolerancia";
            // 
            // frmNuevaVariableMedicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.nmTolerancia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.nmSegundoValorRango);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nmPrimerValorRango);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnGuardarVariableMedicion);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmNuevaVariableMedicion";
            this.Text = "Agregar Variable de Medición";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrimerValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSegundoValorRango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTolerancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGuardarVariableMedicion;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private System.Windows.Forms.NumericUpDown nmPrimerValorRango;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown nmSegundoValorRango;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown nmTolerancia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}