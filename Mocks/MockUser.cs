using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockUser : IUser
    {
        public IEnumerable<User> GetUserID
        {
            get
            {
                return new List<User> {
               new User {id = 279831 }};
               
            }
        }
    }
}

