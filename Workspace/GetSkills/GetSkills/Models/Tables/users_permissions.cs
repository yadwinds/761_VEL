namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.users_permissions")]
    public partial class users_permissions
    {
        [Key]
        [Column(Order = 0, TypeName = "char")]
        [StringLength(1)]
        public string user_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int permission_id { get; set; }
    }
}
