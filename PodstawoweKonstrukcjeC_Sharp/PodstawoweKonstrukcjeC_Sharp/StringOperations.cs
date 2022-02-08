using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class StringOperations
    {
        public void BasicalOperations()
        {

            string bob = "BOB it is me";
            Console.WriteLine(bob);
            Console.WriteLine("Długość boba {0}",bob.Length);
            Console.WriteLine("Bob mniejszy {0}", bob.ToLower());
            Console.WriteLine("Bob większy {0}",bob.ToUpper());
            Console.WriteLine("Bob złączony z adamem {0}",bob.Insert((bob.Length)," adam"));
            Console.WriteLine("Bob z Bobem {0}",bob.Equals(bob));

            Concatenation();
           
        }

        public void Concatenation()
        {
            string s1 = "Wet";
            string s2 = "Dry";
            string s3 = s1+" "+s2; //+ C# przetwarza plusa na wywołanie statycznej metody String.Concat
            Console.WriteLine(s3);
            Console.WriteLine(@"Łancuch / /Dosłowny:\' d "" ");
            StringIsUnModifiable();
        }
        public void StringIsUnModifiable()
        {
            string s1 = "Wet";
            string s2 = "Dry";
            s1 = "2";
            
            Console.WriteLine("Nawet po przypisaniu string jest niemodyfikowalny zmienia się adres dlatego aby uniknąć zaśmiecenia i spowolnień używaj typu Text");
        }

        

    }
}
