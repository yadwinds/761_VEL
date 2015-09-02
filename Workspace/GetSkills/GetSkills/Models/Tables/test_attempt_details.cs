namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.test_attempt_details")]
    public partial class test_attempt_details
    {
        [Key]
        public int attemptdetailsid { get; set; }

        public int attemptid { get; set; }

        public int questionid { get; set; }

        public int answerid { get; set; }

        public int status { get; set; }
    }
}
