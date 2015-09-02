namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.email_group_contacts")]
    public partial class email_group_contacts
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string groupname { get; set; }

        [Required]
        [StringLength(200)]
        public string addemail { get; set; }

        [Required]
        [StringLength(200)]
        public string username { get; set; }
    }
}
