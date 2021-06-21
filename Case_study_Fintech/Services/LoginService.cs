using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    public class LoginService
    {
      

        public User GetAuthentication(User newLogin)
        {
           
            return ApiAuthentication(newLogin.UserName, newLogin.Password);
        }



        private User ApiAuthentication(string userName, string password)
        {
           List<User> loginList = new List<User> { 
               new User { UserName = "paulo", Password = "25636" }
           };


            return loginList.FirstOrDefault(user => user.UserName.Equals(userName) && user.Password.Equals(password));
        }
    }
}
