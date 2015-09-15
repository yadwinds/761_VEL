using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSkills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetSkills.Controllers;
using System.Web.Mvc;

namespace GetSkills.Tests.Controllers
{
    [TestClass]
    public class ManageControllerTest
    {
        [TestMethod]
        public void ManageController_Index_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.AddPhoneSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.ChangePasswordSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test03()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.SetTwoFactorSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test04()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.SetPasswordSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test05()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.RemoveLoginSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test06()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.RemovePhoneSuccess;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_Index_Test07()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.Error;

            // To test if it is null
            var result = ctl.Index(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_RemoveLogin_Test()
        {
            // Initialization
            ManageController ctl = new ManageController();
            string provider = "Admin";
            string key = "888888";

            // To test if it is null
            var result = ctl.RemoveLogin(provider,key);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_AddPhoneNumber_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.AddPhoneNumber();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_AddPhoneNumber_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            AddPhoneNumberViewModel model = new AddPhoneNumberViewModel();

            // To test if it is null
            var result = ctl.AddPhoneNumber(model);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_EnableTwoFactorAuthentication_Test0()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.EnableTwoFactorAuthentication();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_DisableTwoFactorAuthentication_Test0()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.DisableTwoFactorAuthentication();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_VerifyPhoneNumber_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();
            string number = "9999";

            // To test if it is null
            var result = ctl.VerifyPhoneNumber(number);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_VerifyPhoneNumber_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            VerifyPhoneNumberViewModel model = new VerifyPhoneNumberViewModel();

            // To test if it is null
            var result = ctl.VerifyPhoneNumber(model);
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void ManageController_ChangePassword_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.ChangePassword();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ChangePassword_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ChangePasswordViewModel model = new ChangePasswordViewModel();

            // To test if it is null
            var result = ctl.ChangePassword(model);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_SetPassword_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.SetPassword();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_SetPassword_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            SetPasswordViewModel model = new SetPasswordViewModel();

            // To test if it is null
            var result = ctl.SetPassword(model);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test01()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.AddPhoneSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test02()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.ChangePasswordSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test03()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.Error;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test04()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.RemoveLoginSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test05()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.RemovePhoneSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test06()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.SetPasswordSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_ManageLogins_Test07()
        {
            // Initialization
            ManageController ctl = new ManageController();
            ManageController.ManageMessageId message = ManageController.ManageMessageId.SetTwoFactorSuccess;

            // To test if it is null
            var result = ctl.ManageLogins(message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ManageController_LinkLoginCallback_Test()
        {
            // Initialization
            ManageController ctl = new ManageController();

            // To test if it is null
            var result = ctl.LinkLoginCallback();
            Assert.IsNotNull(result);
        }
    }
}
