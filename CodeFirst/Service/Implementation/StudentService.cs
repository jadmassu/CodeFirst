using CodeFirst.Context;
using CodeFirst.Models;
using CodeFirst.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Service.Implementation
{


    public class StudentService<T>:IStudentService<T> where T: BaseEntity
    {

        public readonly SchoolDbContext context;
        public readonly DbSet<T> dbSet;
        public StudentService(SchoolDbContext context)
        {
            //context = new SchoolDbContext();
          this.context =  context?? throw new ArgumentNullException(nameof(context));
           dbSet = context.Set<T>();

        }
        public async Task<IEnumerable<Student>> GetAll() {

            
            try { return await context.Students.ToListAsync(); }
            catch(Exception e) { return null; }

        }

        public async Task<IStudentService<Student>> AddStudent(IStudentService<Student> student) {

            try {
                await context.AddAsync(student);
                await context.SaveChangesAsync();

                return student;
            }
            catch (Exception e) { return null;  }
        }


        public async Task<Student> GetStudentById(int id)
        {
            Console.WriteLine(id);

            try { var x=  await context.Students.FirstOrDefaultAsync(s => s.ID == id);
                return x;
            }
            catch (Exception e) { return null; }
        }

    }
}
