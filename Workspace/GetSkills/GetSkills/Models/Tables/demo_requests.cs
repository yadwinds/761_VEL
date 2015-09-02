namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.demo_requests")]
    public partial class demo_requests
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(25)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        [StringLength(150)]
        public string address { get; set; }

        [Required]
        [StringLength(20)]
        public string subject { get; set; }

        [Required]
        [StringLength(20)]
        public string date { get; set; }

        [Required]
        [StringLength(20)]
        public string time { get; set; }

        public int status { get; set; }
    }
}
