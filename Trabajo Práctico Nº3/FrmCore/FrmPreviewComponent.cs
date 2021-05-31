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
        public FrmPreviewComponent()
        {
            InitializeComponent();            
        }
        private void FrmPreviewComponent_Load(object sender, EventArgs e)
        {
            dgvPreview.DataSource = CoreSystem.DeviceAssembly.Components;
        }
    }
}
