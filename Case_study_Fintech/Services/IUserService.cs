using Case_study_Fintech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_study_Fintech.Services
{
    interface IUserService
    {
        public User Authentication(User user);
    }
}
