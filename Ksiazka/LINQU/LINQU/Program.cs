using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace LINQU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueryOverStrings();
            Number();
            Console.WriteLine("\nReturn value linqu"); 
            foreach ( var item in QueryOverStringsSecend())
            {
                Console.WriteLine( item+" " );
            }
            Console.WriteLine("\nReturn value linqu"); 
            foreach (var item in QueryOverStringsThird())
            {
                Console.WriteLine(item + " ");
            }
            Car_Query();
            Console.WriteLine();

            Console.WriteLine("Fun with Query Expressions");
            ProductInfo[] itemsInstock = new ProductInfo[] { 
                new ProductInfo {Name="Mac's Caffe",Description="Coffe with sugar",NumberInStock=22 },
                new ProductInfo {Name="Tea",Description="Green tea",NumberInStock=23 },
                new ProductInfo {Name="Chocolate",Description="Milk chocolate",NumberInStock=30 },
                new ProductInfo {Name="Milk",Description="Strawberry milk",NumberInStock=31 },
                new ProductInfo {Name="Bar coconut",Description="Delicious bar",NumberInStock=42 },
                new ProductInfo {Name="Cookies",Description="Peanut Cookies",NumberInStock=52 } 
            };
            var products = from p in itemsInstock select p;
            foreach (var item in products)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();
            var productsName = from p in itemsInstock select p.Name;
            foreach (var item in productsName)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();
            var productsNameAndDescription = from p in itemsInstock orderby p.Name ascending select new {p.Name,p.Description };
            foreach (var item in productsNameAndDescription)
                Console.WriteLine("Products name {0}, description {1}",item.Name,item.Description);
            Console.WriteLine();
            Console.WriteLine();
            var ExceptProductSet = (from p in itemsInstock where p.NumberInStock >= 31 select p).Except(from p in itemsInstock where p.NumberInStock >= 23 && p.NumberInStock <= 42 select p);//except róźnica zbiorów 
            foreach (var item in ExceptProductSet)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            var IntersectProductSet = (from p in itemsInstock where p.NumberInStock >= 31 select p).Intersect(from p in itemsInstock where p.NumberInStock >= 23 && p.NumberInStock <= 42 select p);//intersect część wspólna zbiorów 
            foreach (var item in IntersectProductSet)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            var UnionProductSet = (from p in itemsInstock where p.NumberInStock >= 31 select p).Union(from p in itemsInstock where p.NumberInStock >= 23 && p.NumberInStock <= 42 select p);//intersect część wspólna zbiorów 
            foreach (var item in UnionProductSet)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            var ConcatProductSet = (from p in itemsInstock where p.NumberInStock >= 31 select p).Concat(from p in itemsInstock where p.NumberInStock >= 23 && p.NumberInStock <= 42 select p);//intersect część wspólna zbiorów 
            foreach (var item in ConcatProductSet.Distinct())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Max number in stock");
            var maxNumber = (from p in itemsInstock select p.NumberInStock).Max();
            Console.WriteLine($"Max number = {maxNumber}");
            Console.WriteLine("Min number in stock");
            var minNumber = (from p in itemsInstock select p.NumberInStock).Min();
            Console.WriteLine($"Min number = {minNumber}");
            Console.WriteLine("Sum number in stock");
            var sumNumber = (from p in itemsInstock select p.NumberInStock).Sum();
            Console.WriteLine($"sum number = {sumNumber}");
            Console.WriteLine("Average number in stock");
            var avgNumber = (from p in itemsInstock select p.NumberInStock).Average();
            Console.WriteLine($"Average number = {avgNumber}");
            Console.WriteLine();//New linqu expresions with use lambda 
            var newLinqu = itemsInstock.Where(item => item.NumberInStock >= 30).OrderBy(item => item.NumberInStock).Select(item => item);
            foreach (var item in itemsInstock)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void QueryOverStrings()
        {
            string[] text_ = {"One","Two","Three","Four","First 1","Secend","Time 2","Once"};
            IEnumerable<string> subset = from g in text_ where g.Contains(" ") orderby g select g;
            foreach (var s in subset)
            {
                Console.WriteLine(s);
            }
        }
        static IEnumerable<string> QueryOverStringsSecend()
        {
            string[] text_ = { "One", "Two", "Three", "Four", "First 1", "Secend", "Time 2", "Once" };
            IEnumerable<string> subset = from g in text_ where g.Contains(" ") orderby g select g;
            return subset;
        }

        static string[] QueryOverStringsThird()
        {
            string[] text_ = { "One", "Two", "Three", "Four", "First 1", "Secend", "Time 2", "Once" };
            string[] subset = (from g in text_ where g.Contains(" ") orderby g select g).ToArray<string>();// immediate execution natychmiastowe wykonanie

            return subset;
        }
        static void Number()
        {
            int[] numberArray = { 1, 3, 4123, 412, 3, 1, 2456, 124, 124, 63, 147, 2712 };
            var number = from num in numberArray where num > 10 select num;
            foreach (var item in number)
                Console.Write(item +" ");
     
            Console.WriteLine();
            Console.WriteLine("\nChange my set with and replace 1 for 999");
            numberArray[0] = 999;
            foreach (var item in number) //execution deferred - odroczone wykonywanie
                Console.Write(item + " ");
            
            Console.WriteLine();

        }
        static void Car_Query()
        {
            car car_ = new car();
            car_.cars = new List<car>();
            car_.cars.Add(new car(155,"BMW"));
            car_.cars.Add(new car(55,"Trabant"));
            car_.cars.Add(new car(65,"Honda"));
            car_.cars.Add(new car(15,"Suzuki"));
            car_.cars.Add(new car(89,"Opel"));

            var cars_ = from c in car_.cars where c.Speed >= 60 select c;
            Console.WriteLine("\nCars where speed is more and equal 60 ");
            foreach (var item in cars_)
            {
                Console.WriteLine(item.Mark+"  "+ item.Speed);
            }

        }

        static void Collection_Non_generic()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new car(20, "BMW"));
            arrayList.Add(new car(30, "Trabant"));
            arrayList.Add(new car(40, "Syrena"));
            arrayList.Add(new car(50, "Fiat"));
            arrayList.Add(new car(60, "Lanos"));
            arrayList.Add(new car(70, "Kadet"));
            Console.WriteLine("\nNew list car");
            var cars_ = from c in arrayList.OfType<car>() where c.Speed >= 40 select c;
            foreach (var item in cars_)
                Console.WriteLine(item.Mark + "  " + item.Speed);
            
        }




    }
}
