namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.newemailgroups")]
    public partial class newemailgroup
    {
        [Key]
        public int sno { get; set; }

        [Required]
        [StringLength(100)]
        public string groupname { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string date { get; set; }
    }
}
