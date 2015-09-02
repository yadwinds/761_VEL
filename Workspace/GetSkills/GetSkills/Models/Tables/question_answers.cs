namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.question_answers")]
    public partial class question_answers
    {
        [Key]
        public int answerid { get; set; }

        public int questionid { get; set; }

        [Required]
        [StringLength(500)]
        public string answer { get; set; }

        public int correct { get; set; }

        public int status { get; set; }
    }
}
