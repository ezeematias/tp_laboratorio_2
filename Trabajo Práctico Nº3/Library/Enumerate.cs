using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum ECode
    {
        UT_BioPanel_ACC,
        UT_ReadPanel_ACC,
        UT_FingerAtt_ID,
        UT_FingerAcc_ID,
        UT_FaceDepot_ID,       
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
