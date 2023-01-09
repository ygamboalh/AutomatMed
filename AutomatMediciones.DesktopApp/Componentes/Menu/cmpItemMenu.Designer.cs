namespace AutomatMediciones.DesktopApp.Componentes.Menu
{
    partial class cmpItemMenu
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
            this.pnlItemMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlMenuHijo = new System.Windows.Forms.Panel();
            this.pnlItemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlItemMenu
            // 
            this.pnlItemMenu.Controls.Add(this.btnMenu);
            this.pnlItemMenu.Controls.Add(this.pnlMenuHijo);
            this.pnlItemMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlItemMenu.Name = "pnlItemMenu";
            this.pnlItemMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlItemMenu.Size = new System.Drawing.Size(315, 41);
            this.pnlItemMenu.TabIndex = 19;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnMenu.IconColor = System.Drawing.Color.Black;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 20;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(11, -5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(304, 41);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // pnlMenuHijo
            // 
            this.pnlMenuHijo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuHijo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHijo.Name = "pnlMenuHijo";
            this.pnlMenuHijo.Size = new System.Drawing.Size(11, 36);
            this.pnlMenuHijo.TabIndex = 5;
            this.pnlMenuHijo.Visible = false;
            // 
            // cmpItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlItemMenu);
            this.Name = "cmpItemMenu";
            this.Size = new System.Drawing.Size(315, 41);
            this.pnlItemMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlItemMenu;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel pnlMenuHijo;
    }
}
