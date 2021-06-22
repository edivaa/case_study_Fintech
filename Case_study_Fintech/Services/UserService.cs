using Case_study_Fintech.Models;
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
        
                return ApiAuthentication(user.Name, user.Password);

        }



        private User ApiAuthentication(string email, string password)
        {
            List<User> loginList = new List<User> {
               new User { Name = "paulo", Email = "paulo@gmail.com", Password = "25636" }
           };

            var user = loginList.FirstOrDefault(user => user.Email.Equals(email) && user.Password.Equals(password));

            if (user == null) throw new Exception("Usuário não existe");

            return user ;
        }
    }
}
