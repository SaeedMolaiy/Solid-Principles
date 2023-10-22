namespace SolidPrinciples.SingleResponsibility;

// Without SRP
internal class Employee
{
    public void CalculateSalary()
    {
    }

    public void GenerateReport()
    {
    }
}

// With SRP
internal class EmployeeSrp
{
    public void CalculateSalary()
    {
    }
}

internal class ReportGenerator
{
    public void GenerateReport()
    {
    }
}