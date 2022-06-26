
namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    partial class frmExtraccionCelda
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
            this.dateFechaExtraccion = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuardarExtraccion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaExtraccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaExtraccion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaExtraccion
            // 
            this.dateFechaExtraccion.EditValue = null;
            this.dateFechaExtraccion.Location = new System.Drawing.Point(27, 37);
            this.dateFechaExtraccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFechaExtraccion.Name = "dateFechaExtraccion";
            this.dateFechaExtraccion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaExtraccion.Properties.Appearance.Options.UseFont = true;
            this.dateFechaExtraccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaExtraccion.Size = new System.Drawing.Size(231, 18);
            this.dateFechaExtraccion.TabIndex = 158;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(27, 20);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(90, 12);
            this.labelControl15.TabIndex = 157;
            this.labelControl15.Text = "Fecha de Extracción:";
            // 
            // btnGuardarExtraccion
            // 
            this.btnGuardarExtraccion.FlatAppearance.BorderSize = 0;
            this.btnGuardarExtraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarExtraccion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarExtraccion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarExtraccion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarExtraccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarExtraccion.IconSize = 30;
            this.btnGuardarExtraccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarExtraccion.Location = new System.Drawing.Point(224, 79);
            this.btnGuardarExtraccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarExtraccion.Name = "btnGuardarExtraccion";
            this.btnGuardarExtraccion.Size = new System.Drawing.Size(138, 36);
            this.btnGuardarExtraccion.TabIndex = 159;
            this.btnGuardarExtraccion.Text = "Guardar";
            this.btnGuardarExtraccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarExtraccion.UseVisualStyleBackColor = true;
            this.btnGuardarExtraccion.Click += new System.EventHandler(this.btnGuardarExtraccion_Click);
            // 
            // frmExtraccionCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 126);
            this.Controls.Add(this.btnGuardarExtraccion);
            this.Controls.Add(this.dateFechaExtraccion);
            this.Controls.Add(this.labelControl15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExtraccionCelda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaExtraccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaExtraccion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateFechaExtraccion;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private FontAwesome.Sharp.IconButton btnGuardarExtraccion;
    }
}