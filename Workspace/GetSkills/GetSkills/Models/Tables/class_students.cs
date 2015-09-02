namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.class_students")]
    public partial class class_students
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int class_session_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int student_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(80)]
        public string student_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string attendee_id { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string attendee_url { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string email { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string fname { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(200)]
        public string lname { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string stream { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(200)]
        public string pno { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(200)]
        public string date { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(14)]
        public string time { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int duration { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(300)]
        public string startingtimestamp { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(300)]
        public string endingtimestamp { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }
    }
}
