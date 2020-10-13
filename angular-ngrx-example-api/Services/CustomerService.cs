using System;
using System.Collections.Generic;
using angular_ngrx_example_api.Data;
using System.Linq;

namespace angular_ngrx_example_api.Services
{
    public class CustomerService : ICustomerService
    {
        string ICustomerService.DeleteCustomer(int customer)
        {
            var customerData=Data.Data.customer.FirstOrDefault(cust=>cust.CustomerID==customer);
            Data.Data.customer.Remove(customerData);
            return "success";
        }

        List<Customer> ICustomerService.GetAllCustomer()
        {
            return Data.Data.customer;
        }

        Customer ICustomerService.GetAllCustomerByID(int CustomerID)
        {
           return Data.Data.customer.FirstOrDefault(cust=>cust.CustomerID==CustomerID);
        }

        string ICustomerService.SaveCustomer(Customer customer)
        {
            try
            {

                if(customer.CustomerID == null & customer.Name!=null)
                {

                    int custID=Data.Data.customer.Count+101;
                    customer.CustomerID=custID;
                    Data.Data.customer.Add(customer);
                }

                if(customer.CustomerID != null)
                {
                    var oldCustomer= Data.Data.customer.FirstOrDefault(cust=>cust.CustomerID==customer.CustomerID);
                     oldCustomer.Name=customer.Name;
                     oldCustomer.Address=customer.Address;
                     oldCustomer.DOB=customer.DOB;
                     oldCustomer.Gender=customer.Gender;

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