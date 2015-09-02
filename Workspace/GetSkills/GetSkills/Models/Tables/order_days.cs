namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("getskills.order_days")]
    public partial class order_days
    {
        public int order_daysid { get; set; }

        public int order_id { get; set; }

        public int day_id { get; set; }

        public TimeSpan from_time { get; set; }

        public TimeSpan to_time { get; set; }

        public int status { get; set; }
    }
}
