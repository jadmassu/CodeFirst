using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Student: BaseEntity
    {
        //public string Id { get; set; }
        public string Name { get; set; }
        public string  Gender { get; set; }
        public int age { get; set; }
       
        public DateTime DateOfBirth { get; set; }

    }
}
