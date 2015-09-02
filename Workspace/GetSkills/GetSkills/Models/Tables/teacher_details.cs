namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.teacher_details")]
    public partial class teacher_details
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(100)]
        public string fname { get; set; }

        [Required]
        [StringLength(20)]
        public string lname { get; set; }

        [Required]
        [StringLength(30)]
        public string mobileno { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        public int age { get; set; }

        [Required]
        [StringLength(100)]
        public string education { get; set; }

        [Required]
        [StringLength(30)]
        public string grade { get; set; }

        [Required]
        [StringLength(30)]
        public string subject { get; set; }

        [Required]
        [StringLength(10000)]
        public string details { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }
    }
}
