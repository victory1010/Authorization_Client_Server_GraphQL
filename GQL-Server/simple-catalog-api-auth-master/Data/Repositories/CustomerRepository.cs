using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private  List<Customer> _customers;
   
        public CustomerRepository()
        {
            _customers = new List<Customer>{
                new Customer()
                {
                    Id = 1,
                    Name = "Alexander"
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Gosho"
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Pesho"
                }
            };
        }   
        public Task<List<Customer>> CustomersAsync()
        {
            return Task.FromResult(_customers);
        }

        public Task<Customer> GetCustomerAsync(int id)
        {
            return Task.FromResult(_customers.FirstOrDefault(x => x.Id == id));
        }         
    }
}