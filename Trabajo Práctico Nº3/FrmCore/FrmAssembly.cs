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
        private EType eType;

        public FrmAssembly()
        {
            InitializeComponent();
        }

        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            LoadOrderSelected();
            LoadBoolFalse();
            HideSubMenu();
            EnableButtons();
            ButtonForType(CoreSystem.SelectedOrder.ETypeDevice);
            LoadListAssembly();
        }

        private void LoadOrderSelected()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = new List<InternalOrder> { CoreSystem.SelectedOrder };
        }
        private void LoadListAssembly()
        {
            dgvPreview.DataSource = null;
            dgvPreview.DataSource = CoreSystem.PreviewDevices;
            //dgvPreview.DataSource = new BindingList<Device>(CoreSystem.PreviewDevices);
        }

        private void LoadBoolFalse()
        {
            switchBool = new List<bool>();
            for (int i = 0; i < 5; i++)
            {
                switchBool.Add(false);
            }
        }

        private void btnWiFi_Click(object sender, EventArgs e)
        {
            if (switchBool[0] == false)
            {
                this.btnWiFi.ImageIndex = 1;
            }
            else
            {
                this.btnWiFi.ImageIndex = 0;
            }
            switchBool[0] = !switchBool[0];
        }

        private void btnAdms_Click(object sender, EventArgs e)
        {
            if (switchBool[1] == false)
            {
                this.btnLAdms.ImageIndex = 1;
            }
            else
            {
                this.btnLAdms.ImageIndex = 0;
            }
            switchBool[1] = !switchBool[1];
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (switchBool[2] == false)
            {
                this.btnTemperature.ImageIndex = 1;
            }
            else
            {
                this.btnTemperature.ImageIndex = 0;
            }
            switchBool[2] = !switchBool[2];
        }

        private void btnRs32_Click(object sender, EventArgs e)
        {
            if (switchBool[3] == false)
            {
                this.btnRs32.ImageIndex = 1;
            }
            else
            {
                this.btnRs32.ImageIndex = 0;
            }
            switchBool[3] = !switchBool[3];
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (CoreSystem.SelectedOrder.ETypeDevice == eType && !(CoreSystem.DeviceAssembly is null))
            {
                CoreSystem.PreviewDevices.Add(CoreSystem.DeviceAssembly);
                CoreSystem.DeviceAssembly = null;
                LoadListAssembly();

            }
            else
            {
                MessageBox.Show("The device to be assembled must be of the same type as the order", "TYPE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuilderDevice()
        {
            CoreSystem.DeviceAssembly = null;
            switch (eType)
            {
                case EType.AccessControl:
                    CoreSystem.DeviceAssembly = new AccessControl(CoreSystem.SelectedOrder.NameDevice, EType.AccessControl, 111);                    
                    break;

                case EType.PanelAccess:
                    CoreSystem.DeviceAssembly = new AccessPanel(CoreSystem.SelectedOrder.NameDevice, EType.PanelAccess, 222, 2);                    
                    break;

                case EType.Attendance:
                    CoreSystem.DeviceAssembly = new Attendance(CoreSystem.SelectedOrder.NameDevice, EType.Attendance, 333);                    
                    break;
            }
        }

        private void HideSubMenu()
        {
            if (pnlAC.Visible)
            {
                pnlAC.Visible = false;
                ButtonFormatTransparent(btnAccessControl);
            }
            if (pnlAT.Visible)
            {
                pnlAT.Visible = false;
                ButtonFormatTransparent(btnAttendance);
            }
            if (pnlPA.Visible)
            {
                pnlPA.Visible = false;
                ButtonFormatTransparent(btnPanelAccess);
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
                TrasparentButtonsSubPanel();
            }
            else
            {
                subMenu.Visible = false;
                ButtonFormatTransparent(btnPanelAccess);
                ButtonFormatTransparent(btnAttendance);
                ButtonFormatTransparent(btnAccessControl);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.eType = EType.Attendance;
            ButtonFormatColor(btnAttendance);
            ShowSubMenu(pnlAT);
            //BuilderDevice();
        }

        private void btnAccessControl_Click(object sender, EventArgs e)
        {
            this.eType = EType.AccessControl;
            ButtonFormatColor(btnAccessControl);
            ShowSubMenu(pnlAC);
            //BuilderDevice();
        }
        private void btnPanelAccess_Click(object sender, EventArgs e)
        {
            this.eType = EType.PanelAccess;
            ButtonFormatColor(btnPanelAccess);
            ShowSubMenu(pnlPA);
            //BuilderDevice();
        }

        private void EnableButtons()
        {
            if (CoreSystem.SelectedOrder is null)
            {
                this.Enabled = false;
            }
        }

        private void btnViewListDevice_Click(object sender, EventArgs e)
        {

            if (!(CoreSystem.DeviceAssembly is null))
            {
                FrmPreviewComponent preview = new FrmPreviewComponent();
                preview.ShowDialog();
            }
            else
            {
                MessageBox.Show("No data loaded", "DATA ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFingerRFIDPA_Click(object sender, EventArgs e)
        {
            ButtonFormatColor(btnFingerRFIDPA);
            ButtonFormatTransparent(btnRFIDPA);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.FingerPrint, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Relay, 2));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
        }

        private void btnRFIDPA_Click(object sender, EventArgs e)
        {
            ButtonFormatColor(btnRFIDPA);
            ButtonFormatTransparent(btnFingerRFIDPA);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Relay, 2));

        }

        private void btnFingerAT_Click(object sender, EventArgs e)
        {
            ButtonFormatColor(btnFingerAT);
            ButtonFormatTransparent(btnFaceAT);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.FingerPrint, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.TimeLog, 1));
        }

        private void btnFaceAT_Click(object sender, EventArgs e)
        {
            ButtonFormatColor(btnFaceAT);
            ButtonFormatTransparent(btnFingerAT);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Face, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Camera, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.TimeLog, 1));
        }

        private void btnFingerAC_Click(object sender, EventArgs e)
        {
            ButtonFormatColor(btnFingerAC);
            ButtonFormatTransparent(btnFaceAC);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.FingerPrint, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Relay, 1));

        }

        private void btnFaceAC_Click(object sender, EventArgs e)
        {            
            ButtonFormatColor(btnFaceAC);
            ButtonFormatTransparent(btnFingerAC);
            BuilderDevice();
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Face, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Camera, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.RFID, 1));
            CoreSystem.DeviceAssembly.Components.Add(new Components(EComponents.Relay, 1));
        }

        private void ButtonFormatColor(Button button)
        {
            button.BackColor = Color.FromArgb(77, 30, 91);
        }
        private void ButtonFormatTransparent(Button button)
        {
            button.BackColor = Color.Transparent;
        }

        private void TrasparentButtonsSubPanel()
        {
            ButtonFormatTransparent(btnFingerAC);
            ButtonFormatTransparent(btnFaceAC);
            ButtonFormatTransparent(btnRFIDPA);
            ButtonFormatTransparent(btnFingerRFIDPA);
            ButtonFormatTransparent(btnFingerAT);
            ButtonFormatTransparent(btnFaceAT);
        }

        private void ButtonForType(EType type)
        {
            switch (type)
            {
                case EType.AccessControl:
                    btnAccessControl.Enabled = true;
                    btnAttendance.Enabled = false;
                    btnPanelAccess.Enabled = false;
                    break;
                case EType.PanelAccess:
                    btnAccessControl.Enabled = false;
                    btnAttendance.Enabled = false;
                    btnPanelAccess.Enabled = true;
                    break;

                case EType.Attendance:
                    btnAccessControl.Enabled = false;
                    btnAttendance.Enabled = true;
                    btnPanelAccess.Enabled = false;
                    break;

            }
        }

    }
}
