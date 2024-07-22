using ConsoleApp4.Repositories.Interfaces;
using System;

namespace ConsoleApp4.Controller;

public class Worker<T, U, P>(
    ICustomerRepository<T> customerRepository,
    IOrderRepository<U> orderRepository,
    IUserRepository<P> userRepository) : IWorker<T, U, P>
    where T : class
    where U : class
    where P : class
{

}