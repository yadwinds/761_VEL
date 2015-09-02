namespace GetSkills.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GetSkillsDataContext : DbContext
    {
        public GetSkillsDataContext()
            : base("name=GetSkillsDataContext")
        {
        }

        public virtual DbSet<board> boards { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<_class> classes { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<board>()
                .Property(e => e.board_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.class_session_code)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.class_title)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.teacher_name)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.presenter_url)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.recording_url)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.common_attendee_url)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.review_session_url)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.startingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.endingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.pno)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<client_details>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<contact_us>()
                .Property(e => e.email_address)
                .IsUnicode(false);

            modelBuilder.Entity<contact_us>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<contact_us>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<contact_us>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<content>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<content>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<content>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.course_name)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.course_code)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<demo_requests>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<email_group_contacts>()
                .Property(e => e.groupname)
                .IsUnicode(false);

            modelBuilder.Entity<email_group_contacts>()
                .Property(e => e.addemail)
                .IsUnicode(false);

            modelBuilder.Entity<email_group_contacts>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<email>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<email>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<grade>()
                .Property(e => e.grade_name)
                .IsUnicode(false);

            modelBuilder.Entity<interview_schedules>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<interview_schedules>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.class_session_code)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.class_title)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.client_name)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.client_url)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.recording_url)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.startingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<interview>()
                .Property(e => e.endingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.county)
                .IsUnicode(false);

            modelBuilder.Entity<manager_details>()
                .Property(e => e.zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<newemailgroup>()
                .Property(e => e.groupname)
                .IsUnicode(false);

            modelBuilder.Entity<newemailgroup>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<newemailgroup>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<payment_log>()
                .Property(e => e.txn_id)
                .IsUnicode(false);

            modelBuilder.Entity<permission>()
                .Property(e => e.module_name)
                .IsUnicode(false);

            modelBuilder.Entity<permission>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<question_answers>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<specialization>()
                .Property(e => e.specialization1)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.stream)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.pno)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.college)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.convenient_time)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.cv)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.total_exp)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.brief)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.pic)
                .IsUnicode(false);

            modelBuilder.Entity<student_details>()
                .Property(e => e.up)
                .IsUnicode(false);

            modelBuilder.Entity<student_subject_details>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<student_subject_details>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.subject_name)
                .IsUnicode(false);

            modelBuilder.Entity<success_story>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<success_story>()
                .Property(e => e.pic)
                .IsUnicode(false);

            modelBuilder.Entity<success_story>()
                .Property(e => e.brief)
                .IsUnicode(false);

            modelBuilder.Entity<success_story>()
                .Property(e => e.detail_description)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.mobileno)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.education)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.grade)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_details>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_subject_details>()
                .Property(e => e.subjects)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.designation)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.brief)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.linkedinprofile)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<teammember>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<test_attempts>()
                .Property(e => e.session_id)
                .IsUnicode(false);

            modelBuilder.Entity<test_questions>()
                .Property(e => e.question)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.testcode)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.testname)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<topic>()
                .Property(e => e.topic1)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.testno)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.ques)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.option1)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.option2)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.option3)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.option4)
                .IsUnicode(false);

            modelBuilder.Entity<uploadtest>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<user_emails>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<user_emails>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_pswd)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email_address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_type)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.fb_id)
                .IsUnicode(false);

            modelBuilder.Entity<video>()
                .Property(e => e.video1)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.attendee_id)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.attendee_url)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.stream)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.pno)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.startingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<class_students>()
                .Property(e => e.endingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.attendee_id)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.attendee_url)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.startingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<interview_students>()
                .Property(e => e.endingtimestamp)
                .IsUnicode(false);

            modelBuilder.Entity<users_permissions>()
                .Property(e => e.user_type)
                .IsUnicode(false);
        }
    }
}
