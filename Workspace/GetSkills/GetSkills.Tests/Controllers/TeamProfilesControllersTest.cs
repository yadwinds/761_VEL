using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSkills.Controllers;
using GetSkills.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Threading.Tasks;

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
            Assert.AreEqual(5, modelList.Count);
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

        /// <summary>
        /// Case of picture
        /// </summary>
        [TestMethod()]
        public void TeamProfilesController_Create_Test1()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Create();
            Assert.IsNotNull(result);

            // To test if its contents
            var model = (ProfileIndexViewModel)((ViewResult)result).Model;
            Assert.AreEqual("~/Images/no_image.jpg", model.teamProfile.pic);
        }


        /// <summary>
        /// Case of empty items
        /// </summary>
        [TestMethod()]
        public void TeamProfilesController_Create_Test2()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = ctl.Create();
            Assert.IsNotNull(result);

            // To test if its contents
            var model = (ProfileIndexViewModel)((ViewResult)result).Model;
            Assert.AreEqual(0, model.teamProfile.profile_id);
            Assert.IsNull(model.teamProfile.name);
            Assert.IsNull(model.teamProfile.detail);
            Assert.AreEqual(0, model.teamProfile.status);
        }


        /// <summary>
        /// Case of wrong paramater
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Edit_Test1()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Edit(-1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
            var model = (HttpNotFoundResult)result;
            Assert.AreEqual(404, model.StatusCode);
        }


        /// <summary>
        /// Case of deleted record
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Edit_Test2()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Edit(21);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
            var model = (HttpNotFoundResult)result;
            Assert.AreEqual(404, model.StatusCode);
        }


        /// <summary>
        /// Case of normal record
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Edit_Test3()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Edit(1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (ProfileIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }


        /// <summary>
        /// Case of normal update
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Edit_Test4()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Edit(1);
            var model = (ProfileIndexViewModel)((ViewResult)result).Model;
            model.teamProfile.name = "Anne";

            var result2 = ctl.Edit(model);
            Assert.IsNotNull(result);
        }


        /// <summary>
        /// Case of wrong paramater
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Delete_Test1()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Delete(-1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
            var model = (HttpNotFoundResult)result;
            Assert.AreEqual(404, model.StatusCode);
        }



        /// <summary>
        /// Case of deleted record
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Delete_Test2()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Delete(21);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
            var model = (HttpNotFoundResult)result;
            Assert.AreEqual(404, model.StatusCode);
        }


        /// <summary>
        /// Case of normal record
        /// </summary>
        [TestMethod]
        public async Task TeamProfilesController_Delete_Test3()
        {
            // Initialization
            TeamProfilesController ctl = new TeamProfilesController();

            // To test if it is null
            var result = await ctl.Delete(1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (ProfileIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

    }
}
