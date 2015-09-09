using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GetSkills.Models
{
    public class SuccessStoryController : Controller
    {
        private GetSkillsEntities db = new GetSkillsEntities();

        // GET: SuccessStory
        public async Task<ActionResult> Index(string sortOrder)
        {

            List<success_story> outList;

            ViewBag.IDSortParm = sortOrder;
            ViewBag.OrderSortParm = sortOrder;

            if ("ID_asc".Equals(sortOrder))
            {
                outList = db.success_story.OrderBy(e => e.success_story_id).ToList();
            }
            else if ("ID_desc".Equals(sortOrder))
            {
                outList = db.success_story.OrderByDescending(e => e.success_story_id).ToList();
            }
            else if ("Order_desc".Equals(sortOrder))
            {
                outList = db.success_story.OrderByDescending(e => e.sort_number).ToList();
            }
            else if ("Order_asc".Equals(sortOrder))
            {
                outList = db.success_story.OrderBy(e => e.sort_number).ToList();
            }
            else
            {
                ViewBag.OrderSortParm = "Order_asc";
                outList = db.success_story.OrderBy(e => e.sort_number).ToList();
            }

            List<StoryIndexViewModel> storyList = new List<StoryIndexViewModel>();
            foreach (var rec in outList)
            {
                StoryIndexViewModel st = new StoryIndexViewModel();
                st.successStory = rec;

                st.categoryList = (from cat in db.success_story_category
                                   join cam in db.categories on cat.category_id equals cam.category_id
                                   where cat.success_story_id == rec.success_story_id && cat.status == 1
                                   select new StoryCategoryViewModel
                                   {
                                       story_category_id = cat.story_category_id,
                                       success_story_id = cat.success_story_id,
                                       category_id = cat.category_id,
                                       category_name = cam.category_name,
                                       status = cat.status
                                   }).ToList();

                st.coursesList = (from ssc in db.success_story_courses
                                   join cos in db.courses on ssc.course_id equals cos.course_id
                                   where ssc.success_story_id == rec.success_story_id && ssc.status == 1
                                   select new StoryCourseViewModel
                                   {
                                       story_course_id = ssc.story_course_id,
                                       success_story_id = ssc.success_story_id,
                                       course_id = ssc.course_id,
                                       course_name = cos.course_name,
                                       status = ssc.status
                                   }).ToList();

                storyList.Add(st);
            }

            //return View(await db.success_story.ToListAsync());
            return View(storyList.ToList());
        }

        // LIST: SuccessStory
        public async Task<ActionResult> List()
        {
            return View(await db.success_story.ToListAsync());
        }

        // GET: SuccessStory/Details/5
        public async Task<ActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StoryIndexViewModel stViewModel = new StoryIndexViewModel();
            stViewModel.successStory = await db.success_story.FindAsync(id);
            if (stViewModel.successStory == null)
            {
                return HttpNotFound();
            }
            stViewModel.categoryList = (from cat in db.success_story_category
                                        join cam in db.categories on cat.category_id equals cam.category_id
                                        where cat.success_story_id == stViewModel.successStory.success_story_id && cat.status == 1
                                        select new StoryCategoryViewModel
                                        {
                                            story_category_id = cat.story_category_id,
                                            success_story_id = cat.success_story_id,
                                            category_id = cat.category_id,
                                            category_name = cam.category_name,
                                            status = cat.status
                                        }).ToList();

            stViewModel.coursesList = (from ssc in db.success_story_courses
                                       join cos in db.courses on ssc.course_id equals cos.course_id
                                       where ssc.success_story_id == stViewModel.successStory.success_story_id && ssc.status == 1
                                       select new StoryCourseViewModel
                                       {
                                           story_course_id = ssc.story_course_id,
                                           success_story_id = ssc.success_story_id,
                                           course_id = ssc.course_id,
                                           course_name = cos.course_name,
                                           status = ssc.status
                                       }).ToList();
            stViewModel.courses = (from ssc in db.success_story_courses
                                   join cos in db.courses on ssc.course_id equals cos.course_id
                                   where ssc.success_story_id == stViewModel.successStory.success_story_id && ssc.status == 1
                                   select new CourseViewModel
                                   {
                                       course_id = cos.course_id,
                                       course_name = cos.course_name,
                                       course_code = cos.course_code,
                                       subject_id = cos.subject_id,
                                       topic_id = cos.topic_id,
                                       description = cos.description,
                                       price = cos.price,
                                       status = cos.status
                                   }).ToList();
            return View(stViewModel);
        }

        // GET: SuccessStory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuccessStory/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "success_story_id,user_name,pic,sort_number,brief,detail_description,status")] success_story success_story)
        {
            if (ModelState.IsValid)
            {
                db.success_story.Add(success_story);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(success_story);
        }

        // GET: SuccessStory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            success_story success_story = await db.success_story.FindAsync(id);
            if (success_story == null)
            {
                return HttpNotFound();
            }
            return View(success_story);
        }

        // POST: SuccessStory/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "success_story_id,user_name,pic,sort_number,brief,detail_description,status")] success_story success_story)
        {
            if (ModelState.IsValid)
            {
                db.Entry(success_story).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(success_story);
        }

        // GET: SuccessStory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            success_story success_story = await db.success_story.FindAsync(id);
            if (success_story == null)
            {
                return HttpNotFound();
            }
            return View(success_story);
        }

        // POST: SuccessStory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            success_story success_story = await db.success_story.FindAsync(id);
            db.success_story.Remove(success_story);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
