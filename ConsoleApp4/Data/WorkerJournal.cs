namespace ConsoleApp4.Data;

public class WorkerJournal
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime DateCameWork { get; set; }
    public DateTime? EscCameWork { get; set; }
}
