using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockOperator : IOperator
    {
        public IEnumerable<Operator> GetOperatorId
        {
            get
            {
                return new List<Operator>
                {
                    new Operator {id = 6 }};            
            }
        }
    }
}

