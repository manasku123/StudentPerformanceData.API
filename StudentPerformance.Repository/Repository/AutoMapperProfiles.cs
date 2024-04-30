using AutoMapper;
using StudentPerformance.Entity.Models;
using StudentPerformance.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.Repository.Repository
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<StudentModel, StudentMaster>();
            CreateMap<MarksheetModel, Marksheet>();
        }
    }
}
