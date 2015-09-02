namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.student_details")]
    public partial class student_details
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(1000)]
        public string email { get; set; }

        [Required]
        [StringLength(1000)]
        public string fname { get; set; }

        [Required]
        [StringLength(1000)]
        public string lname { get; set; }

        [Required]
        [StringLength(1000)]
        public string stream { get; set; }

        [Required]
        [StringLength(20)]
        public string pno { get; set; }

        [Required]
        [StringLength(150)]
        public string address { get; set; }

        [Required]
        [StringLength(30)]
        public string city { get; set; }

        [Required]
        [StringLength(100)]
        public string subjects { get; set; }

        [Required]
        [StringLength(100)]
        public string college { get; set; }

        [Required]
        [StringLength(25)]
        public string convenient_time { get; set; }

        [Required]
        [StringLength(20)]
        public string password { get; set; }

        [Required]
        [StringLength(100)]
        public string cv { get; set; }

        public int specialization { get; set; }

        [Required]
        [StringLength(20)]
        public string total_exp { get; set; }

        [Required]
        [StringLength(500)]
        public string brief { get; set; }

        [Required]
        [StringLength(100)]
        public string pic { get; set; }

        [Required]
        [StringLength(100)]
        public string up { get; set; }
    }
}
