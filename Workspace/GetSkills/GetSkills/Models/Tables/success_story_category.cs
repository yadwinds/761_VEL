namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.success_story_category")]
    public partial class success_story_category
    {
        [Key]
        public int story_category_id { get; set; }

        public int success_story_id { get; set; }

        public int category_id { get; set; }

        public int status { get; set; }
    }
}
