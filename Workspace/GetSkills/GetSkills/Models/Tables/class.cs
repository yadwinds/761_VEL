namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.classes")]
    public partial class _class
    {
        [Key]
        public int class_id { get; set; }

        [Required]
        [StringLength(20)]
        public string class_session_code { get; set; }

        [Required]
        [StringLength(100)]
        public string class_title { get; set; }

        public int manager_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Required]
        [StringLength(14)]
        public string time { get; set; }

        public int total_users { get; set; }

        public int duration { get; set; }

        public int? teacher_id { get; set; }

        [Required]
        [StringLength(80)]
        public string teacher_name { get; set; }

        [Required]
        [StringLength(255)]
        public string presenter_url { get; set; }

        [Required]
        [StringLength(255)]
        public string recording_url { get; set; }

        public int session_status { get; set; }

        [StringLength(255)]
        public string common_attendee_url { get; set; }

        [StringLength(255)]
        public string review_session_url { get; set; }

        [Required]
        [StringLength(300)]
        public string startingtimestamp { get; set; }

        [Required]
        [StringLength(300)]
        public string endingtimestamp { get; set; }
    }
}
