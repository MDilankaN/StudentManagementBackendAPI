using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentService
    {

        public List<Student> Get();
        public Student Get(String id);
        public Student Create(Student student);
        public void Update(String id, Student student);
        public void Remove(string id);
    }
}
