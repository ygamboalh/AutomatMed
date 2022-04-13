using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmLoadingSave : WaitForm
    {
        public frmLoadingSave()
        {
            InitializeComponent();
           
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
           
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}