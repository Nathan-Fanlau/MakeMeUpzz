﻿using MakeUpzz.Factories;
using MakeUpzz.Models;
using MakeUpzz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeUpzz.Handler
{
    public class UserHandler
    {
        public static bool IsUsernameUnique(string username)
        {
            return UserRepository.IsUsernameUnique(username);
        }

        public static bool IsLoginValid(string username, string password)
        {
            return UserRepository.IsLoginValid(username, password);
        }

        public static User GetUserByNameAndPassword(string username, string password)
        {
            return UserRepository.GetUserByNameAndPassword(username, password);
        }

        public static User getUserByName(string username)
        {
            return UserRepository.getUserByName(username);
        }

        public static List<User> getCustomerList()
        {
            return UserRepository.getCustomerList();
        }

        public static void insertUser(string username, string email, DateTime dob, string gender, string password)
        {
            string role = "Customer";
            UserRepository.insertUser(username, email, dob, gender, role, password);
        }
    }
}