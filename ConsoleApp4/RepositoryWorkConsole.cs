using ConsoleApp4.Data;

namespace ConsoleApp4;

public class RepositoryWorkConsole : IRepositoryWork
{
    public void CameToWork(Employee employee)
    {
        var currentDate = DateTime.Now;
        Console.WriteLine($"{employee.SecondName} {employee.FirstName} Пришёл на работу в {currentDate}");
    }

    public void EscFromWork(Employee employee)
    {
        var currentDate = DateTime.Now;
        Console.WriteLine($"{employee.SecondName} {employee.FirstName} Ушёл с работы в {currentDate}");
    }
}