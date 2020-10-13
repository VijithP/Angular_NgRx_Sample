using System;
using System.Collections.Generic;
using angular_ngrx_example_api.Data;
namespace angular_ngrx_example_api.Services
{
   public interface ICarService
    {
        List<Car> GetAllCar();

        Car GetAllCarByID(int id);

        string SaveCar(Car car);

        string DeleteCar(int id);


    }
}