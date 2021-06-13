using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Library;
using LoginOperators;

namespace TestDevices
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class Test_Devices
    {
        /// <summary>
        /// An access panel device is created and the list of components within the object is verified to be created correctly.
        /// </summary>
        [TestMethod]
        public void Test_AccessPanel_List_Instance_In_Devices()
        {
            //Arrange
            AccessPanel accessPanel;

            //Act
            accessPanel = new AccessPanel(ECode.CNT_A60_ID, EType.PanelAccess, 2, EValidation.Card);

            //Assert           
            Assert.IsNotNull(accessPanel.Components);

        }

        /// <summary>
        /// A previous list of devices is created to later call the method that updates the stock.
        /// </summary>
        [TestMethod]
        public void Test_Devices_Update_Stock()
        {
            //Arrange
            AccessControl accessControl = new AccessControl(ECode.CNT_A60_ID, EType.AccessControl, EValidation.Card);
            Attendance attendance = new Attendance(ECode.CNT_A60_ID, EType.Attendance, EValidation.Card);
            AccessPanel accessPanel = new AccessPanel(ECode.CNT_A60_ID, EType.PanelAccess, 2, EValidation.Card);

            //Act
            CoreSystem.PreviewDevices.Add(accessControl);
            CoreSystem.PreviewDevices.Add(attendance);
            CoreSystem.PreviewDevices.Add(accessPanel);
            Stock.UpdateDevicesStock();

            //Assert        
            Assert.IsNotNull(Stock.DevicesStock);
            Assert.IsTrue(Stock.DevicesStock.Contains(accessPanel));
        }

        /// <summary>
        /// Check that the user is loaded correctly.
        /// </summary>
        [TestMethod]
        public void Test_Operator_Login()
        {
            //Arrange
            Operator operatorTest = new Operator("Test", "Devices", 9999, 9999);
            Login.Operators = new List<Operator>();

            //Act 
            Login.Operators.Add(operatorTest);

            //Assert
            Assert.IsTrue(Login.Operators.Count > 0);
            Assert.IsTrue(Login.LogIn(operatorTest.UserID, operatorTest.Pass));
        }

    }
}
