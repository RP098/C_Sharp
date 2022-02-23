using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    class DictionaryIndexedMethod: IEnumerable
    {
        private Dictionary<string,Person> PersonCollection = new Dictionary<string, Person>();
        public Person this[string name]
        {
            get { return (Person)PersonCollection[name]; }
            set { PersonCollection.Add(name,value); }
        }
        public IEnumerator GetEnumerator()
        {
            return PersonCollection.GetEnumerator();
        }
    }
}
