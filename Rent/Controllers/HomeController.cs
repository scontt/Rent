using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Rent.Models;

namespace Rent.Controllers
{
    public class HomeController : Controller
    {
        private const string connectionString = "Server=localhost;Port=5432;Database=rent_car_db;User Id=postgres;Password=123;";
        public IActionResult Index()
        {
            var query = "SELECT " +
                "car_id Id, release_year Released, mileage Mileage, image Image," +
                "brand_id Id, cb.name Name, " +
                "model_id Id, cm.name Name," +
                "class_id Id, cc.name Name, tarif_cost Cost " +
                "FROM car " +
                "LEFT JOIN car_brand cb ON car.car_brand_id = cb.brand_id " +
                "LEFT JOIN car_model cm ON car.car_model_id = cm.model_id " +
                "INNER JOIN car_class cc ON car.car_class_id = cc.class_id";
            using var con = new NpgsqlConnection(connectionString);
            con.Open();
            var cars = con.Query<Car, CarBrand, CarModel, CarClass, Car >(query, 
                (car, brand, model, carClass) =>
            {
                car.Brand = brand;
                car.Model = model;
                car.Class = carClass;
                return car;
            });
            return View(cars);
        }
    }
}
