
namespace TacticaReparaciones.DesktopApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmpMenu1 = new TacticaReparaciones.DesktopApp.Componentes.Menu.cmpMenu();
            this.SuspendLayout();
            // 
            // cmpMenu1
            // 
            this.cmpMenu1.BackColor = System.Drawing.SystemColors.Control;
            this.cmpMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmpMenu1.ExpandirMenu = true;
            this.cmpMenu1.Location = new System.Drawing.Point(0, 0);
            this.cmpMenu1.MaximumSize = new System.Drawing.Size(320, 0);
            this.cmpMenu1.MinimumSize = new System.Drawing.Size(60, 0);
            this.cmpMenu1.Name = "cmpMenu1";
            this.cmpMenu1.Size = new System.Drawing.Size(320, 526);
            this.cmpMenu1.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 526);
            this.Controls.Add(this.cmpMenu1);
            this.Name = "FrmPrincipal";
            this.Text = "Tactica Reparaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.Menu.cmpMenu cmpMenu1;
    }
}

