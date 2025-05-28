namespace WebApiJwtTemplate.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!; // Remember to hash in production
}