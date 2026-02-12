namespace SQLTestDB.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Dept { get; set; }
        public decimal Salary {  get; set; }

    }
}