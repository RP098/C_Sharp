using System;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    interface IindexerInInterface
    {
        Person this[string name] { get;set; }
    }
}
