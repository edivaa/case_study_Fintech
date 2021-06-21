﻿using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class UserService
    {


        public User Authentication(User user)
        {
            try
            {
                return ApiAuthentication(user.UserName, user.Password);

            }
            catch (Exception)
            {

                throw new Exception("Usuário não existe");
            }
        }



        private User ApiAuthentication(string userName, string password)
        {
            List<User> loginList = new List<User> {
               new User { UserName = "paulo", Password = "25636" }
           };

            var user = loginList.FirstOrDefault(user => user.UserName.Equals(userName) && user.Password.Equals(password));

            if (user == null) throw new Exception("Usuário não existe");

            return user ;
        }
    }
}
