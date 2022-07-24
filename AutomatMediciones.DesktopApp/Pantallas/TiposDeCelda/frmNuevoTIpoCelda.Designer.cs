
namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeCelda
{
    partial class frmNuevoTIpoCelda
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarTipoCelda = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaVariableMedicion = new FontAwesome.Sharp.IconButton();
            this.glVariablesDeMedicion = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(30, 118);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 123;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(30, 141);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(626, 30);
            this.txtDescripcion.TabIndex = 124;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 186);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 17);
            this.labelControl4.TabIndex = 148;
            this.labelControl4.Text = "Variable de Medición";
            // 
            // btnGuardarTipoCelda
            // 
            this.btnGuardarTipoCelda.FlatAppearance.BorderSize = 0;
            this.btnGuardarTipoCelda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTipoCelda.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarTipoCelda.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarTipoCelda.IconColor = System.Drawing.Color.Black;
            this.btnGuardarTipoCelda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarTipoCelda.IconSize = 30;
            this.btnGuardarTipoCelda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTipoCelda.Location = new System.Drawing.Point(415, 276);
            this.btnGuardarTipoCelda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarTipoCelda.Name = "btnGuardarTipoCelda";
            this.btnGuardarTipoCelda.Size = new System.Drawing.Size(241, 52);
            this.btnGuardarTipoCelda.TabIndex = 159;
            this.btnGuardarTipoCelda.Text = "Guardar Tipo de Celda";
            this.btnGuardarTipoCelda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTipoCelda.UseVisualStyleBackColor = true;
            this.btnGuardarTipoCelda.Click += new System.EventHandler(this.btnGuardarTipoCelda_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevaVariableMedicion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 7, 0, 7);
            this.panel1.Size = new System.Drawing.Size(688, 53);
            this.panel1.TabIndex = 160;
            // 
            // btnNuevaVariableMedicion
            // 
            this.btnNuevaVariableMedicion.FlatAppearance.BorderSize = 0;
            this.btnNuevaVariableMedicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVariableMedicion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaVariableMedicion.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevaVariableMedicion.IconColor = System.Drawing.Color.Black;
            this.btnNuevaVariableMedicion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaVariableMedicion.IconSize = 30;
            this.btnNuevaVariableMedicion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVariableMedicion.Location = new System.Drawing.Point(27, 5);
            this.btnNuevaVariableMedicion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNuevaVariableMedicion.Name = "btnNuevaVariableMedicion";
            this.btnNuevaVariableMedicion.Size = new System.Drawing.Size(271, 39);
            this.btnNuevaVariableMedicion.TabIndex = 16;
            this.btnNuevaVariableMedicion.Text = "Nueva Variable de Medición";
            this.btnNuevaVariableMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaVariableMedicion.UseVisualStyleBackColor = true;
            this.btnNuevaVariableMedicion.Click += new System.EventHandler(this.btnNuevaVariableMedicion_Click);
            // 
            // glVariablesDeMedicion
            // 
            this.glVariablesDeMedicion.Location = new System.Drawing.Point(30, 208);
            this.glVariablesDeMedicion.Name = "glVariablesDeMedicion";
            this.glVariablesDeMedicion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glVariablesDeMedicion.Properties.Appearance.Options.UseFont = true;
            this.glVariablesDeMedicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glVariablesDeMedicion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción")});
            this.glVariablesDeMedicion.Properties.NullText = "";
            this.glVariablesDeMedicion.Size = new System.Drawing.Size(626, 30);
            this.glVariablesDeMedicion.TabIndex = 161;
            // 
            // frmNuevoTIpoCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 354);
            this.Controls.Add(this.glVariablesDeMedicion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarTipoCelda);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoTIpoCelda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipos de Celda";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glVariablesDeMedicion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private FontAwesome.Sharp.IconButton btnGuardarTipoCelda;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNuevaVariableMedicion;
        private DevExpress.XtraEditors.LookUpEdit glVariablesDeMedicion;
    }
}