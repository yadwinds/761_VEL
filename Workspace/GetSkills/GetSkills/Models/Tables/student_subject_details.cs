namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.student_subject_details")]
    public partial class student_subject_details
    {
        [Key]
        public int sub_id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(80)]
        public string subject { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(10)]
        public string code { get; set; }

        public int teacher_assigned { get; set; }

        public float attendence { get; set; }
    }
}
