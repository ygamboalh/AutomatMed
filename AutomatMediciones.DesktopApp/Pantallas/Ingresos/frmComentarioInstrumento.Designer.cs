
namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    partial class frmComentarioInstrumento
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
            this.memoComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnIngresarComentario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoComentarios
            // 
            this.memoComentarios.Location = new System.Drawing.Point(13, 49);
            this.memoComentarios.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.memoComentarios.Name = "memoComentarios";
            this.memoComentarios.Size = new System.Drawing.Size(567, 201);
            this.memoComentarios.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(11, 26);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(277, 17);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Ingrese Comentarios para Ingresar Instrumento";
            // 
            // btnIngresarComentario
            // 
            this.btnIngresarComentario.FlatAppearance.BorderSize = 0;
            this.btnIngresarComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarComentario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarComentario.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnIngresarComentario.IconColor = System.Drawing.Color.Black;
            this.btnIngresarComentario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresarComentario.IconSize = 30;
            this.btnIngresarComentario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarComentario.Location = new System.Drawing.Point(360, 274);
            this.btnIngresarComentario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIngresarComentario.Name = "btnIngresarComentario";
            this.btnIngresarComentario.Size = new System.Drawing.Size(220, 52);
            this.btnIngresarComentario.TabIndex = 27;
            this.btnIngresarComentario.Text = "Ingresar Comentario";
            this.btnIngresarComentario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarComentario.UseVisualStyleBackColor = true;
            this.btnIngresarComentario.Click += new System.EventHandler(this.btnIngresarComentario_Click);
            // 
            // frmComentarioInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 353);
            this.Controls.Add(this.btnIngresarComentario);
            this.Controls.Add(this.memoComentarios);
            this.Controls.Add(this.labelControl7);
            this.Name = "frmComentarioInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentario de Instrumento";
            ((System.ComponentModel.ISupportInitialize)(this.memoComentarios.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoComentarios;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private FontAwesome.Sharp.IconButton btnIngresarComentario;
    }
}