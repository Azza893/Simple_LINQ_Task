using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay3LINQ
{
    class Context:DbContext
    {
        public Context():base("name=TestDataBase")
        {

        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<School> schools { get; set; }
        public virtual DbSet<Teacher> Teachers  { get; set; }
        public virtual DbSet<TeacherTrans> TeacherTrans { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherTrans>()
                        .HasRequired(m => m.FromSchool)
                        .WithMany(t => t.fromSchool)
                        .HasForeignKey(m => m.fromschoolID)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeacherTrans>()
                        .HasRequired(m => m.ToSchool)
                        .WithMany(t => t.ToSchool)
                        .HasForeignKey(m => m.ToschoolID)
                        .WillCascadeOnDelete(false);
        }
    }
}
