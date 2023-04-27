using Sat.Recruitment.Domain.Common;
using Sat.Recruitment.Service.Common;
using Sat.Recruitment.Domain.Entities;
using System;
using Sat.Recruitment.DataAccess.Repository;

namespace Sat.Recruitment.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Response CreateUser(User user)
        {
            //Normalize email before validate duplicated
            user.Email = user.Email.NormalizeEmail();

            //Validate data
            string errors = UserValidaror.ValidateUser(user);
            if (!string.IsNullOrEmpty(errors))
                throw new ApplicationException(errors);

            //Calculate money field
            user.Money = UserExtensions.CalculateUserMoney(user.UserType, user.Money);

            userRepository.CreateUser(user);

            return new Response
            {
                Status = ResponseStatus.Success
            };
        }

    }
}
