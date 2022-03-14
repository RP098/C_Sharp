using System;
using System.Collections.Generic;
using System.Text;

namespace ObslugaWyjatkow
{
    [Serializable]
    class IdealClassExceptionCatch:ApplicationException
    {

       
            public IdealClassExceptionCatch() { }
            public IdealClassExceptionCatch(string message) : base(message) { }
            public IdealClassExceptionCatch(string message, Exception inner) : base(message, inner) { }
            protected IdealClassExceptionCatch(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
      


    }
}
