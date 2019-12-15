using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreamProject.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DurationInYears { get; set; }
        public Guid EmployeeGuid { get; set; }
        public byte[] Document { get; set; }
    }
}
