using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetSkills.Models
{
    public class CourseCheckboxModel : cours
    {
        public int story_course_id { get; set; }
        public bool isSelected { get; set; }
    }
}