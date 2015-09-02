namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.success_story")]
    public partial class success_story
    {
        [Key]
        public int success_story_id { get; set; }

        [Required]
        [StringLength(100)]
        public string user_name { get; set; }

        [Required]
        [StringLength(100)]
        public string pic { get; set; }

        public int? sort_number { get; set; }

        [Required]
        [StringLength(200)]
        public string brief { get; set; }

        [Required]
        [StringLength(1000)]
        public string detail_description { get; set; }

        public int status { get; set; }
    }
}
