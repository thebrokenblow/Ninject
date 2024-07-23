using ConsoleApp4.Data;

namespace ConsoleApp4;

public class RepositoryWorkerDB : IRepositoryWork
{
    public void CameToWork(Employee employee)
    {
        using var context = new WorkerContext();
        var workerJournal = new WorkerJournal
        {
            DateCameWork = DateTime.Now,
            EmployeeId = employee.Id
        };

        context.WorkerJournals.Add(workerJournal);
        context.SaveChanges();
    }

    public void EscFromWork(Employee employee)
    {
        using var context = new WorkerContext();

        var workerJournal = context.WorkerJournals.Where(x => x.EmployeeId == employee.Id && x.EscCameWork == null).First();
        workerJournal.EscCameWork = DateTime.Now;
        context.SaveChanges();
    }
}
