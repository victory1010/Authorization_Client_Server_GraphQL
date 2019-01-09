using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using aspnetcoregraphql.Models.Entities;

namespace aspnetcoregraphql.Data.Repositories
{
    public class UserRepository
    {
        public List<User> _users;
        public UserRepository()
        {
            _users = new List<User>() {
                new User()  { 
                    Id = 1, 
                    Email = "pesho@test.com", 
                    Username = "pesho", 
                    Password  = "123", 
                    FirstName = "Pesho", 
                    LastName = "Dimitrov",
                    Roles = new Claim[] {new Claim(ClaimTypes.Role, "Manager"), new Claim(ClaimTypes.Role, "User")}
                },
                new User() {
                    Id = 2, 
                    Email = "gosho@test.com", 
                    Username = "gosho", 
                    Password  = "123", 
                    FirstName = "Gosho", 
                    LastName = "Petrov",
                    Roles = new Claim[] {new Claim(ClaimTypes.Role, "User")}
                },
                new User() {
                    Id = 3, 
                    Email = "victoriaradeva@yahoo.co.nz", 
                    Username = "victory", 
                    Password  = "VictoriaRadevaedoTailor", 
                    FirstName = "Victoria",
                    LastName = "Radeva",
                    Roles = new Claim[] {new Claim(ClaimTypes.Role, "Admin")}
                }
            };                
        }
        public User GetUser(string username)
        {
            try
            {
                return _users.First(user => user.Username.Equals(username));
            } catch
            {
                return null;
            } 
        }
        public User GetUser(string username, string password)
        {
            try
            {
                return _users.First(user => user.Username.Equals(username) && user.Password.Equals(password));
            } catch
            {
                return null;
            } 
        }             
    }
}