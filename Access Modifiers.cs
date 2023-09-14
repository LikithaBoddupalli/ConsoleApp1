//Private Access Modifier
namespace CSharp
{
 class Bike
    {
        private string name="Passion";
        static void Main(String[] args)
        {
            Bike bike = new Bike();
            Console.WriteLine(bike.name);
        }

    }  
}

//Public Access Modifier within same class
namespace CSharp
{
 class Bike
    {
        public string name="Passion";
        static void Main(String[] args)
        {
            Bike bike = new Bike();
            Console.WriteLine(bike.name);
        }

    }
   
}

//Public Access Modifier with different classes
namespace CSharp
{
 class Bike
    {
        public string name="Passion";

    }
    class MainClass
    {
        static void Main(String[] args)
        {
            Bike bike = new Bike();
            Console.WriteLine(bike.name);
        }
    }
}
