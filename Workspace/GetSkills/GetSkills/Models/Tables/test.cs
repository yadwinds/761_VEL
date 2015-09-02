namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.tests")]
    public partial class test
    {
        public int testid { get; set; }

        public int currentid { get; set; }

        [StringLength(10)]
        public string testcode { get; set; }

        [Required]
        [StringLength(50)]
        public string testname { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public int subjectid { get; set; }

        public int topicid { get; set; }

        public DateTime datecreated { get; set; }

        public int ispublished { get; set; }

        public int status { get; set; }
    }
}
