﻿using InitialProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Domain.RepositoryInterfaces
{
    public interface IUserRepository
    {
        public User GetByUsername(string username);
        public User Get(int id);
    }
}
