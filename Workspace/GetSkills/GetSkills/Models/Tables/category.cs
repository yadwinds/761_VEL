namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.category")]
    public partial class category
    {
        [Key]
        public int category_id { get; set; }

        [StringLength(100)]
        public string category_name { get; set; }

        public int status { get; set; }
    }
}
