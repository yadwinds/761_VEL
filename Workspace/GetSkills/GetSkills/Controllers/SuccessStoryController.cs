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
        public async Task<ActionResult> Index()
        {
            return View(await db.success_story.ToListAsync());
        }

        // LIST: SuccessStory
        public async Task<ActionResult> List()
        {
            return View(await db.success_story.ToListAsync());
        }

        // GET: SuccessStory/Details/5
        public async Task<ActionResult> Details(int? id)
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
