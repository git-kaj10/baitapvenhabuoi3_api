using NguyenDuyThang_5951071100.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenDuyThang_5951071100.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentList = new List<StudentInfo>();

            for (int i = 0; i < 10; i++)
            {
                var studentInfo = new StudentInfo
                {
                    Name = $"Nguyễn Duy Thắng {i}",
                    Age = 21,
                    Gender = 1,
                };
                studentList.Add(studentInfo);
            }

            return studentList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Name = $"Nguyễn Duy Thắng {id}",
                Age = 21,
                Gender = 1,
            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
