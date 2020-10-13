using System;
using System.Collections.Generic;
using angular_ngrx_example_api.Data;
using System.Linq;

namespace angular_ngrx_example_api.Services
{
    public class CarService : ICarService
    {
        string ICarService.DeleteCar(int id)
        {
            var CarData=Data.Data.car.FirstOrDefault(cust=>cust.id==id);
            Data.Data.car.Remove(CarData);
            return "success";
        }

        List<Car> ICarService.GetAllCar()
        {
            return Data.Data.car;
        }

        Car ICarService.GetAllCarByID(int id)
        {
           return Data.Data.car.FirstOrDefault(cust=>cust.id==id);
        }

        string ICarService.SaveCar(Car Car)
        {
            try
            {

                if(Car.make!=null)
                {

                    int custID=Data.Data.car.Count+101;
                    Car.id=custID;
                    Data.Data.car.Add(Car);
                }

                if(Car.id != 0)
                {
                    var oldCar= Data.Data.car.FirstOrDefault(cust=>cust.id==Car.id);
                     oldCar.id=Car.id;
                     oldCar.make=Car.make;
                     oldCar.model=Car.model;
                     oldCar.year=Car.year;

                }

                return "success";

            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
    }
}