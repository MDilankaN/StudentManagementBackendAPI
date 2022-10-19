using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;
using MongoDB.Driver;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService

    {
        private readonly IMongoCollection<Student> _student;
        public StudentService(StudentStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _student = database.GetCollection<Student>(settings.CollectionName);


        }
        public Student Create(Student student)
        {
            _student.InsertOne(student);
            return student;
        }

        public List<Student> Get()
        {
            return _student.Find(student => true).ToList();
        }

        public Student Get(string id)
        {
            return _student.Find(student => student.Id ==id).FirstOrDefault();
        }

        public void Remove(string id)
        {
             _student.DeleteOne(student => student.Id == id);
        }

        public void Update(string id, Student student)
        {
            _student.ReplaceOne(student => student.Id == id, student);
        }
    }
}
