using ConsoleApp4.Data;

namespace ConsoleApp4;

public class Worker
{
    private readonly IRepositoryWork _repositoryWork;

    public Worker(IRepositoryWork repositoryWork)
    {
        _repositoryWork = repositoryWork;   
    }

    public void CameToWork(Employee employee)
    {
        _repositoryWork.CameToWork(employee);
    }

    public void EscFromWork(Employee employee)
    {
        _repositoryWork.EscFromWork(employee);
    }
}