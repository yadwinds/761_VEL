namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.order_subjects")]
    public partial class order_subjects
    {
        [Key]
        public int order_subjectid { get; set; }

        public int order_id { get; set; }

        public int subject_id { get; set; }

        public int status { get; set; }
    }
}
