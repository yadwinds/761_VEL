﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetSkills.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GetSkillsEntities : DbContext
    {
        public GetSkillsEntities()
            : base("name=GetSkillsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<board> boards { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<@class> classes { get; set; }
        public virtual DbSet<client_details> client_details { get; set; }
        public virtual DbSet<contact_us> contact_us { get; set; }
        public virtual DbSet<content> contents { get; set; }
        public virtual DbSet<course_price> course_price { get; set; }
        public virtual DbSet<cours> courses { get; set; }
        public virtual DbSet<courses_category> courses_category { get; set; }
        public virtual DbSet<courses_sort_order> courses_sort_order { get; set; }
        public virtual DbSet<demo_requests> demo_requests { get; set; }
        public virtual DbSet<email_group_contacts> email_group_contacts { get; set; }
        public virtual DbSet<email> emails { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<interview_schedules> interview_schedules { get; set; }
        public virtual DbSet<interview> interviews { get; set; }
        public virtual DbSet<manager_details> manager_details { get; set; }
        public virtual DbSet<mapping> mappings { get; set; }
        public virtual DbSet<mapping_subjects> mapping_subjects { get; set; }
        public virtual DbSet<newemailgroup> newemailgroups { get; set; }
        public virtual DbSet<order_days> order_days { get; set; }
        public virtual DbSet<order_subjects> order_subjects { get; set; }
        public virtual DbSet<payment_log> payment_log { get; set; }
        public virtual DbSet<permission> permissions { get; set; }
        public virtual DbSet<question_answers> question_answers { get; set; }
        public virtual DbSet<specialization> specializations { get; set; }
        public virtual DbSet<student_courses> student_courses { get; set; }
        public virtual DbSet<student_details> student_details { get; set; }
        public virtual DbSet<student_orders> student_orders { get; set; }
        public virtual DbSet<student_subject_details> student_subject_details { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<success_story> success_story { get; set; }
        public virtual DbSet<success_story_category> success_story_category { get; set; }
        public virtual DbSet<success_story_courses> success_story_courses { get; set; }
        public virtual DbSet<teacher_details> teacher_details { get; set; }
        public virtual DbSet<teacher_subject_details> teacher_subject_details { get; set; }
        public virtual DbSet<teammember> teammembers { get; set; }
        public virtual DbSet<test_attempt_details> test_attempt_details { get; set; }
        public virtual DbSet<test_attempts> test_attempts { get; set; }
        public virtual DbSet<test_questions> test_questions { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<topic> topics { get; set; }
        public virtual DbSet<uploadtest> uploadtests { get; set; }
        public virtual DbSet<user_emails> user_emails { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<video> videos { get; set; }
        public virtual DbSet<class_students> class_students { get; set; }
        public virtual DbSet<interview_students> interview_students { get; set; }
        public virtual DbSet<users_permissions> users_permissions { get; set; }
    }
}
