using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Rent.Models;

namespace Rent.Controllers
{
    public class RentController : Controller
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=rent_car_db;User Id=postgres;Password=123;";
        [Route("/car/{carId:int}")]
        public IActionResult Index(int carId)
        {
            var query = "SELECT " +
                "car_id Id, release_year Released, mileage Mileage, image Image," +
                "brand_id Id, cb.name Name, " +
                "model_id Id, cm.name Name " +
                "FROM car " +
                "LEFT JOIN car_brand cb ON car.car_brand_id = cb.brand_id " +
                "LEFT JOIN car_model cm ON car.car_model_id = cm.model_id " +
                $"WHERE car.car_id = {carId}";
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            var car = con.Query<Car, CarBrand, CarModel, Car>(query,
                (car, brand, model) =>
                {
                    car.Brand = brand;
                    car.Model = model;
                    return car;
                }).FirstOrDefault();
            return View(car);
        }
    }
}
