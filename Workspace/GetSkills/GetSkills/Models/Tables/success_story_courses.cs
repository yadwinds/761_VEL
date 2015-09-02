namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.success_story_courses")]
    public partial class success_story_courses
    {
        [Key]
        public int story_course_id { get; set; }

        public int success_story_id { get; set; }

        public int course_id { get; set; }

        public int status { get; set; }
    }
}
