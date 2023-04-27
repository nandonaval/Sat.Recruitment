using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sat.Recruitment.DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Data _data;
        public UserRepository(Data data)
        {
            _data = data;
        }

        public bool CreateUser(User user)
        {
            try
            {
                File.AppendAllText(Directory.GetCurrentDirectory() + "/Files/Users.txt", Environment.NewLine + user.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"A problem ocurred while saving user. {ex.InnerException}");
            }
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return _data.ReadDataFromFile();
        }
    }
}
