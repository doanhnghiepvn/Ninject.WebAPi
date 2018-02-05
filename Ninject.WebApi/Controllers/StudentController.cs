﻿using Ninject.WebApi.Core.Models;
using Ninject.WebApi.Core.RepositoryInterfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace Ninject.WebApi.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> Get()
        {
            return _studentRepository.GetStudents();
        }


    }
}