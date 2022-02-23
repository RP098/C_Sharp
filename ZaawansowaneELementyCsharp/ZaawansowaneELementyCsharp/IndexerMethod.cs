using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZaawansowaneELementyCsharp
{
    class IndexerMethod : IEnumerable, IindexerInInterface
    {
        private ArrayList PersonCollection = new ArrayList();
        public Person this[int index] 
        {
            get { return (Person)PersonCollection[index]; }
            set { PersonCollection.Insert(index, value); }
        }
        private Dictionary<string, Person> PersonCollection1 = new Dictionary<string, Person>();
        public Person this[string name]
        {
            get { return (Person)PersonCollection1[name]; }
            set { PersonCollection1.Add(name, value); }
        }
        public IEnumerator GetEnumerator()
        {
            return  PersonCollection.GetEnumerator();
        }
    }
}
