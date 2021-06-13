using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace FrmCore
{
    public partial class FrmPreviewComponent : Form
    {
        /// <summary>
        /// Buide default.
        /// </summary>
        public FrmPreviewComponent()
        {
            InitializeComponent();            
        }

        /// <summary>
        /// Load form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPreviewComponent_Load(object sender, EventArgs e)
        {
            this.dgvPreview.DataSource = CoreSystem.ListAssembly;
        }
    }
}
