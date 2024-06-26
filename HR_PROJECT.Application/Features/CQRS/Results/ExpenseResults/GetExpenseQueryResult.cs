﻿using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.ExpenseResults
{
    public class GetExpenseQueryResult
    {
        public int Id { get; set; }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime RequestDate { get; set; }
        public string Response { get; set; }
        public string Currency { get; set; }
        public bool? Permission { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSecondName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeSecondLastName { get; set; }
        public int EmployeeId { get; set; }
        public string? FileName { get; set; }
        public decimal? AmountValue { get; set; }
    }
}
