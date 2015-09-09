using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetSkills.Models
{
    public class CategoryCheckBoxModel : category
    {
        public int story_category_id { get; set; }
        public bool isSelected { get; set; }
    }
}