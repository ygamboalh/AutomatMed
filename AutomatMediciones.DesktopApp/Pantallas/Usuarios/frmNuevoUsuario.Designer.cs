
namespace AutomatMediciones.DesktopApp.Pantallas.Usuarios
{
    partial class frmNuevoUsuario
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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtCorreoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.btnAdjunto = new FontAwesome.Sharp.IconButton();
            this.txtRutaArchivo = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardarUsuario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(20, 183);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(102, 17);
            this.labelControl9.TabIndex = 157;
            this.labelControl9.Text = "Link Firma Digital:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(20, 128);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 17);
            this.labelControl10.TabIndex = 155;
            this.labelControl10.Text = "Correo:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(20, 77);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(52, 17);
            this.labelControl11.TabIndex = 154;
            this.labelControl11.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.EditValue = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(20, 97);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtNombreUsuario.Properties.UseReadOnlyAppearance = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(616, 30);
            this.txtNombreUsuario.TabIndex = 156;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.EditValue = "";
            this.txtCorreoUsuario.Location = new System.Drawing.Point(20, 149);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreoUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtCorreoUsuario.Properties.UseReadOnlyAppearance = false;
            this.txtCorreoUsuario.Size = new System.Drawing.Size(282, 30);
            this.txtCorreoUsuario.TabIndex = 159;
            // 
            // btnAdjunto
            // 
            this.btnAdjunto.FlatAppearance.BorderSize = 0;
            this.btnAdjunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjunto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdjunto.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAdjunto.IconColor = System.Drawing.Color.Black;
            this.btnAdjunto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjunto.IconSize = 30;
            this.btnAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjunto.Location = new System.Drawing.Point(653, 202);
            this.btnAdjunto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdjunto.Name = "btnAdjunto";
            this.btnAdjunto.Size = new System.Drawing.Size(40, 32);
            this.btnAdjunto.TabIndex = 162;
            this.btnAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdjunto.UseVisualStyleBackColor = true;
            this.btnAdjunto.Click += new System.EventHandler(this.btnAdjunto_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.EditValue = "";
            this.txtRutaArchivo.Location = new System.Drawing.Point(20, 204);
            this.txtRutaArchivo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRutaArchivo.Properties.Appearance.Options.UseFont = true;
            this.txtRutaArchivo.Size = new System.Drawing.Size(616, 30);
            this.txtRutaArchivo.TabIndex = 161;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnGuardarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarUsuario.IconSize = 30;
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(452, 278);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(241, 52);
            this.btnGuardarUsuario.TabIndex = 163;
            this.btnGuardarUsuario.Text = "Guardar Usuario";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 374);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.btnAdjunto);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRutaArchivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit txtCorreoUsuario;
        private FontAwesome.Sharp.IconButton btnAdjunto;
        private DevExpress.XtraEditors.TextEdit txtRutaArchivo;
        private FontAwesome.Sharp.IconButton btnGuardarUsuario;
    }
}