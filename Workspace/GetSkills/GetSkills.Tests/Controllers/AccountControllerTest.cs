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
    public class AccountControllerTest
    {
        [TestMethod]
        public void AccountController_Login_Test01()
        {
            AccountController ctl = new AccountController();
            String url = "http://getskills.azurewebsites.net/";
          
            ViewResult result = ctl.Login(url) as ViewResult; 
            Assert.IsNotNull(result);
        }

         [TestMethod]
         public void AccountController_Login_Test02()
         {
             AccountController ctl = new AccountController();
             LoginViewModel model = new LoginViewModel();
             model.Email = "aaaa";
             model.Password = "123456";
             model.RememberMe = false;

             String url = "http://getskills.azurewebsites.net/";

             var result = ctl.Login(model,url);
             Assert.IsNotNull(result);
         }

        [TestMethod]
        public void AccountController_VerifyCode_Test()
        {
            AccountController ctl = new AccountController();
            VerifyCodeViewModel model = null;

            var result = ctl.VerifyCode(model);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AccountController_Regitser_Test01()
        {
            AccountController ctl = new AccountController();

            var result = ctl.Register();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AccountController_Regitser_Test02()
        {
            AccountController ctl = new AccountController();
            RegisterViewModel model = null;
            var result = ctl.Register(model);
            Assert.IsNotNull(result);
        }
    }
}
