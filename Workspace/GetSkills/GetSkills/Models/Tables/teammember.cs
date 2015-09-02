namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.teammembers")]
    public partial class teammember
    {
        [Key]
        public int teammember_id { get; set; }

        [Required]
        [StringLength(50)]
        public string fname { get; set; }

        [Required]
        [StringLength(50)]
        public string lname { get; set; }

        [Required]
        [StringLength(100)]
        public string designation { get; set; }

        [Required]
        [StringLength(100)]
        public string company { get; set; }

        [Required]
        [StringLength(500)]
        public string brief { get; set; }

        [Required]
        [StringLength(500)]
        public string linkedinprofile { get; set; }

        [Required]
        [StringLength(50)]
        public string mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        public int status { get; set; }
    }
}
