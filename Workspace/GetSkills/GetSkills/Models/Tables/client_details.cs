namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.client_details")]
    public partial class client_details
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(200)]
        public string company_name { get; set; }

        [Required]
        [StringLength(1000)]
        public string description { get; set; }

        [Required]
        [StringLength(50)]
        public string fname { get; set; }

        [Required]
        [StringLength(50)]
        public string lname { get; set; }

        [Required]
        [StringLength(100)]
        public string pno { get; set; }

        [Required]
        [StringLength(500)]
        public string address { get; set; }

        [Required]
        [StringLength(200)]
        public string password { get; set; }
    }
}
