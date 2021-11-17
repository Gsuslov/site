using site.Interfaces;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site.Mocks
{
    public class MockFeedback : IFeedback
    {
        public IEnumerable<Feedback> GetFeedbackId
        {
            get
            {
                return new List<Feedback>
                {
                    new Feedback {id = 435 }};               
               

            }
        }
    }

}

