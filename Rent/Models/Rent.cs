namespace Rent.Models;

public class Rent
{
    public int Id { get; set; }
    public User User { get; set; }
    public Car Car { get; set; }
    public DateTime RentDate { get; set; }
}