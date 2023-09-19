namespace CSharp
{
 class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void main(String[] args)
        {
            Person p = new Person();
            p.Name = "Bunny";
            Console.WriteLine(p.Name);
        }
    }
}


//default properties
namespace CSharp
{
 class Person
    {
        public string Name{ get; set; }
     
    }
    class Program
    {
        static void Main(String[] args)
        {
            Person p = new Person();
            p.Name = "Bunny";
            Console.WriteLine(p.Name);
        }
    }
}


using System;

public class Vehicle {
  private string _type;
  public string Type {
    get { return _type; }
    set {
      if (value == String.Empty) {
        Console.WriteLine("The vehicle type cannot be empty");
      }
      else _type = value;
    }
  }

  private int _numTires;
  public int NumTires {
    get { return _numTires; }
    set { 
      if (value < 1) {
        Console.WriteLine("The vehicle must have at least one tire");
      }
      else _numTires = value;
    }
  }
}

public class MainClass {
    public static void Main() {
        // Test code
        Vehicle myRide = new Vehicle();
        myRide.Type = "Motorcycle";
        myRide.NumTires = 2;
        Console.WriteLine(myRide.Type);
        Console.WriteLine(myRide.NumTires);
        myRide.Type = String.Empty;
        Console.WriteLine(myRide.Type);
        myRide.NumTires = 0;
        Console.WriteLine(myRide.NumTires);
    }
}
