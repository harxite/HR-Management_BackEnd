﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Permission
    {
        public Permission()
        {
            IsApproved = false;
        }

        public int Id { get; set; }
        private string permissionType;

        public string PermissionType
        {
            get { return permissionType; }
            set 
            {
                if (value == "Baba İzni" || value == "Anne İzni" || value == "Cenaze İzni" || value == "Yıllık İzin" || value == "Evlilik İzni")
                {
                    permissionType = value;
                }
                else
                {
                    throw new Exception($"Invalid permission type.");
                }

            }
        }

        public DateTime RequestDate { get; } = DateTime.Now;
        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set 
            {
                if (value < DateTime.Now.Date)
                {
                    throw new Exception($"Girilen tarih bugünden küçük olamaz.");
                }
                else
                {
                    startDate = value;
                }
                
            }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set 
            {
                if ((value.Date - StartDate.Date).TotalDays > NumberOfDays)
                {
                    
                    throw new Exception("End date exceeds the number of days.");
                }
                else
                {
                    endDate = value;
                }

            }
        }



        public int? NumberOfDays { get; set; }

        public string? FileName { get; set; }
        public string ApprovalStatus { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public bool IsApproved { get; set; }
    }
}
