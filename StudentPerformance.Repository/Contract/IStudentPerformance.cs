using Microsoft.AspNetCore.Mvc;
using StudentPerformance.Entity.Models;
using StudentPerformance.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.Repository.Contract
{
    public interface IStudentPerformance
    {
        Task<List<StudentPerformance.Entity.Models.StudentMaster>> GetStudents();
        Task<StudentPerformance.Entity.Models.StudentMaster> GetStudentById(int studentId);
        // Task<StudentMaster> GetStudentByIdAsync(int studentId);
        Task<IEnumerable<Marksheet>> GetMarksheetsByStudentIdAsync(int studentId);
        Task AddMarksheetAsync(Marksheet marksheet);

        Task AddStudent(StudentPerformance.Entity.Models.StudentMaster student);
        Task UpdateStudent(StudentPerformance.Entity.Models.StudentMaster student);
        // Task DeleteMarksheetAsync(Marksheet marksheet);
        //  Task<int> GetTotalMarkObtained([FromHeader] StudentModel request);
        Task AddMarks([FromBody] MarksheetModel request);
        //  Task UpdateMark([FromBody] MarksheetModel request, [FromHeader] string task);
        Task UpdateStudent(StudentModel studentEntity);
       // Task GetStudentByIdAsync();
    }
}

