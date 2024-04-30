using StudentPerformance.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.Business.Contract
{
    public class IStudentPerformanceBusiness
    {
        Task<List<StudentModel>> GetStudents();
        Task<StudentModel> GetStudentById(int studentId);
        Task UpdateStudent(StudentModel student);
    }
}
