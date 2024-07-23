using ConsoleApp4.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp4.Data;

internal class WorkerContext : DbContext
{
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<WorkerJournal> WorkerJournals { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4BOPE1O\SQLEXSPRESS;Initial Catalog=MyWorkerService;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}