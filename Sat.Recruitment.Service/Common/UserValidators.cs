using Sat.Recruitment.DataAccess;
using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sat.Recruitment.Service.Common
{
    public class UserValidaror
    {
        public static string ValidateUser(User newUser)
        {
            //Validate data integrity
            string nullField = NullFields(newUser);
            if (nullField != "")
                return $"Null values are not allowed. [Field: {nullField}]";

            //Validate if user is duplicated
            if (IsUserDuplicated(newUser))
                return "User already exists.";

            return "";
        }


        private static string NullFields(User user)
        {
            foreach (var prop in user.GetType().GetProperties())
                if (prop.GetValue(user, null) == null) return prop.Name;

            return "";
        }

        private static bool IsUserDuplicated(User newUser)
        {
            Data _data = new Data();
            var oldUsers = _data.ReadDataFromFile();

            foreach (var user in oldUsers)
            {
                if (user.Email == newUser.Email || user.Phone == newUser.Phone)
                    return true;
                else if (user.Name == newUser.Name && user.Address == newUser.Address)
                    return true;
            }
            return false;
        }
    }
}
