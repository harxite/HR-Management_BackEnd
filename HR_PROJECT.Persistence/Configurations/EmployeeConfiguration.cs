﻿using HR_PROJECT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Wage)
                .HasColumnType("decimal(18,2)");

            #region Seed Data
            builder.HasData(

                new Employee
                {
                    Id = 1,
                    FirstName = "John",
                    FirstSurname = "Doe",
                    DateOfBirth = new DateTime(1995, 06, 21),
                    BirthPlace = "Antalya/Türkiye",
                    Tc = "19586478952",
                    StartDate = new DateTime(2017, 03, 25),
                    IsActive = true,
                    Position = "Director",
                    Department = "Technology and Strategy",
                    Company = "Amazon Inc.",
                    Email = "john.doe@bilgeadam.com",
                    Wage = 95489,
                    ImagePath = "/Images/john_doe.jpg",
                    PhoneNumber = "5417896325",
                    Address = "19 Mayıs Mah. Halit Paşa Cad. Şişli/İstanbul"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Jane",
                    SecondName = "Margaret",
                    FirstSurname = "Doe",
                    SecondSurname = "Thatcher",
                    DateOfBirth = new DateTime(1996, 08, 16),
                    BirthPlace = "London/Great Britain",
                    Tc = "78952612374",
                    StartDate = new DateTime(2020, 07, 28),
                    EndDate = new DateTime(2023, 09, 14),
                    IsActive = false,
                    Position = "Lead Architect",
                    Department = "IT",
                    Company = "Koç Group",
                    Email = "jane.doe@bilgeadam.com",
                    Wage = 63951,
                    ImagePath = "/Images/jane_doe.jpg",
                    PhoneNumber = "5085234563",
                    Address = "Ayvansaray Mah. Şemsi Paşa Sokak Fatih/İstanbul"
                }

                );
            #endregion
        }
    }
}
