namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.content")]
    public partial class content
    {
        public int contentid { get; set; }

        [Required]
        [StringLength(500)]
        public string filename { get; set; }

        [Required]
        [StringLength(200)]
        public string subject { get; set; }

        [Required]
        [StringLength(1000)]
        public string description { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime upload_date { get; set; }

        public int uploadedby { get; set; }

        public int status { get; set; }
    }
}
