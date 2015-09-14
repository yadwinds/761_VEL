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
        public async Task AccountController_Login_Test02()
        {
            AccountController ctl = new AccountController();
            LoginViewModel mo = new LoginViewModel();
            mo.Email = "aaaa";
            mo.Password = "123456";
            mo.RememberMe = false;

            String url = "http://getskills.azurewebsites.net/";

            var result = await ctl.Login(mo,url);
            Assert.IsNotNull(result);
        }

    }
}
