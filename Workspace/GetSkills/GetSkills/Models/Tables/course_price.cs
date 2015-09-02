namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.course_price")]
    public partial class course_price
    {
        [Key]
        public int price_id { get; set; }

        public int grade_id { get; set; }

        public int price_per_hour { get; set; }

        public int status { get; set; }
    }
}
