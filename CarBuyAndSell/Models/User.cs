﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public string ProfilePicture { get; set; }

        public User(int userId, int role, string firstName, string lastName, string address, string username, string password, string number, string profilePicture)
        {
            UserId = userId;
            RoleId = role;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Username = username;
            Password = password;
            Number = number;
            ProfilePicture = profilePicture;
        }
    }

}
