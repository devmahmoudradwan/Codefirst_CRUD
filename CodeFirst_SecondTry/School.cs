using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirst_SecondTry
{
    public partial class School : DbContext
    {
        public School()
            : base("name=School")
        {
        }

        public virtual DbSet<GRADE> GRADEs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GRADE>()
                .Property(e => e.G_ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GRADE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GRADE>()
                .Property(e => e.VALUEE)
                .IsUnicode(false);

            modelBuilder.Entity<GRADE>()
                .Property(e => e.SECTION)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.CITY)
                .IsUnicode(false);
        }
    }
}
