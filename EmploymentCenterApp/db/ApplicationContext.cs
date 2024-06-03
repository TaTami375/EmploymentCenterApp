using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmploymentCenterApp.Models;

namespace EmploymentCenterApp.db
{
    public  class ApplicationContext: DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }


        public DbSet<Work> Works { get; set; }


        public DbSet<Employment> Employments { get; set; }

        // <summary>
        /// Конфигурация контекста базы данных.
        /// </summary>
        /// <param name="optionsBuilder">Построитель опций контекста.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EmploymentCenterApp6.db");
        }

        /// <summary>
        /// Настройка отношений между сущностями в базе данных.
        /// </summary>
        /// <param name="modelBuilder">Построитель модели базы данных.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employment>()
                .HasKey(br => br.Id);

            modelBuilder.Entity<Employment>()
                .HasOne(br => br.Applicant)
                .WithMany(c => c.Employments)
                .HasForeignKey(br => br.ApplicantId);

            modelBuilder.Entity<Employment>()
                .HasOne(br => br.Work)
                .WithOne(b => b.Employment)
                .HasForeignKey<Employment>(br => br.WorkId);
        }
    }
}
