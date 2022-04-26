﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;
        public static UserRepository Instance;
        public UserRepository()
        {
            if (Instance == null)
            {
                Instance = this;
                _users = new List<User>();

                _users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "He",
                    LastName = "Man",
                    EmailAddress = "he-man@hotmail.com"
                });

                _users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Michael",
                    LastName = "Jackson",
                    EmailAddress = "michaeljackson@yahoo.com"
                });
            }
        }

        public Task<User> AddUser(User user)
        {
            Instance._users.Add(new User
            {
                Id = Guid.NewGuid(),
                FirstName= user.FirstName,
                LastName= user.LastName,
                EmailAddress = user.EmailAddress
            });
            return Task.FromResult(user);
        }

        public Task<List<User>> GetAllUsers()
        {
            return Task.FromResult(Instance._users);
        }
    }
}