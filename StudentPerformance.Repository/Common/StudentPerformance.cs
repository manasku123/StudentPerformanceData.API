using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPerformance.Entity.Models;
using StudentPerformance.Repository.Contract;
using StudentPerformance.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.Repository.Common
{
    public class StudentPerformance : IStudentPerformance
    {
        private readonly DbContext _context;
        private DbContext _dbContext;

        public StudentPerformance(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddMarks([FromBody] MarksheetModel request)
        {
            throw new NotImplementedException();
        }
        public async Task UpdateStudent(StudentPerformance.Entity.Models.StudentMaster student)
        {
            _dbContext.Entry(student).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public Task AddMarksheetAsync(Marksheet marksheet)
        {
            throw new NotImplementedException();
        }

     /*   public Task DeleteMarksheetAsync(Marksheet marksheet)
        {
            throw new NotImplementedException();
        }*/

        public Task<IEnumerable<Marksheet>> GetMarksheetsByStudentIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<StudentMaster> GetStudentByIdAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudent(StudentModel studentEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentMaster>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<StudentMaster> GetStudentById(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task AddStudent(StudentMaster student)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudent(StudentMaster student)
        {
            throw new NotImplementedException();
        }
        public async Task<List<StudentPerformance.Entity.Models.StudentMaster>> GetStudents()
        {
            return await _dbContext.Set<StudentPerformance.Entity.Models.StudentMaster>().ToListAsync();
        }
        public async Task<StudentPerformance.Entity.Models.StudentMaster> GetStudentById(int Id)
        {
            return await _dbContext.Set<StudentMaster>().FindAsync(Id);
        }
    }
}
