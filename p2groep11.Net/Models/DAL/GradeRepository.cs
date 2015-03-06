﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using p2groep11.Net.Models.Domain;

namespace p2groep11.Net.Models.DAL
{
    public class GradeRepository : IGradeRepository
    {
        private ProjectContext context;
        private DbSet<Grade> grades;

        public GradeRepository(ProjectContext context)
        {
            this.context = context;
            grades = context.Grades;
        }

        public IQueryable<Grade> FindAll()
        {
            return grades.OrderBy(g => g.name);
        }

        public Grade FindById(int gradeId)
        {
            return grades.Include(l => l.DeterminateTableProp).FirstOrDefault(g => g.GradeId == gradeId);
        }

        public void Remove(Grade grade)
        {
            grades.Remove(grade);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        
    }
}