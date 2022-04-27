
namespace AutomatMediciones.DesktopApp.Pantallas.Marcas
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
            this.btnGuardarMarca = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(14, 73);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 17);
            this.labelControl11.TabIndex = 121;
            this.labelControl11.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(14, 96);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Properties.Appearance.Options.UseFont = true;
            this.txtDescripcion.Size = new System.Drawing.Size(604, 30);
            this.txtDescripcion.TabIndex = 122;
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
            this.btnGuardarMarca.Location = new System.Drawing.Point(376, 151);
            this.btnGuardarMarca.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(242, 52);
            this.btnGuardarMarca.TabIndex = 126;
            this.btnGuardarMarca.Text = "Guardar Marca";
            this.btnGuardarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMarca.UseVisualStyleBackColor = true;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // frmNuevaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 260);
            this.Controls.Add(this.btnGuardarMarca);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private FontAwesome.Sharp.IconButton btnGuardarMarca;
    }
}