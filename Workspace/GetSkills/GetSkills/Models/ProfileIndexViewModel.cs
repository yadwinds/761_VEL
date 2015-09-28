namespace GetSkills.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public partial class ProfileIndexViewModel
    {
        public virtual profile teamProfile { get; set; }
        public HttpPostedFileBase picFile { get; set; }
    }
}