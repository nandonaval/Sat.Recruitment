using Sat.Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Service.Common
{
    public static class UserExtensions
    {


        public static string NormalizeEmail(this string email)
        {

            try
            {
                var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
                aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);
                return string.Join("@", new string[] { aux[0], aux[1] });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error wthile parsing Email: {email}. {ex.InnerException}");
            }
        }

        public static decimal CalculateUserMoney(string userType, decimal money)
        {
            switch (userType)
            {
                case "Normal":
                    if (money > 100)
                        money += (money * (decimal).12);
                    else if (money > 10)
                        money += (money * (decimal).8);
                    break;
                case "SuperUser":
                    if (money > 100)
                        money += (money * (decimal).2);
                    break;
                case "Premium":
                    if (money > 100)
                        money += (money * 2);
                    break;
            }

            return money;
        }
    }
}
