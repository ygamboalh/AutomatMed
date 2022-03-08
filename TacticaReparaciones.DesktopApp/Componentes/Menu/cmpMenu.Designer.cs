
namespace TacticaReparaciones.DesktopApp.Componentes.Menu
{
    partial class cmpMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmpLogo1 = new TacticaReparaciones.DesktopApp.Componentes.Menu.cmpLogo();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlExpandirMenu = new System.Windows.Forms.Panel();
            this.btnExpandirMenu = new FontAwesome.Sharp.IconButton();
            this.cmdIngresos = new FontAwesome.Sharp.IconButton();
            this.pnlMenuExpandido = new System.Windows.Forms.Panel();
            this.pnlMenuContraido = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlLogo.SuspendLayout();
            this.pnlExpandirMenu.SuspendLayout();
            this.pnlMenuExpandido.SuspendLayout();
            this.pnlMenuContraido.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmpLogo1
            // 
            this.cmpLogo1.BackColor = System.Drawing.Color.White;
            this.cmpLogo1.Location = new System.Drawing.Point(67, 22);
            this.cmpLogo1.MaximumSize = new System.Drawing.Size(172, 159);
            this.cmpLogo1.MinimumSize = new System.Drawing.Size(172, 159);
            this.cmpLogo1.Name = "cmpLogo1";
            this.cmpLogo1.Size = new System.Drawing.Size(172, 159);
            this.cmpLogo1.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.cmpLogo1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 40);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(36, 206);
            this.pnlLogo.TabIndex = 1;
            // 
            // pnlExpandirMenu
            // 
            this.pnlExpandirMenu.Controls.Add(this.btnExpandirMenu);
            this.pnlExpandirMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlExpandirMenu.Name = "pnlExpandirMenu";
            this.pnlExpandirMenu.Size = new System.Drawing.Size(36, 40);
            this.pnlExpandirMenu.TabIndex = 2;
            // 
            // btnExpandirMenu
            // 
            this.btnExpandirMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpandirMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExpandirMenu.FlatAppearance.BorderSize = 0;
            this.btnExpandirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandirMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnExpandirMenu.IconColor = System.Drawing.Color.Black;
            this.btnExpandirMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpandirMenu.IconSize = 25;
            this.btnExpandirMenu.Location = new System.Drawing.Point(0, 0);
            this.btnExpandirMenu.Name = "btnExpandirMenu";
            this.btnExpandirMenu.Size = new System.Drawing.Size(36, 40);
            this.btnExpandirMenu.TabIndex = 2;
            this.btnExpandirMenu.UseVisualStyleBackColor = false;
            this.btnExpandirMenu.Click += new System.EventHandler(this.btnExpandirMenu_Click);
            // 
            // cmdIngresos
            // 
            this.cmdIngresos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdIngresos.FlatAppearance.BorderSize = 0;
            this.cmdIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresos.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.cmdIngresos.IconColor = System.Drawing.Color.Black;
            this.cmdIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cmdIngresos.IconSize = 25;
            this.cmdIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdIngresos.Location = new System.Drawing.Point(0, 0);
            this.cmdIngresos.Name = "cmdIngresos";
            this.cmdIngresos.Size = new System.Drawing.Size(36, 31);
            this.cmdIngresos.TabIndex = 3;
            this.cmdIngresos.Text = "Ingresos";
            this.cmdIngresos.UseVisualStyleBackColor = false;
            this.cmdIngresos.Click += new System.EventHandler(this.cmdIngresos_Click);
            // 
            // pnlMenuExpandido
            // 
            this.pnlMenuExpandido.Controls.Add(this.cmdIngresos);
            this.pnlMenuExpandido.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuExpandido.Location = new System.Drawing.Point(0, 246);
            this.pnlMenuExpandido.Name = "pnlMenuExpandido";
            this.pnlMenuExpandido.Size = new System.Drawing.Size(36, 40);
            this.pnlMenuExpandido.TabIndex = 4;
            // 
            // pnlMenuContraido
            // 
            this.pnlMenuContraido.Controls.Add(this.iconButton1);
            this.pnlMenuContraido.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuContraido.Location = new System.Drawing.Point(0, 286);
            this.pnlMenuContraido.Name = "pnlMenuContraido";
            this.pnlMenuContraido.Size = new System.Drawing.Size(36, 40);
            this.pnlMenuContraido.TabIndex = 5;
            this.pnlMenuContraido.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 31);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // cmpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlMenuContraido);
            this.Controls.Add(this.pnlMenuExpandido);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlExpandirMenu);
            this.MaximumSize = new System.Drawing.Size(320, 0);
            this.MinimumSize = new System.Drawing.Size(36, 520);
            this.Name = "cmpMenu";
            this.Size = new System.Drawing.Size(36, 520);
            this.pnlLogo.ResumeLayout(false);
            this.pnlExpandirMenu.ResumeLayout(false);
            this.pnlMenuExpandido.ResumeLayout(false);
            this.pnlMenuContraido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private cmpLogo cmpLogo1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlExpandirMenu;
        private FontAwesome.Sharp.IconButton btnExpandirMenu;
        private FontAwesome.Sharp.IconButton cmdIngresos;
        private System.Windows.Forms.Panel pnlMenuExpandido;
        private System.Windows.Forms.Panel pnlMenuContraido;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
