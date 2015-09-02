namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.users")]
    public partial class user
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [Required]
        [StringLength(50)]
        public string user_pswd { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string email_address { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string user_type { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string status { get; set; }

        public int student_status { get; set; }

        public int isAuthenticated { get; set; }

        public int approved { get; set; }

        [Column(TypeName = "date")]
        public DateTime created_on { get; set; }

        [Column(TypeName = "date")]
        public DateTime updated_on { get; set; }

        [Column(TypeName = "date")]
        public DateTime lastLoginAt { get; set; }

        [StringLength(100)]
        public string fb_id { get; set; }

        public int signup_source { get; set; }
    }
}
