namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.user_emails")]
    public partial class user_emails
    {
        public int id { get; set; }

        public int emailid { get; set; }

        [Required]
        [StringLength(250)]
        public string subject { get; set; }

        [Required]
        [StringLength(1500)]
        public string message { get; set; }

        public int to_userid { get; set; }

        public int email_read { get; set; }

        public int status { get; set; }

        public DateTime datetime { get; set; }
    }
}
