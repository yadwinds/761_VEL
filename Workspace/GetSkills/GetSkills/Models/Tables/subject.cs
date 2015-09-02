namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.subject")]
    public partial class subject
    {
        [Key]
        public int subject_id { get; set; }

        [Required]
        [StringLength(50)]
        public string subject_name { get; set; }

        public int status { get; set; }
    }
}
