namespace GetSkills.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    public partial class StoryIndexViewModel
    {
        public virtual success_story successStory { get; set; }
        public virtual List<StoryCategoryViewModel> categoryList { get; set; }
        public virtual List<StoryCourseViewModel> coursesList { get; set; }
        public string sortorder { get; set; }
    }

}