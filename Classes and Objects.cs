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


 

