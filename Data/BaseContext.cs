using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiPrimeraAplicacionWebASP.Models;

    public class BaseContext : IdentityDbContext
    {
        public BaseContext (DbContextOptions<BaseContext> options)
            : base(options)
        {
        }

        public DbSet<MiPrimeraAplicacionWebASP.Models.Vehiculo> Vehiculo { get; set; }

        public DbSet<MiPrimeraAplicacionWebASP.Models.Contactos> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }
    }


// dotnet aspnet-codegenerator identity -dc BaseContext --files "Account.Register;Account.Login;Account.Logout;Account.Manage.PersonalData;Account.Manage.ChangePassword;"