using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockRiver : IRiver
    {
        public IEnumerable<River> GetRiverId
        {
            get
            {
                return new List<River> {
                    new River {id = 1 }
                    
                };
               
            }
            
        }             
    }
}
