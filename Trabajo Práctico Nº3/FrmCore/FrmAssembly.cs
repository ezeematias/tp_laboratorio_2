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
            CoreSystem.ListAssembly = null;
            if (!(CoreSystem.SelectedOrder is null) && !(CoreSystem.PreviewDevices is null))
            {
                ButtonForType(CoreSystem.SelectedOrder.ETypeDevice);
                dgvPreview.DataSource = new BindingList<Device>(CoreSystem.PreviewDevices);
            }
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
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (CoreSystem.SelectedOrder.ETypeDevice == eType && !(CoreSystem.ListAssembly is null) && pressButton == true)
            {
                if (Stock.ThereIsStock(CoreSystem.ListAssembly, out string component))
                {
                    CoreSystem.LoadDevices(eType,eValidation);
                    CoreSystem.PreviewDevices.Add(CoreSystem.DeviceAssembly);
                    CoreSystem.DeviceAssembly = null;
                    PressButton();
                    LoadListAssembly();
                    TrasparentButtonsSubPanel();
                    HideSubMenu();
                }
                else
                {
                    MessageBox.Show($"The missing materials are:\n\n{component}", "NO STOCK!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(btnAttendance);
            ShowSubMenu(pnlAT);
        }

        private void btnAccessControl_Click(object sender, EventArgs e)
        {
            this.eType = EType.AccessControl;
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(btnAccessControl);
            ShowSubMenu(pnlAC);
        }
        private void btnPanelAccess_Click(object sender, EventArgs e)
        {
            this.eType = EType.PanelAccess;
            ShowSerialNumber();
            PressButton();
            ButtonFormatColor(btnPanelAccess);
            ShowSubMenu(pnlPA);
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
            pressButton = !pressButton;
            if (pressButton == false)
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
            eValidation = EValidation.Finger;
            ButtonFormatColor(btnFingerRFIDPA);
            ButtonFormatTransparent(btnRFIDPA);
            BuilderDevice();
        }

        private void btnRFIDPA_Click(object sender, EventArgs e)
        {
            eValidation = EValidation.Card;
            ButtonFormatColor(btnRFIDPA);
            ButtonFormatTransparent(btnFingerRFIDPA);
            BuilderDevice();
        }

        private void btnFingerAT_Click(object sender, EventArgs e)
        {
            eValidation = EValidation.Finger;
            ButtonFormatColor(btnFingerAT);
            ButtonFormatTransparent(btnFaceAT);
            BuilderDevice();
        }

        private void btnFaceAT_Click(object sender, EventArgs e)
        {
            eValidation = EValidation.Face;
            ButtonFormatColor(btnFaceAT);
            ButtonFormatTransparent(btnFingerAT);
            BuilderDevice();
        }

        private void btnFingerAC_Click(object sender, EventArgs e)
        {
            eValidation = EValidation.Finger;
            ButtonFormatColor(btnFingerAC);
            ButtonFormatTransparent(btnFaceAC);
            BuilderDevice();
        }

        private void btnFaceAC_Click(object sender, EventArgs e)
        {
            eValidation = EValidation.Face;
            ButtonFormatColor(btnFaceAC);
            ButtonFormatTransparent(btnFingerAC);
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //TODO: Faltan todas las validaciones y mensajes para continuar una vez agregada la lista.
            Stock.DevicesStock.AddRange(CoreSystem.PreviewDevices);
            CoreSystem.PreviewDevices.Clear();
            LoadListAssembly();
            CoreSystem.InternalOrders.Remove(CoreSystem.SelectedOrder);
            CoreSystem.SelectedOrder = null;
            dgvOrder.DataSource = null;
            EnableButtons();
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            //TODO: Falta aghregar uan exception cuando no hay para borrar dispositivos.
            //"No divices for delete"

            Device aux = (Device)dgvPreview.CurrentRow.DataBoundItem;
            CoreSystem.PreviewDevices.Remove(aux);
            LoadListAssembly();
        }

        private void ShowSerialNumber()
        {
            this.lblSerialNumber.Text = SerialsNumbers.GetSerialNumberByType(eType).ToString();
        }
    }
}
