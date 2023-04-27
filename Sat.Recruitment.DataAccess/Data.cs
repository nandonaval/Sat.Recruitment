using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sat.Recruitment.DataAccess
{
    public class Data
    {
        public List<User> ReadDataFromFile()
        {
            var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";
            List<User> _users = new List<User>();

            using (var fileStream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                StreamReader reader = new StreamReader(fileStream);

                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLineAsync().Result;
                    var user = new User
                    {
                        Name = line.Split(',')[0].ToString(),
                        Email = line.Split(',')[1].ToString(),
                        Phone = line.Split(',')[2].ToString(),
                        Address = line.Split(',')[3].ToString(),
                        UserType = line.Split(',')[4].ToString(),
                        Money = decimal.Parse(line.Split(',')[5].ToString()),
                    };
                    _users.Add(user);
                }
            }
            return _users;
        }



    }
}
