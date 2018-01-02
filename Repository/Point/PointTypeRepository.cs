﻿using StudentManager.Models.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManager.Repository;
using exam.Repository;
using exam.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentManager.Repository.Point
{
    public class PointTypeRepository : Repository<PointType>
    {
        public PointTypeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Conduct> FindByName(string name)
        {
            return await _context.Conducts.Where(c => c.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
