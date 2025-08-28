using DV._2023.T1F5N8.ITEHA.D3.Models; // 👈 Make sure your Employee model is in Models folder
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DV._2023.T1F5N8.ITEHA.D3.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> _employees;
        private int _nextId = 1;

        public EmployeeService()
        {
            // Seed with a few employees (optional, for testing)
            _employees = new List<Employee>
            {
                new Employee { Id = _nextId++, FirstName = "Alice", LastName = "Johnson", Email = "alice@codelink.com", Department = "Development", HireDate = DateTime.Now.AddYears(-2) },
                new Employee { Id = _nextId++, FirstName = "Bob", LastName = "Smith", Email = "bob@codelink.com", Department = "QA", HireDate = DateTime.Now.AddYears(-1) }
            };
        }

        // Get all employees
        public List<Employee> GetAll()
        {
            return _employees;
        }

        // Get employee by Id
        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        // Add a new employee
        public void Add(Employee employee)
        {
            employee.Id = _nextId++;
            _employees.Add(employee);
        }

        // Update an existing employee
        public void Update(Employee employee)
        {
            var existing = GetById(employee.Id);
            if (existing != null)
            {
                existing.FirstName = employee.FirstName;
                existing.LastName = employee.LastName;
                existing.Email = employee.Email;
                existing.Department = employee.Department;
                existing.HireDate = employee.HireDate;
            }
        }

        // Delete an employee
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
