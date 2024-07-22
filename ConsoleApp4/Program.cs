using Ninject;
using ConsoleApp4.Modules;
using ConsoleApp4.Model;
using ConsoleApp4.Repositories.Interfaces;
using Ninject.Parameters;

var commonModule = new CommonModule();
var kernel = new StandardKernel(commonModule);
var сustomerRepository = kernel.Get<ICustomerRepository<Customer>>(new ConstructorArgument("connectionParametr", "parametr"));

Console.ReadKey();