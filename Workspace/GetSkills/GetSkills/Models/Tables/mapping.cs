namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.mapping")]
    public partial class mapping
    {
        [Key]
        public int mapping_id { get; set; }

        public int board_id { get; set; }

        public int grade_id { get; set; }

        public int status { get; set; }
    }
}
