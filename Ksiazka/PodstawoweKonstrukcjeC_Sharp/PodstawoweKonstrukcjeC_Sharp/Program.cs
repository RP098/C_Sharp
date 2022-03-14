using System;


namespace PodstawoweKonstrukcjeC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Basical Element C#";
            Console.WriteLine("Hello World!");
            string[] theArgs = Environment.GetCommandLineArgs();
            for(int i=0; i<theArgs.Length;i++)
                Console.WriteLine("Argument {0}  ",theArgs[i]);

             ComponentSystemEnvironment componentSystem = new ComponentSystemEnvironment();
            componentSystem.ShowEnvironmentDetails();

            ConsoleFormat consoleFormat = new ConsoleFormat();
            consoleFormat.BasicalFormatConsole();


            ComponentTypeNumber componentType = new ComponentTypeNumber();
            componentType.TypeNumber();


            Parsing.Parse();


            StringOperations stringOperations = new StringOperations();
            stringOperations.BasicalOperations();


            TextStringBuildier.TextBuildier();
            int age = new int();
            char sign = 'w';
            string interpolation = $" Helo I'm {age}years old {sign} ";

            Console.WriteLine(interpolation);
            //Console.WriteLine("podaj number 1 będzie to short");
            //short number1 = short.Parse(Console.ReadLine());
            //Console.WriteLine("podaj number 2 będzie to short");
            //short number2 = short.Parse(Console.ReadLine());
            //Console.WriteLine("Multiplication two short numbers  {0}",WordsChecked.shortMultiplication(number1,number2));
            ImplicitTyping implicitTyping = new ImplicitTyping();

            implicitTyping.TypingLinqu();
            ValueReferences value = new ValueReferences();
            int Out_ = 2,dwa=2,trzy=3;
            Console.WriteLine("dwa = {0} trzy= {1} Out_= {2}", dwa, trzy, Out_);
            value.modifierOut(dwa, trzy, out Out_);
            Console.WriteLine("dwa = {0} trzy= {1} Out_= {2}", dwa,trzy,Out_);
            int Out_1;
            value.modifierOut(dwa, trzy, out Out_1);
            Console.WriteLine("dwa = {0} trzy= {1} Out_1 bez przypisania= {2}", dwa, trzy, Out_);
            int Ref_= 22;
            value.modifierRef(dwa, trzy, ref Ref_);
            Console.WriteLine("dwa = {0} trzy= {1} Ref był 22 a teraz = {2}", dwa, trzy, Ref_);

            Console.WriteLine("Suma 2 3 4 5 6 = {0}",value.modifierParams(2,3,4,5,6));
            Program program = new Program();
            program.NamedParameters(c:2);


            Enum @enum = new Enum();
            @enum.Enums();

            Point point= new Point(2,2,"tekst","");
       
            Console.WriteLine(point.showX());
            Console.WriteLine(point.showY());
            point.showStringa(); 
            Point point1 = point;
            point1.SetString("punkt nowy");
            Console.WriteLine(point.showX());
            Console.WriteLine(point.showY());
            point.showStringa();
            point.text_New.Info = "222";
            point1.text_New.Info = "333";
            Console.WriteLine(point1.showX());
            Console.WriteLine(point1.showY());
            point1.showStringa();
            Console.WriteLine("Point 1 tekst {0} point 2 {1}",point.text_New.Info,point1.text_New.Info);

            TransisionTypeReferencebyValueandReference transision = new TransisionTypeReferencebyValueandReference();
            transision.name = "adam";
            transision.years = 33;

            Console.WriteLine(transision.name+" "+ transision.years);
            transision.changePersonvalue(transision);
            Console.WriteLine(transision.name+" "+ transision.years);
            TransisionTypeReferencebyValueandReference transision1 = new TransisionTypeReferencebyValueandReference();
            transision1.years = 22;
            transision1.name = "rafal";
            transision = transision1;
            Console.WriteLine(transision.name + " " + transision.years);
            transision1.years = 23;
            transision1.name = "rafal1";
            Console.WriteLine(transision.name + " " + transision.years);

            NullValue nullValue = new NullValue();
            bool changeDecision = nullValue.nulleableBool ?? true; // operator scalający
            string string_=null;
            Console.WriteLine(changeDecision.ToString());
            Console.WriteLine($"you can using {string_?.Length}");//jeśli string będzie nullem to wartość we wnątrz nie wywoła błędu

            Console.WriteLine($"you can using {string_??"Tekst opcjonalny string jest nullem"}");
         
            Console.ReadLine();
        }

        void NamedParameters(int i = 0, int d=2, int c=44)
        {
            Console.WriteLine(i+" "+ d +" "+ c +" ");
        }


        

    }
    
}
/*
Warianty Main
static void Main(string[] args) funkcja przyjmuje jeden parametr tablice
        {
        
        }


static void Main() //nie zdefiniowano jawnie tryby zwracanego 
        {
         
        }


static int Main() //zwraca wartość int
        {

          return 0; //zwraca wartość do systemu
                    //0 oznacza że wartość jest prawidłowa 0 jest zwracane zawsze nawet jeśli jest void
                    //inna np.-1 oznacza wystąpienie błędu
                    //wartość zwracana przechowywana w zmiennej %ERRORLEVEL% 
        }

 */