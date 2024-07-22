namespace ConsoleApp4.Repositories.Interfaces;

public interface IRepositoryFactory<T, U, P> 
    where T : class
    where U : class
    where P : class
{
    IUserRepository<T> CreateUserRepository();
    ICustomerRepository<U> CreateCustomerRepository();
    IOrderRepository<P> CreateOrderRepository();
}