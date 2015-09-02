namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.test_attempts")]
    public partial class test_attempts
    {
        [Key]
        public int attemptid { get; set; }

        public int userid { get; set; }

        [Required]
        [StringLength(100)]
        public string session_id { get; set; }

        public int testid { get; set; }

        public DateTime datetime { get; set; }

        public int score { get; set; }

        public int status { get; set; }
    }
}
