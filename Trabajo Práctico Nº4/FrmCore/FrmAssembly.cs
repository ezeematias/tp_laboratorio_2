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
using SQL;
using System.Threading;

namespace FrmCore
{
    public delegate void CallBackAssembly();
    public partial class FrmAssembly : Form
    {
        public event CallBackAssembly ChangeForm;

        private EType eType;
        private EValidation eValidation;
        private bool pressButton = false;

        /// <summary>
        /// Builder default
        /// </summary>
        public FrmAssembly()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Form Default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            try
            { 
                this.lblErrorList.Visible = false;                
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
            catch (Exception ex)
            {
                this.Enabled = false;
                MessageBox.Show(ex.Message, "NO DATA DEVICES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProgressBarDevices(object o)
        {        
            this.pgbStatusOrder.Value = CoreSystem.ListAssembly.Count / CoreSystem.InternalOrders.Count * 100;        
        }

        /// <summary>
        /// Loading the selected order list.
        /// </summary>
        private void LoadOrderSelected()
        {
            this.dgvOrder.DataSource = null;
            this.dgvOrder.DataSource = new List<InternalOrder> { CoreSystem.SelectedOrder };
        }

        /// <summary>
        /// Loading the list of previous devices.
        /// </summary>
        private void LoadListAssembly()
        {
            this.dgvPreview.DataSource = null;
            this.dgvPreview.DataSource = CoreSystem.PreviewDevices;
        }

        /// <summary>
        /// Add a device.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            try
            {
                if (CoreSystem.SelectedOrder.ETypeDevice == eType && !(CoreSystem.ListAssembly is null) && this.pressButton == true)
                {
                    if (CoreSystem.PreviewDevices.Count < CoreSystem.SelectedOrder.CountDevice || MessageBox.Show($"The quantity requested in the order has already been reached. Do you want to assemble the device anyway?", "LIMIT DEVICES", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        if (Stock.ThereIsStock(CoreSystem.ListAssembly, out string component))
                        {
                            CoreSystem.LoadDevices(eType, eValidation);
                            CoreSystem.PreviewDevices.Add(CoreSystem.DeviceAssembly);
                            this.pgbStatusOrder.Value = (int)((float)CoreSystem.PreviewDevices.Count / CoreSystem.SelectedOrder.CountDevice * 100);
                            Device.SaveLogDevices(CoreSystem.DeviceAssembly, "Assembly");
                            CoreSystem.DeviceAssembly = null;
                            SerialsNumbers.SaveSerialsNumbers();                            
                            DAO.ModifyListComponents(Stock.ComponentsStock);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO ADD DEVICE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Build a device.
        /// </summary>
        private void BuilderDevice()
        {
            try
            {
                CoreSystem.ListAssembly = null;
                CoreSystem.LoadListAssembly(eType, eValidation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO BUILDER DEVICES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hide the buttons of the sub menu of the devices
        /// </summary>
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

        /// <summary>
        /// Show the sub menu buttons of the selected panel.
        /// </summary>
        /// <param name="subMenu">Panel to be displayed</param>
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

        /// <summary>
        /// Button for attendance equipment, enables the options for this model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.eType = EType.Attendance;
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(this.btnAttendance);
            ShowSubMenu(this.pnlAT);
        }

        /// <summary>
        /// Button for access control equipment, enables the options for this model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccessControl_Click(object sender, EventArgs e)
        {
            this.eType = EType.AccessControl;
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(this.btnAccessControl);
            ShowSubMenu(this.pnlAC);
        }

        /// <summary>
        /// Button for panel access equipment, enables the options for this model.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPanelAccess_Click(object sender, EventArgs e)
        {
            this.eType = EType.PanelAccess;
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(this.btnPanelAccess);
            ShowSubMenu(this.pnlPA);
        }

        /// <summary>
        /// Lock the form.
        /// </summary>
        private void EnableButtons()
        {
            if (CoreSystem.SelectedOrder is null)
            {
                this.Enabled = false;
            }
        }

        /// <summary>
        /// Options to handle states of pressed buttons.
        /// </summary>
        private void PressButton()
        {
            this.pressButton = !pressButton;
            if (this.pressButton == false)
            {
                CoreSystem.ListAssembly = null;
            }
        }

        /// <summary>
        /// Displays a new form with the components of the selected team.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Fingerprint and card button option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFingerRFIDPA_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerRFIDPA);
            ButtonFormatTransparent(this.btnRFIDPA);
            BuilderDevice();
        }

        /// <summary>
        /// Card button option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRFIDPA_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Card;
            ButtonFormatColor(this.btnRFIDPA);
            ButtonFormatTransparent(this.btnFingerRFIDPA);
            BuilderDevice();
        }

        /// <summary>
        /// Fingerprint button option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFingerAT_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerAT);
            ButtonFormatTransparent(this.btnFaceAT);
            BuilderDevice();
        }

        /// <summary>
        /// Face button option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFaceAT_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Face;
            ButtonFormatColor(this.btnFaceAT);
            ButtonFormatTransparent(this.btnFingerAT);
            BuilderDevice();
        }

        /// <summary>
        /// Fingerprint button option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFingerAC_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Finger;
            ButtonFormatColor(this.btnFingerAC);
            ButtonFormatTransparent(this.btnFaceAC);
            BuilderDevice();
        }

        /// <summary>
        /// Face button option.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFaceAC_Click(object sender, EventArgs e)
        {
            this.eValidation = EValidation.Face;
            ButtonFormatColor(this.btnFaceAC);
            ButtonFormatTransparent(this.btnFingerAC);
            BuilderDevice();
        }

        /// <summary>
        /// Button color format.
        /// </summary>
        /// <param name="button">Button for format</param>
        private void ButtonFormatColor(Button button)
        {
            button.BackColor = Color.FromArgb(64, 0, 64);
        }

        /// <summary>
        /// Button trasparent format.
        /// </summary>
        /// <param name="button">Button for format</param>
        private void ButtonFormatTransparent(Button button)
        {
            button.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Format all buttons.
        /// </summary>
        private void TrasparentButtonsSubPanel()
        {
            ButtonFormatTransparent(this.btnFingerAC);
            ButtonFormatTransparent(this.btnFaceAC);
            ButtonFormatTransparent(this.btnRFIDPA);
            ButtonFormatTransparent(this.btnFingerRFIDPA);
            ButtonFormatTransparent(this.btnFingerAT);
            ButtonFormatTransparent(this.btnFaceAT);
        }

        /// <summary>
        /// It depends on the device to create, enable the buttons.
        /// </summary>
        /// <param name="type"></param>
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

        /// <summary>
        /// Upload the previous list to the central stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (CoreSystem.PreviewDevices.Count == CoreSystem.SelectedOrder.CountDevice ||
                    (CoreSystem.PreviewDevices.Count > CoreSystem.SelectedOrder.CountDevice) &&
                    (MessageBox.Show($"The limit of devices requested in the order is exceeded.Do you want to load it into stock anyway?", "EXCEED THE LIMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) ||
                    (CoreSystem.PreviewDevices.Count < CoreSystem.SelectedOrder.CountDevice && CoreSystem.PreviewDevices.Count > 0) &&
                    (MessageBox.Show($"It remains to create devices to fulfill the order. Do you want to load without finishing the order?", "DOES NOT COMPLY WITH REQUESTS", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes))
                {
                    Device.SaveReportsDevices(CoreSystem.PreviewDevices);
                    DAO.SaveDevice(CoreSystem.PreviewDevices);
                    Stock.UpdateDevicesStock();
                    LoadListAssembly();
                    CoreSystem.InternalOrders.Remove(CoreSystem.SelectedOrder);
                    CoreSystem.SelectedOrder = null;
                    this.dgvOrder.DataSource = null;
                    HideSubMenu();
                    EnableButtons();
                    this.lblErrorList.Visible = false;
                    InternalOrder.SaveInternalOrder();
                    ChangeAssembly();
                }
                else
                {
                    this.lblErrorList.Visible = true;
                    this.lblErrorList.Text = "No devices to add to stock";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO SAVE FILE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove the selected device from the previous list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// The serial number is displayed.
        /// </summary>
        private void ShowSerialNumber()
        {
            this.lblSerialNumber.Text = SerialsNumbers.GetSerialNumberByType(eType).ToString();
        }

        /// <summary>
        /// Event generated to change the form.
        /// </summary>
        private void ChangeAssembly()
        {
            if (!(this.ChangeForm is null))
            {
                this.ChangeForm.Invoke();
            }
        }
    }
}
