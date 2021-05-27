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
    public partial class FrmAssembly : Form
    {
        private List<bool> switchBool;

        public FrmAssembly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            LoadOrderSelected();
            LoadBoolFalse();
        }


        private void LoadOrderSelected(int index = 0)
        {
            int n = dgvOrder.Rows.Add();
            /*
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].NumberOrder);
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].NameDevice); 
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].ETypeDevice);
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].CountDevice); 
            */
            dgvOrder.Rows[0].Cells[0].Value = CoreSystem.InternalOrders[index].NumberOrder;
            dgvOrder.Rows[0].Cells[1].Value = CoreSystem.InternalOrders[index].NameDevice;
            dgvOrder.Rows[0].Cells[2].Value = CoreSystem.InternalOrders[index].ETypeDevice;
            dgvOrder.Rows[0].Cells[3].Value = CoreSystem.InternalOrders[index].CountDevice;

        }

        private void LoadBoolFalse()
        {
            switchBool = new List<bool>();
            for (int i = 0; i < 16; i++)
            {
                switchBool.Add(false);
            }
        }

        private void btnMother_Click(object sender, EventArgs e)
        {
            if (switchBool[0] == false)
            {
                this.btnMother.ImageIndex = 1;
            }
            else
            {
                this.btnMother.ImageIndex = 0;
            }
            switchBool[0] = !switchBool[0];
        }

        private void btnCore_Click(object sender, EventArgs e)
        {
            if (switchBool[1] == false)
            {
                this.btnCore.ImageIndex = 1;
            }
            else
            {
                this.btnCore.ImageIndex = 0;
            }
            switchBool[1] = !switchBool[1];
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            if (switchBool[2] == false)
            {
                this.btnPackage.ImageIndex = 1;
            }
            else
            {
                this.btnPackage.ImageIndex = 0;
            }
            switchBool[2] = !switchBool[2];
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            if (switchBool[3] == false)
            {
                this.btnCase.ImageIndex = 1;
            }
            else
            {
                this.btnCase.ImageIndex = 0;
            }
            switchBool[3] = !switchBool[3];
        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (switchBool[4] == false)
            {
                this.btnDisplay.ImageIndex = 1;
            }
            else
            {
                this.btnDisplay.ImageIndex = 0;
            }
            switchBool[4] = !switchBool[4];
        }

        private void btnTouch_Click(object sender, EventArgs e)
        {
            if (switchBool[5] == false)
            {
                this.btnTouch.ImageIndex = 1;
            }
            else
            {
                this.btnTouch.ImageIndex = 0;
            }
            switchBool[5] = !switchBool[5];
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            if (switchBool[6] == false)
            {
                this.btnKeyboard.ImageIndex = 1;
            }
            else
            {
                this.btnKeyboard.ImageIndex = 0;                
            }
            switchBool[6] = !switchBool[6];
        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            if (switchBool[7] == false)
            {
                this.btnLed.ImageIndex = 1;
            }
            else
            {
                this.btnLed.ImageIndex = 0;
            }
            switchBool[7] = !switchBool[7];
        }

        private void btnFingerPrint_Click(object sender, EventArgs e)
        {
            if (switchBool[8] == false)
            {
                this.btnFingerPrint.ImageIndex = 1;
            }
            else
            {
                this.btnFingerPrint.ImageIndex = 0;
            }
            switchBool[8] = !switchBool[8];
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if (switchBool[9] == false)
            {
                this.btnCamera.ImageIndex = 1;
            }
            else
            {
                this.btnCamera.ImageIndex = 0;
            }
            switchBool[9] = !switchBool[9];
        }

        private void btnSpiralRFID_Click(object sender, EventArgs e)
        {
            if (switchBool[10] == false)
            {
                this.btnSpiralRFID.ImageIndex = 1;
            }
            else
            {
                this.btnSpiralRFID.ImageIndex = 0;
            }
            switchBool[10] = !switchBool[10];
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            if (switchBool[11] == false)
            {
                this.btnTemperature.ImageIndex = 1;
            }
            else
            {
                this.btnTemperature.ImageIndex = 0;
            }
            switchBool[11] = !switchBool[11];
        }

        private void btnRelay_Click(object sender, EventArgs e)
        {
            if (switchBool[12] == false)
            {
                this.btnRelay.ImageIndex = 1;
            }
            else
            {
                this.btnRelay.ImageIndex = 0;
            }
            switchBool[12] = !switchBool[12];
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            if (switchBool[13] == false)
            {
                this.btnFace.ImageIndex = 1;
            }
            else
            {
                this.btnFace.ImageIndex = 0;
            }
            switchBool[13] = !switchBool[13];
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (switchBool[14] == false)
            {
                this.btnTime.ImageIndex = 1;
            }
            else
            {
                this.btnTime.ImageIndex = 0;
            }
            switchBool[14] = !switchBool[14];
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (switchBool[15] == false)
            {
                this.btnSound.ImageIndex = 1;
            }
            else
            {
                this.btnSound.ImageIndex = 0;
            }
            switchBool[15] = !switchBool[15];
        }
    }
}
