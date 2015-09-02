namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.payment_log")]
    public partial class payment_log
    {
        [Key]
        public int payment_id { get; set; }

        public int course_id { get; set; }

        public int user_id { get; set; }

        public float amount { get; set; }

        [Required]
        [StringLength(50)]
        public string txn_id { get; set; }

        public int payment_status { get; set; }

        public DateTime datetime { get; set; }
    }
}
