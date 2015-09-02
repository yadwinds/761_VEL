namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.grade")]
    public partial class grade
    {
        [Key]
        public int grade_id { get; set; }

        [Required]
        [StringLength(50)]
        public string grade_name { get; set; }

        public int status { get; set; }
    }
}
