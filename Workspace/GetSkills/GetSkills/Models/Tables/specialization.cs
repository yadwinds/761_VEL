namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.specializations")]
    public partial class specialization
    {
        public int id { get; set; }

        [Column("specialization")]
        [Required]
        [StringLength(50)]
        public string specialization1 { get; set; }

        public int status { get; set; }
    }
}
