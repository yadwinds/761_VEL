using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetSkills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetSkills.Controllers;
using System.Web.Mvc;

namespace GetSkills.Models.Tests
{
    [TestClass()]
    public class SuccessStoryControllerTests
    {
        [TestMethod()]
        public async Task SuccessStoryController_Index_Test01()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Index("ID_asc");
            Assert.IsNotNull(result);

            // To test the number of the elements in the list
            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test02()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Index("ID_desc");
            Assert.IsNotNull(result);

            // To test the number of the elements in the list
            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test03()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Index("Order_desc");
            Assert.IsNotNull(result);

            // To test the number of the elements in the list
            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test04()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Index("Order_asc");
            Assert.IsNotNull(result);

            // To test the number of the elements in the list
            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_List_Test()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.List();
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test01()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);

        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test02()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(21);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test03()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(31);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test04()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(41);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test05()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(51);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test06()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(61);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test07()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(71);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test08()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(0);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test09()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(-11);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test10()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Detail(101);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public void SuccessStoryController_Create_Test01()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = ctl.Create();
            Assert.IsNotNull(result);

            // To test if its contents
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.AreEqual("~/Images/no_image.jpg", model.successStory.pic);
        }

        [TestMethod()]
        public void SuccessStoryController_Create_Test02()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();
            StoryIndexViewModel editView = new StoryIndexViewModel();

            // To test if it is null
            var result = ctl.Create(editView);
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test01()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(1);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test02()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(21);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test03()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(31);
            Assert.IsNotNull(result);

            // To test if it is a valid id
            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test04()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(41);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when status == 0
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test05()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(51);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when status == 0
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test06()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(61);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when status == 0
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test07()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(71);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when status == 0
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test08()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(0);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test09()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(-11);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Edit_Test10()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();

            // To test if it is null
            var result = await ctl.Edit(101);
            Assert.IsNotNull(result);

            // To test if it is a HttpNotFoundResult when the id is invalid
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public void SuccessStoryController_Edit_Test11()
        {
            // Initialization
            SuccessStoryController ctl = new SuccessStoryController();
            StoryIndexViewModel editView = new StoryIndexViewModel();

            // To test if it is null
            var result = ctl.Edit(editView);
            Assert.IsNotNull(result);
        }

    }
}