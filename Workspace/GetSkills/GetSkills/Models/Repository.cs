namespace GetSkills.Models.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public class Repository<T> where T : class
    {
        private GetSkillsDataContext context = null;

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            this.context = new GetSkillsDataContext();
            DbSet = context.Set<T>();
        } 

        public Repository(GetSkillsDataContext context)
        {
            this.context = context;
        }

        public List<T> GetALL()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
