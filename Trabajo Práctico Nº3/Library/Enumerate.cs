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
        CNT_A9_CR,
        CNT_A60_ID,
        CNT_E7_CR,
        CNT_E22_ID,
        CNT_FD5_FD,
        CNT_FD10_FC,
    }

    public enum EType
    {
        FingerPrint,
        Face,
        Card,
    }

    public enum EComponents
    {
        Mother,
        Core,
        ModuleAccess,
        Display,
        FingerPrint,
        FaceCamera,
        ReadCard
    }


}
