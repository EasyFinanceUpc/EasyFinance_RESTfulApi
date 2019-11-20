﻿using EasyFinanceApi.Domain.Models;
using EasyFinanceApi.Domain.Repositories;
using EasyFinanceApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFinanceApi.Persistence.Repositories
{
    public class GoalRepository : BaseRepository, IGoalRepository
    {
        public GoalRepository(AppDbContext context): base(context) { }
        public async Task AddAsync(Goal goal)
        {
            await _context.Registries.AddAsync(goal);
        }

        public async Task<IEnumerable<Goal>> GetGoals(int id)
        {
            return await _context.Goals.Where(x => x.CustomerId == id).ToListAsync();
        }
    }
}