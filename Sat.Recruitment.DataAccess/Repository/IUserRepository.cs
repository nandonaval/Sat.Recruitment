﻿using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.DataAccess.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        bool CreateUser(User user);
    }
}
