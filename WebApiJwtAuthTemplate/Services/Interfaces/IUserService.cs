using WebApiJwtTemplate.Models;

namespace WebApiJwtTemplate.Services.Interfaces;

public interface IUserService
{
    User? ValidateUser(string username, string password);
    User Register(string username, string password);
}