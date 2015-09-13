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
        private string returnUrl;

        public object ViewBag { get; private set; }

        [TestMethod]
        public void Login()
        {
            // Arrange
            AccountController controller = new AccountController();
            String f=returnUrl;
            // Act

            ViewResult result = controller.Login(returnUrl) as ViewResult; 

            // Assert
            Assert.IsNotNull(result);
        }


    }
    }
