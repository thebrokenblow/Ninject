﻿using ConsoleApp4.Repositories.Interfaces;

namespace ConsoleApp4.Repositories;

public class UserRepository<T> : IUserRepository<T> where T : class
{
    public void Create(T item)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public T GetBook(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetList()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Update(T item)
    {
        throw new NotImplementedException();
    }
}
