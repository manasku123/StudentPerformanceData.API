using AutoMapper;
using StudentPerformance.Business.Contract;
using StudentPerformance.Repository.Contract;
using StudentPerformance.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.Business.Business
{
    public class StudentPerformanceBusiness : IStudentPerformanceBusiness
    {
        public readonly IStudentPerformance _studentPerformance;
        public readonly IMapper _mapper;

        public StudentPerformanceBusiness(IStudentPerformance studentPerformance, IMapper mapper)
        {
            _studentPerformance = studentPerformance;
            _mapper = mapper;
        }
        public async Task<List<StudentModel>> GetStudents()
        {
            var students = await _studentPerformance.GetStudents();
            return _mapper.Map<List<StudentModel>>(students);
        }
        public async Task UpdateStudent(StudentModel student)
        {
            var studentEntity = _mapper.Map<StudentModel>(student);
            await _studentPerformance.UpdateStudent(studentEntity);
        }
        public async Task<StudentModel> GetStudentById(int studentId)
        {
            var student = await _studentPerformance.GetStudentById(studentId);
            return _mapper.Map<StudentModel>(student);
        }
    }
}
