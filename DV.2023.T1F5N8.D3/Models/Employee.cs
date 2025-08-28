using System;

namespace DV._2023.T1F5N8.ITEHA.D3.Models
{
    public class Employee
    {
        public int Id { get; set; }               // Unique identifier
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Department { get; set; } = "";
        public DateTime HireDate { get; set; }
    }
}
