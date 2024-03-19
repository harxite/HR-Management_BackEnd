﻿using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Context
{
    public class HRProjectContext : IdentityDbContext<ApplicationUser>
    {

        


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Advance> Advances { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:hrprojectsahzod.database.windows.net,1433;Initial Catalog=HRProjectDB7;Persist Security Info=False;User ID=sahzod;Password=Anyela123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Configurations
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityuserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new AdvanceConfiguration());
            
            #endregion

            base.OnModelCreating(modelBuilder);
        }
 
    }
}
