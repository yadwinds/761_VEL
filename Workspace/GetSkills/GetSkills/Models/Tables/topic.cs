namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.topics")]
    public partial class topic
    {
        [Key]
        public int topic_id { get; set; }

        [Column("topic")]
        [Required]
        [StringLength(150)]
        public string topic1 { get; set; }

        public int status { get; set; }
    }
}
