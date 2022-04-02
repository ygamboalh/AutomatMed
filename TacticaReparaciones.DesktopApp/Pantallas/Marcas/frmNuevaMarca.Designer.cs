
namespace TacticaReparaciones.DesktopApp.Pantallas.Marcas
{
    partial class frmNuevaMarca
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
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.ctlEncabezadoPantalla1 = new TacticaReparaciones.DesktopApp.Componentes.Encabezados.ctlEncabezadoPantalla();
            this.btnGuardarMarca = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(12, 59);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 12);
            this.labelControl11.TabIndex = 121;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(12, 78);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(518, 26);
            this.txtDescripcion.TabIndex = 122;
            // 
            // ctlEncabezadoPantalla1
            // 
            this.ctlEncabezadoPantalla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlEncabezadoPantalla1.Location = new System.Drawing.Point(0, 0);
            this.ctlEncabezadoPantalla1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlEncabezadoPantalla1.Name = "ctlEncabezadoPantalla1";
            this.ctlEncabezadoPantalla1.Size = new System.Drawing.Size(550, 39);
            this.ctlEncabezadoPantalla1.TabIndex = 123;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.FlatAppearance.BorderSize = 0;
            this.btnGuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarMarca.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarMarca.IconColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarMarca.IconSize = 30;
            this.btnGuardarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMarca.Location = new System.Drawing.Point(272, 123);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(258, 42);
            this.btnGuardarMarca.TabIndex = 126;
            this.btnGuardarMarca.Text = "Guardar Tipo de Instrumento";
            this.btnGuardarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // frmNuevaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 211);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.ctlEncabezadoPantalla1);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmNuevaMarca";
            this.Text = "Nueva Marca";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private Componentes.Encabezados.ctlEncabezadoPantalla ctlEncabezadoPantalla1;
        private FontAwesome.Sharp.IconButton btnGuardarMarca;
    }
}