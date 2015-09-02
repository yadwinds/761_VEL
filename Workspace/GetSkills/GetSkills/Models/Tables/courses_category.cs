namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.courses_category")]
    public partial class courses_category
    {
        [Key]
        public int course_category_id { get; set; }

        public int course_id { get; set; }

        public int category_id { get; set; }

        public int status { get; set; }
    }
}
