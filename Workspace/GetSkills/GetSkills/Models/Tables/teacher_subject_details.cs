namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.teacher_subject_details")]
    public partial class teacher_subject_details
    {
        [Key]
        public int quali_id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(80)]
        public string subjects { get; set; }

        public float attendence { get; set; }
    }
}
