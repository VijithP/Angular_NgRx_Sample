using System;
using System.Collections.Generic;
using angular_ngrx_example_api.Data;
namespace angular_ngrx_example_api.Services
{
   public interface ICustomerService
    {
        List<Customer> GetAllCustomer();

        Customer GetAllCustomerByID(int CustomerID);

        string SaveCustomer(Customer customer);

        string DeleteCustomer(int customer);


    }
}