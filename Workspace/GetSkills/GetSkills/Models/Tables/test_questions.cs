namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.test_questions")]
    public partial class test_questions
    {
        [Key]
        public int questionid { get; set; }

        public int testid { get; set; }

        [Required]
        [StringLength(500)]
        public string question { get; set; }

        public int status { get; set; }
    }
}
