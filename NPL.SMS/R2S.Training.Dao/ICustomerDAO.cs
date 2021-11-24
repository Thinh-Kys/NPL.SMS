using System;
using System.Collections.Generic;
using System.Text;

namespace NPL.SMS.R2S.Training.Entities.R2S.Training.Dao
{
    interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();         
        List<Order> GetAllOrdersByCustomerID(int customerId);
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}
