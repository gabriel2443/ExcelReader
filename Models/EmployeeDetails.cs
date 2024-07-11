namespace ExcelReader.Models;

public class EmployeeDetails
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Departament { get; set; }
    public string Position { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime DateOfHire { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int Salary { get; set; }
}