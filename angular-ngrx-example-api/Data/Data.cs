using System;
using System.Collections.Generic;

namespace angular_ngrx_example_api.Data
{

    public class Data
    {

        public static List<Customer> customer =>AllCustomer;

        static List<Customer> AllCustomer=new List<Customer>(){
            new Customer()
            {
                CustomerID=101,Name="John",Address="Address1", Gender="Male",DOB=new DateTime (1990,08,01),BloodGroup="b"
            }
            ,new Customer()
            {
                CustomerID=102,Name="Mathew",Address="Address2", Gender="Female",DOB=new DateTime (1990,08,10),BloodGroup="b"
            }

        };



        public static List<Car> car =>AllCar;

        static List<Car> AllCar=new List<Car>(){
            new Car()
            {
                id=1,make="make 1", model="model 1",year=2020,color="color 1",price=100
            }
            ,new Car()
            {
                id=2,make="make 2", model="model 2",year=2020,color="color 2",price=200

            }

        };

    }
}