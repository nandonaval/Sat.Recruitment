using Sat.Recruitment.Domain.Common;
using Sat.Recruitment.Domain.Entities;
using System.Threading.Tasks;

namespace Sat.Recruitment.Service
{
    public interface IUserService
    {
        Response CreateUser(User user);
    }
}
