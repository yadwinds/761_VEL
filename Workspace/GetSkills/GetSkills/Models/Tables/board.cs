namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.board")]
    public partial class board
    {
        [Key]
        public int board_id { get; set; }

        [Required]
        [StringLength(50)]
        public string board_name { get; set; }

        public int status { get; set; }
    }
}
