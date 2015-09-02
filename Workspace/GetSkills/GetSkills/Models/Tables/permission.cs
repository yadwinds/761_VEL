namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.permissions")]
    public partial class permission
    {
        [Key]
        public int permission_id { get; set; }

        [Required]
        [StringLength(50)]
        public string module_name { get; set; }

        [Required]
        [StringLength(80)]
        public string file_name { get; set; }

        public int permission_order { get; set; }
    }
}
