namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.videos")]
    public partial class video
    {
        public int id { get; set; }

        [Column("video")]
        [Required]
        [StringLength(255)]
        public string video1 { get; set; }

        public bool status { get; set; }

        public long time { get; set; }
    }
}
