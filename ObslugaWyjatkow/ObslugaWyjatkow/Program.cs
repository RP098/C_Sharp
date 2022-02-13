using System;
using System.Collections;
namespace ObslugaWyjatkow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            Console.WriteLine("Give me two integer number ");
            Console.WriteLine("Give me first number: ");
           
            try
            {
                int number_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give me secend number: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                Work_on_Number number = new Work_on_Number();
                number.SumTwoNumber(number_1, number_2);

            }
            catch (Original_Exception original_Exception) when (1==1)
            {
                original_Exception = new Original_Exception("Please give me correct integer number", DateTime.Now, "You must write integer number");

                Console.WriteLine(original_Exception.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception message: " + e.Message);
                Console.WriteLine("Target site: " + e.TargetSite);
                Console.WriteLine("Correct declaring type: " + e.TargetSite.DeclaringType);
                Console.WriteLine("Name target site: " + e.TargetSite.Name);
                Console.WriteLine("Source exception: " + e.Source);
                Console.WriteLine("Line of code " + e.StackTrace);
                e.HelpLink = "www.wikipedia.pl";
                Console.WriteLine("You can resolve this problem visit here " + e.HelpLink);
                e.Data.Add(" Problem appear", DateTime.Now);
                foreach (DictionaryEntry d in e.Data)
                {
                    Console.WriteLine(d.Key + " " + d.Value);
                }
            }
            finally
            {
                Console.WriteLine("You can closes connection with DataBase, file and end work others importants things");
            }

            Console.ReadKey();

        }
    }
}
