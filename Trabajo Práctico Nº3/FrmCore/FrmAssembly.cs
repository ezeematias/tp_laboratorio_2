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
        private EType eType;
        private EValidation eValidation;
        private bool pressButton = false;

        public FrmAssembly()
        {
            InitializeComponent();
        }

        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            LoadOrderSelected();
            HideSubMenu();
            EnableButtons();
            SerialsNumbers.ReadSerialsNumbers();


            CoreSystem.ListAssembly = null;
            if (!(CoreSystem.SelectedOrder is null) && !(CoreSystem.PreviewDevices is null))
            {
                ButtonForType(CoreSystem.SelectedOrder.ETypeDevice);
                this.dgvPreview.DataSource = new BindingList<Device>(CoreSystem.PreviewDevices);
            }
        }

        private void LoadOrderSelected()
        {
            this.dgvOrder.DataSource = null;
            this.dgvOrder.DataSource = new List<InternalOrder> { CoreSystem.SelectedOrder };
        }
        private void LoadListAssembly()
        {
            this.dgvPreview.DataSource = null;
            this.dgvPreview.DataSource = CoreSystem.PreviewDevices;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (CoreSystem.SelectedOrder.ETypeDevice == eType && !(CoreSystem.ListAssembly is null) && this.pressButton == true)
            {
                if (CoreSystem.PreviewDevices.Count < CoreSystem.SelectedOrder.CountDevice || (MessageBox.Show($"The quantity requested in the order has already been reached. Do you want to assemble the device anyway?", "LIMIT DEVICES", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes))
                {
                    if (Stock.ThereIsStock(CoreSystem.ListAssembly, out string component))
                    {
                        CoreSystem.LoadDevices(eType, eValidation);
                        CoreSystem.PreviewDevices.Add(CoreSystem.DeviceAssembly);
                        Device.SaveLogDevices(CoreSystem.DeviceAssembly,"Assembly");
                        CoreSystem.DeviceAssembly = null;
                        PressButton();
                        LoadListAssembly();
                        TrasparentButtonsSubPanel();
                        HideSubMenu();
                        this.lblSerialNumber.Text = "--";
                    }
                    else
                    {
                        MessageBox.Show($"The missing materials are:\n\n{component}", "NO STOCK COMPONENTS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("The device to be assembled must be of the same type as the order", "TYPE ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuilderDevice()
        {
            CoreSystem.ListAssembly = null;
            CoreSystem.LoadListAssembly(eType, eValidation);
        }

        private void HideSubMenu()
        {
            if (this.pnlAC.Visible)
            {
                this.pnlAC.Visible = false;
                ButtonFormatTransparent(this.btnAccessControl);
            }
            if (this.pnlAT.Visible)
            {
                this.pnlAT.Visible = false;
                ButtonFormatTransparent(this.btnAttendance);
            }
            if (this.pnlPA.Visible)
            {
                this.pnlPA.Visible = false;
                ButtonFormatTransparent(this.btnPanelAccess);
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
                ButtonFormatTransparent(this.btnPanelAccess);
                ButtonFormatTransparent(this.btnAttendance);
                ButtonFormatTransparent(this.btnAccessControl);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.eType = EType.Attendance;
            ShowSerialNumber();
            SerialsNumbers.SaveSerialsNumbers();
            PressButton();
            ButtonFormatColor(this.btnAttendance);
            ShowSubMenu(this.pnlAT);
        }

        private void btnAccessControl_Click(object sender, EventArgs e)
        {
            this.eType = EType.AccessControl;
            ShowSerialNumber();
            SerialsNumbers.SaveSerialsNumbers();
            PressButton();
            ButtonFormatColor(this.btnAccessControl);
            ShowSubMenu(this.pnlAC);
        }
        private void btnPanelAccess_Click(object sender, EventArgs e)
        {
            this.eType = EType.PanelAccess;
            ShowSerialNumber();
            SerialsNumbers.SaveSerialsNumbers();
            PressButton();
            ButtonFormatColor(this.btnPanelAccess);
            ShowSubMenu(this.pnlPA);
        }

        private void EnableButtons()
        {
            if (CoreSystem.SelectedOrder is null)
            {
                this.Enabled = false;
            }
        }

        private void PressButton()
        {
            this.pressButton = !pressButton;
            if (this.pressButton == false)
            {
                CoreSystem.ListAssembly = null;
            }
        }

        private void btnViewListDevice_Click(object sender, EventArgs e)
        {
            if (!(CoreSystem.ListAssembly is null))
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
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerRFIDPA);
            ButtonFormatTransparent(this.btnRFIDPA);
            BuilderDevice();
        }

        private void btnRFIDPA_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Card;
            ButtonFormatColor(this.btnRFIDPA);
            ButtonFormatTransparent(this.btnFingerRFIDPA);
            BuilderDevice();
        }

        private void btnFingerAT_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerAT);
            ButtonFormatTransparent(this.btnFaceAT);
            BuilderDevice();
        }

        private void btnFaceAT_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Face;
            ButtonFormatColor(this.btnFaceAT);
            ButtonFormatTransparent(this.btnFingerAT);
            BuilderDevice();
        }

        private void btnFingerAC_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerAC);
            ButtonFormatTransparent(this.btnFaceAC);
            BuilderDevice();
        }

        private void btnFaceAC_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Face;
            ButtonFormatColor(this.btnFaceAC);
            ButtonFormatTransparent(this.btnFingerAC);
            BuilderDevice();
        }

        private void ButtonFormatColor(Button button)
        {
            button.BackColor = Color.FromArgb(64, 0, 64);
        }
        private void ButtonFormatTransparent(Button button)
        {
            button.BackColor = Color.Transparent;
        }

        private void TrasparentButtonsSubPanel()
        {
            ButtonFormatTransparent(this.btnFingerAC);
            ButtonFormatTransparent(this.btnFaceAC);
            ButtonFormatTransparent(this.btnRFIDPA);
            ButtonFormatTransparent(this.btnFingerRFIDPA);
            ButtonFormatTransparent(this.btnFingerAT);
            ButtonFormatTransparent(this.btnFaceAT);
        }

        private void ButtonForType(EType type)
        {
            switch (type)
            {
                case EType.AccessControl:
                    this.btnAccessControl.Enabled = true;
                    this.btnAttendance.Enabled = false;
                    this.btnPanelAccess.Enabled = false;
                    break;
                case EType.PanelAccess:
                    this.btnAccessControl.Enabled = false;
                    this.btnAttendance.Enabled = false;
                    this.btnPanelAccess.Enabled = true;
                    break;

                case EType.Attendance:
                    this.btnAccessControl.Enabled = false;
                    this.btnAttendance.Enabled = true;
                    this.btnPanelAccess.Enabled = false;
                    break;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //TODO: Faltan todas las validaciones y mensajes para continuar una vez agregada la lista.
            if (CoreSystem.PreviewDevices.Count == CoreSystem.SelectedOrder.CountDevice ||
                (CoreSystem.PreviewDevices.Count > CoreSystem.SelectedOrder.CountDevice) &&
                (MessageBox.Show($"The limit of devices requested in the order is exceeded.Do you want to load it into stock anyway?", "EXCEED THE LIMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) ||
                (CoreSystem.PreviewDevices.Count < CoreSystem.SelectedOrder.CountDevice && CoreSystem.PreviewDevices.Count > 0) &&
                (MessageBox.Show($"It remains to create devices to fulfill the order. Do you want to load without finishing the order?", "DOES NOT COMPLY WITH REQUESTS", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes))
            {
                Stock.DevicesStock.AddRange(CoreSystem.PreviewDevices);
                CoreSystem.PreviewDevices.Clear();
                LoadListAssembly();
                CoreSystem.InternalOrders.Remove(CoreSystem.SelectedOrder);
                CoreSystem.SelectedOrder = null;
                this.dgvOrder.DataSource = null;
                HideSubMenu();
                EnableButtons();
                Stock.SaveDevices();
            }
            else
            {
                MessageBox.Show("No devices to add to stock", "NO DATA DEVICES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (CoreSystem.PreviewDevices.Count > 0)
                {
                    Device aux = (Device)this.dgvPreview.CurrentRow.DataBoundItem;
                    Device.SaveLogDevices(aux, "Remove");
                    CoreSystem.PreviewDevices.Remove(aux);
                    LoadListAssembly();
                }
                else
                {
                    throw new Exception("No devices to remove");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO DATA DEVICES!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
        }

        private void ShowSerialNumber()
        {
            this.lblSerialNumber.Text = SerialsNumbers.GetSerialNumberByType(eType).ToString();            
        }
    }
}
