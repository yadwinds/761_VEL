namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.student_orders")]
    public partial class student_orders
    {
        [Key]
        public int order_id { get; set; }

        public int user_id { get; set; }

        public int amount { get; set; }

        public int totalhours { get; set; }

        public DateTime datetime { get; set; }

        public int grade_id { get; set; }

        public int board_id { get; set; }

        public int txnid { get; set; }

        public int payment_status { get; set; }

        public int payment_type { get; set; }

        public int status { get; set; }
    }
}
