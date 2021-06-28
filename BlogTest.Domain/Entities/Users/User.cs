using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTest.Domain.Entities.Users
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
    }
}
