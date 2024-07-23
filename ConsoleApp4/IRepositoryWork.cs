using ConsoleApp4.Data;

namespace ConsoleApp4;

public interface IRepositoryWork
{
    void CameToWork(Employee employee);
    void EscFromWork(Employee employee);
}