namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.student_courses")]
    public partial class student_courses
    {
        [Key]
        public int student_courses_id { get; set; }

        public int student_id { get; set; }

        public int course_id { get; set; }

        public int status { get; set; }
    }
}
