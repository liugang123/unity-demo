using System;

namespace com.example.domain.repository
{
    public class UserRepository : IUserRepository
    {
        public void Add()
        {
            Console.WriteLine("UserRepository Invoke Add() Method ");
        }
    }
}
