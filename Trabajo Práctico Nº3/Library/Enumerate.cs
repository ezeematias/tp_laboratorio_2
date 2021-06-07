using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
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

    public enum EType
    {
        AccessControl,
        PanelAccess,
        Attendance,
    }

    public enum EValidation
    {
        Finger,
        Face,
        Card
    }


}
