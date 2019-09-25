using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LHBOL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LHDAL 
{
    public class LHDbContext : IdentityDbContext
    {
        public LHDbContext(DbContextOptions<LHDbContext> options) :base (options)
        {
          // IdentityUser

            //Database.EnsureCreated();
            //Database.Migrate();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL(@"Server=srv123456.mysql.database.azure.com; Port=3306; Database=DBGameBooks; Uid=mgprem@srv123456; Pwd=H@ppySep321$; SslMode=Preferred;");
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                 .Property(r => r.EmailConfirmed)
                 .HasConversion(new BoolToZeroOneConverter<Int16>());

            builder.Entity<User>()
                 .Property(r => r.LockoutEnabled)
                 .HasConversion(new BoolToZeroOneConverter<Int16>());
            builder.Entity<User>()
                 .Property(r => r.TwoFactorEnabled)
                 .HasConversion(new BoolToZeroOneConverter<Int16>());

            builder.Entity<User>()
                 .Property(r => r.PhoneNumberConfirmed)
                 .HasConversion(new BoolToZeroOneConverter<Int16>());

        }
        public DbSet<Gamebooks> Gamebooks { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Episodes> Episodes{get;set;}
        public DbSet<Companies> Companies { get; set; }
    }
}
