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
    }
}