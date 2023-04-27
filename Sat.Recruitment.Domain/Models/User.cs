using System;

namespace Sat.Recruitment.Domain.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
        public decimal Money { get; set; }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5}",
                Name,
                Email,
                Phone,
                Address,
                UserType,
                Money);
        }
    }
}
