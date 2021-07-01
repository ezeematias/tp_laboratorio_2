using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Enumerate Code device
    /// </summary>
    public enum ECode
    {
        CNT_BioPanel_ACC,
        CNT_ReadPanel_ACC,
        CNT_A9_FC,
        CNT_A60_ID,
        CNT_E7_CR,
        CNT_E22_ID,
        CNT_FD5_FD,
        CNT_FD10_FC,
    }

    /// <summary>
    /// Enumerate Component
    /// </summary>
    public enum EComponents
    {
        Mother,
        Core,
        Package,
        Case,
        Display,
        Touch,
        Keyboard,
        Led,
        FingerPrint,
        Camera,
        RFID,
        Relay,
        Face,
        TimeLog,
        Sound,
    }

    /// <summary>
    /// Enumerate Type
    /// </summary>
    public enum EType
    {
        AccessControl,
        PanelAccess,
        Attendance,
    }

    /// <summary>
    /// Enumerate Validation
    /// </summary>
    public enum EValidation
    {
        Finger,
        Face,
        Card
    }

    public enum ELogo
    {
        Degrees0,
        Degrees30,
        Degrees60,
        Degrees90,
        Degrees120,
        Degrees150,
        Degrees180,
        Degrees210,
        Degrees240,
        Degrees270,
        Degrees300,
        Degrees330,
    }


}
