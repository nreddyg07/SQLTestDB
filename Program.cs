using System;
using SQLTestDB.Models;
using SQLTestDB.Services;

namespace SQLTestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpServices services = new EmpServices();
            services.AddEmp(new Employee
            {
                Name = "Gagana",
                Email = "gagana@gmail.com",
                Dept = "IT",
                Salary = 15000
            });
            var employee=services.GetEmp();
            foreach(var emp in employee)
            {
                Console.WriteLine($"{emp.EmpID} {emp.Name} {emp.Email} {emp.Dept} {emp.Salary}");
            }
            services.UpdateSalary(1, 75000);
            services.DeleteEmp(4);
        }
    }
}