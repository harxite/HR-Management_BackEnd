﻿using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Repositories
{
    public class AdvanceRepository : Repository<Advance>, IAdvanceRepository
    {
        private readonly HRProjectContext _context;
        public AdvanceRepository(HRProjectContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Advance>> GetAllAdvancesByEmployeeID(int id)
        {
            var advances = await _context.Advances
            .Where(p => p.EmployeeId == id)
            .ToListAsync();

            return advances;
        }
        public async Task<List<Advance>> GetAdvancesWithEmployees()
        {
            var advancesWithEmployees = await _context.Advances.Include(x => x.Employee)
               .ToListAsync();

            return advancesWithEmployees;
        }
    }
}
