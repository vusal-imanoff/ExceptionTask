using System;
using System.Collections.Generic;
using System.Text;

namespace BookSalerTaskException.Exceptions
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
        public SameBookalreadyAddedExpection(string message, SameBookalreadyAddedExpection sameBookalreadyAddedExpection) : base(message, sameBookalreadyAddedExpection)
        {

        }
    }
}
