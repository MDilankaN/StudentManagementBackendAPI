using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace StudentManagement.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {

        [BsonId]
         public string Id { get; set; } = String.Empty;

        [BsonElement("name")] public string Name { get; set; } = String.Empty;

        [BsonElement("graduated")] public bool IsGraduated { get; set; }

        [BsonElement("courses")] public string[]? Courses { get; set; }

        [BsonElement("gender")] public string Gender { get; set; } = String.Empty;
        [BsonElement("age")] public int Age { get; set; }

    }
}
