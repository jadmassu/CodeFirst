using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Teacher :BaseEntity
    {
      //  public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }

    }
}
