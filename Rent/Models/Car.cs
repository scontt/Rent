﻿namespace Rent.Models;

public class Car
{
    public int Id { get; set; }
    public CarBrand Brand { get; set; }
    public CarModel Model { get; set; }
    public CarClass Class { get; set; }
    public int Released { get; set; }
    public int Mileage { get; set; }
    public string Image { get; set; }
}