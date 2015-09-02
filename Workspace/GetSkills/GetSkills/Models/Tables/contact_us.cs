namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.contact_us")]
    public partial class contact_us
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string email_address { get; set; }

        [Required]
        [StringLength(100)]
        public string fname { get; set; }

        [Required]
        [StringLength(100)]
        public string lname { get; set; }

        [Required]
        [StringLength(1500)]
        public string message { get; set; }

        public int status { get; set; }
    }
}
