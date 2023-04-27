using Sat.Recruitment.Domain.Common;
using Sat.Recruitment.Domain.Entities;

namespace Sat.Recruitment.Test.Mocks
{
    public class Mocks
    {
        public static User MockUser()
        {
            return new User
            {
                Name = "Fernando Alvarez",
                Email = "nando.alvarez@hotmail.com",
                Address = "Some St 123",
                Phone = "123456789",
                UserType = "Premium",
                Money = 150
            };
        }

        public static User MockUserWithNullValues()
        {
            return new User
            {
                Name = "Fernando Alvarez",
                Email = null,
                Address = "Some St 123",
                Phone = "123456789",
                UserType = "Premium",
                Money = 150
            };
        }

        public static Response MockSuccessResponse()
        {
            return new Response
            {
                Status = ResponseStatus.Success
            };
        }
    }
}
