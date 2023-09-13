//creating a HumanClass
namespace CSharp
{
    class HumanClass
    {
       public string firstName = "likitha";

         public void talk()
        {
            Console.WriteLine("Talking");
        }
        public static void eat()
        {
            Console.WriteLine("Eating");
        }
    }
}


namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of HumanClass
            HumanClass myObj = new HumanClass();
            HumanClass humanClass = new HumanClass();
            humanClass.firstName = "Bunny";
         
            //access the variables of the classes
            Console.WriteLine(myObj.firstName);
            Console.WriteLine(humanClass.firstName);
        }
    }
 }


 //Example-2
namespace CSharp
{
    class car
    {
        public int numTires = 4;
        public int year = 2000;
        public bool runs = true;
    }
    public class MainClass
    {
        public static void Main()
        {
            car car1 = new car();
            car car2 = new car();
            car car3 = new car();
            // Test code
            Console.WriteLine(car1.numTires);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.runs);
        }
    }
}
