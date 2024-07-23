using ConsoleApp4;
using ConsoleApp4.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection();
services.AddSingleton<IRepositoryWork, RepositoryWorkConsole>();
services.AddSingleton<Worker>();

using var context = new WorkerContext();
var employee = context.Employees.Where(x => x.Id == 1).First();
using var serviceProvider = services.BuildServiceProvider();
var worker = serviceProvider.GetRequiredService<Worker>();

worker.CameToWork(employee);
Thread.Sleep(3000);
worker.EscFromWork(employee);


