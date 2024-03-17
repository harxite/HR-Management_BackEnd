﻿using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands
{
    public class CreateAdvanceCommand
    {
        public CreateAdvanceCommand()
        {
            RequestDate = DateTime.Now;
            
        }
        public string AdvanceType { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime RequestDate { get; }
        public int EmployeeId { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        
    }
}
