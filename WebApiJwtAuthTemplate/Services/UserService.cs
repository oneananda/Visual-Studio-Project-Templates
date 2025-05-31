using System.Collections.Generic;
using System;
using WebApiJwtTemplate.Models;
using WebApiJwtTemplate.Services.Interfaces;

namespace WebApiJwtTemplate.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = new();
    private int _nextId = 1;

    public User? ValidateUser(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }

    public User Register(string username, string password)
    {
        if (_users.Any(u => u.Username == username))
            throw new ApplicationException("User already exists.");

        var user = new User
        {
            Id = _nextId++,
            Username = username,
            Password = password
        };
        _users.Add(user);
        return user;
    }
}
