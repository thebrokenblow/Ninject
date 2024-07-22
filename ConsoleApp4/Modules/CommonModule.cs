using ConsoleApp4.Controller;
using ConsoleApp4.Model;
using ConsoleApp4.Repositories;
using ConsoleApp4.Repositories.Interfaces;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace ConsoleApp4.Modules;

public class CommonModule : NinjectModule
{
    public override void Load()
    {
        Bind<ICustomerRepository<Customer>>().To<CustomerRepository<Customer>>();
        Bind<IOrderRepository<Order>>().To<OrderRepository<Order>>();
        Bind<IUserRepository<User>>().To<UserRepository<User>>();
        Bind<IWorker<Customer, Order, User>>().To<Worker<Customer, Order, User>>();

        //ToFactory - Определяет, что интерфейс должен быть привязан к автоматически созданной фабрике заместитель.
        Bind<IRepositoryFactory<User, Customer, Order>>().ToFactory();
    }
}