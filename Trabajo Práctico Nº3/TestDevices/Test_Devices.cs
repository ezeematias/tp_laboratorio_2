using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace TestDevices
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class Test_Devices
    {
        [TestMethod]
        public void Test_AccessControl_List_Instance()
        {
            //Arrange
            AccessControl accessControl = new AccessControl(ECode.CNT_A60_ID, EType.AccessControl, EValidation.Card);

            //Act


            //Assert        
            Assert.IsNotNull(accessControl.Components);

        }

        [TestMethod]
        public void Test_AccessPanel_List_Instance()
        {
            //Arrange
            AccessPanel accessPanel = new AccessPanel(ECode.CNT_A60_ID, EType.PanelAccess, 2, EValidation.Card);

            //Act


            //Assert           
            Assert.IsNotNull(accessPanel.Components);

        }

        [TestMethod]
        public void Test_Attendance_List_Instance()
        {
            //Arrange
            Attendance attendance = new Attendance(ECode.CNT_A60_ID, EType.Attendance, EValidation.Card);

            //Act


            //Assert           
            Assert.IsNotNull(attendance.Components);
        }

    }
}
