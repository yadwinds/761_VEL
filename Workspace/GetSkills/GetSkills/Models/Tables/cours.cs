namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.courses")]
    public partial class cours
    {
        [Key]
        public int course_id { get; set; }

        [StringLength(50)]
        public string course_name { get; set; }

        [Required]
        [StringLength(60)]
        public string course_code { get; set; }

        public int subject_id { get; set; }

        public int topic_id { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }

        public decimal price { get; set; }

        public int? status { get; set; }
    }
}
