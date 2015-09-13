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
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Index("ID_asc");
            Assert.IsNotNull(result);

            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test02()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Index("ID_desc");
            Assert.IsNotNull(result);

            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test03()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Index("Order_desc");
            Assert.IsNotNull(result);

            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_Index_Test04()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Index("Order_asc");
            Assert.IsNotNull(result);

            var modelList = (List<StoryIndexViewModel>)((ViewResult)result).Model;
            Assert.AreEqual(6, modelList.Count());
        }

        [TestMethod()]
        public async Task SuccessStoryController_List_Test()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.List();
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test01()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(1);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);

        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test02()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(21);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test03()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(31);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test04()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(41);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test05()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(51);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test06()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(61);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test07()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(71);
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.IsNotNull(model);
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test08()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(0);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test09()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(-11);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public async Task SuccessStoryController_Detail_Test10()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = await ctl.Detail(101);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }

        [TestMethod()]
        public void SuccessStoryController_Create_Test01()
        {
            SuccessStoryController ctl = new SuccessStoryController();

            var result = ctl.Create();
            Assert.IsNotNull(result);

            var model = (StoryIndexViewModel)((ViewResult)result).Model;
            Assert.AreEqual("~/Images/no_image.jpg", model.successStory.pic);
        }

        [TestMethod()]
        public void SuccessStoryController_Create_Test02()
        {
            SuccessStoryController ctl = new SuccessStoryController();
            StoryIndexViewModel editView = new StoryIndexViewModel();

            var result = ctl.Create(editView);
            Assert.IsNotNull(result);
        }
    }
}