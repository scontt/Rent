namespace Rent.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int DriveExperience { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
}