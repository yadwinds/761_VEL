namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.mapping_subjects")]
    public partial class mapping_subjects
    {
        public int id { get; set; }

        public int mapping_id { get; set; }

        public int subject_id { get; set; }

        public int isChecked { get; set; }
    }
}
