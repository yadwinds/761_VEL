namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.interview_schedules")]
    public partial class interview_schedules
    {
        public int id { get; set; }

        public int client_id { get; set; }

        public int user_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Required]
        [StringLength(20)]
        public string time { get; set; }

        [Required]
        [StringLength(1500)]
        public string message { get; set; }

        public int isAccepted { get; set; }

        public int mode { get; set; }

        public int class_session_code { get; set; }

        public int status { get; set; }
    }
}
