namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.uploadtest")]
    public partial class uploadtest
    {
        public int id { get; set; }

        [Required]
        [StringLength(600)]
        public string testno { get; set; }

        [Required]
        [StringLength(1600)]
        public string ques { get; set; }

        [Required]
        [StringLength(1600)]
        public string option1 { get; set; }

        [Required]
        [StringLength(1600)]
        public string option2 { get; set; }

        [Required]
        [StringLength(1600)]
        public string option3 { get; set; }

        [Required]
        [StringLength(1600)]
        public string option4 { get; set; }

        [Required]
        [StringLength(1600)]
        public string answer { get; set; }
    }
}
