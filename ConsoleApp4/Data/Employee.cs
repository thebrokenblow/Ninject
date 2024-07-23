namespace ConsoleApp4.Data;

public class Employee
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string SecondName { get; set; }
    public required string Patronymic { get; set; }
    public required string Email { get; set; }
    public ICollection<WorkerJournal>? WorkerJournal { get; set; }
}