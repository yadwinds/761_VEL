using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSkills.Controllers;
using GetSkills.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GetSkills.Tests.Controllers
{
    [TestClass]
    public class TeamProfilesControllersTest
    {
        [TestMethod]
        public void TeamProfilesController_Index_Test1()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Index();
            Assert.IsNotNull(result);

            // To test the number of the elements in the list
            var modelList = (List<ProfileIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(3, modelList.Count);
        }

        /// <summary>
        /// Case of no paramater
        /// </summary>
        [TestMethod]
        public void TeamProfilesController_Details_Test1()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Details(null);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (HttpStatusCodeResult)result;
            Assert.AreEqual(400, model.StatusCode);
        }


        /// <summary>
        /// Case of deleted record
        /// </summary>
        [TestMethod]
        public void TeamProfilesController_Details_Test2()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Details(21);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (profile)((ViewResult)result).Model;
            Assert.IsNotNull(model);
            //var model = (HttpStatusCodeResult)result;
            //Assert.AreEqual(400, model.StatusCode);
        }


        /// <summary>
        /// Case of wrong id
        /// </summary>
        [TestMethod]
        public void TeamProfilesController_Details_Test3()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Details(999);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (HttpStatusCodeResult)result;
            Assert.AreEqual(404, model.StatusCode);
        }

        
        /// <summary>
        /// Case of normal record
        /// </summary>
        [TestMethod]
        public void TeamProfilesController_Details_Test4()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Details(1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            //var model = (HttpStatusCodeResult)result;
            var model = (profile)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

    }
}
