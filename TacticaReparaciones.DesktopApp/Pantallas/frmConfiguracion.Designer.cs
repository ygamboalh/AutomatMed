
namespace TacticaReparaciones.DesktopApp.Pantallas
{
    partial class frmConfiguracion
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
            this.components = new System.ComponentModel.Container();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tipoInstrumento = new System.Windows.Forms.MenuStrip();
            this.tipoInstrumentoMenu = new FontAwesome.Sharp.IconMenuItem();
            this.marcaMenu = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.clasificacionInstrumentoMenu = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            this.tipoInstrumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // popupMenu2
            // 
            this.popupMenu2.Name = "popupMenu2";
            // 
            // tipoInstrumento
            // 
            this.tipoInstrumento.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.tipoInstrumento.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tipoInstrumento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoInstrumentoMenu,
            this.marcaMenu,
            this.iconMenuItem1,
            this.clasificacionInstrumentoMenu});
            this.tipoInstrumento.Location = new System.Drawing.Point(0, 0);
            this.tipoInstrumento.Name = "tipoInstrumento";
            this.tipoInstrumento.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.tipoInstrumento.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tipoInstrumento.Size = new System.Drawing.Size(1175, 28);
            this.tipoInstrumento.TabIndex = 0;
            this.tipoInstrumento.Text = "Tipos de Instrumento";
            // 
            // tipoInstrumentoMenu
            // 
            this.tipoInstrumentoMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.tipoInstrumentoMenu.IconColor = System.Drawing.Color.Black;
            this.tipoInstrumentoMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tipoInstrumentoMenu.Name = "tipoInstrumentoMenu";
            this.tipoInstrumentoMenu.Size = new System.Drawing.Size(183, 24);
            this.tipoInstrumentoMenu.Text = "Tipos de Instrumento";
            this.tipoInstrumentoMenu.Click += new System.EventHandler(this.tipoInstrumentoMenu_Click);
            // 
            // marcaMenu
            // 
            this.marcaMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.marcaMenu.IconColor = System.Drawing.Color.Black;
            this.marcaMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.marcaMenu.Name = "marcaMenu";
            this.marcaMenu.Size = new System.Drawing.Size(90, 24);
            this.marcaMenu.Text = "Marcas";
            this.marcaMenu.Click += new System.EventHandler(this.marcaMenu_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.iconMenuItem1.Text = "Modelos";
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // clasificacionInstrumentoMenu
            // 
            this.clasificacionInstrumentoMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            this.clasificacionInstrumentoMenu.IconColor = System.Drawing.Color.Black;
            this.clasificacionInstrumentoMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clasificacionInstrumentoMenu.Name = "clasificacionInstrumentoMenu";
            this.clasificacionInstrumentoMenu.Size = new System.Drawing.Size(250, 24);
            this.clasificacionInstrumentoMenu.Text = "Clasificaciones de Instrumentos";
            this.clasificacionInstrumentoMenu.Click += new System.EventHandler(this.clasificacionInstrumentoMenu_Click);
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 601);
            this.Controls.Add(this.tipoInstrumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.tipoInstrumento;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmConfiguracion";
            this.Text = "Configuraciones";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            this.tipoInstrumento.ResumeLayout(false);
            this.tipoInstrumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private System.Windows.Forms.MenuStrip tipoInstrumento;
        private FontAwesome.Sharp.IconMenuItem tipoInstrumentoMenu;
        private FontAwesome.Sharp.IconMenuItem marcaMenu;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem clasificacionInstrumentoMenu;
    }
}