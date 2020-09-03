using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using CodeFirst.Service.Implementation;
using CodeFirst.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : Controller
    {
   
        private IStudentService<Student> service;

        public StudentController(IStudentService<Student> service)
        {

            this.service = service;

        }
        
        [HttpGet("getAll")]
        public async Task<IActionResult> getAllStudentsAsync() {
            try
            {
                var student = await service.GetAll();
                if (student == null) { return NotFound(); }
                return Ok(student);
            }
            catch (Exception e) { return BadRequest();  }
        }



        [HttpPost("create")]
        
        public async Task<IActionResult> CreateStudent([FromBody] IStudentService<Student> student)
        {
            try { 
                var newStudent = await service.AddStudent(student);
                if (newStudent == null) { return NotFound(); }
                return Ok(newStudent);
        }
            catch (Exception e) { return BadRequest(); }
}

        [HttpGet("getById")]
        public async Task<IActionResult> getStudentById(int id)
        {
            try { 
                var student = await service.GetStudentById(id);
                if (student == null) { return NotFound(); }
                return Ok(student);
            }
            catch (Exception e) { return BadRequest(); }
        }
    }
}
