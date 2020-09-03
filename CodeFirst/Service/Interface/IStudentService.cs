using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Service.Interface
{
    public interface IStudentService<T> where T : BaseEntity
    {

        Task<IEnumerable<Student>> GetAll();
        Task<IStudentService<Student>> AddStudent(IStudentService<Student> student);
        Task<Student> GetStudentById(int id);
        
    }
}
