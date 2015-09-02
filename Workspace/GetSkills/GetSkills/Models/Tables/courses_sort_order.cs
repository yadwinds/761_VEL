namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.courses_sort_order")]
    public partial class courses_sort_order
    {
        [Key]
        public int course_order_id { get; set; }

        public int course_id { get; set; }

        public int sort_order { get; set; }

        public int status { get; set; }
    }
}
