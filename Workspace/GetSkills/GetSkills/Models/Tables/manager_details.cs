namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.manager_details")]
    public partial class manager_details
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string gender { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [Required]
        [StringLength(30)]
        public string city { get; set; }

        [Required]
        [StringLength(30)]
        public string state { get; set; }

        [Required]
        [StringLength(30)]
        public string county { get; set; }

        [Required]
        [StringLength(10)]
        public string zipcode { get; set; }
    }
}
