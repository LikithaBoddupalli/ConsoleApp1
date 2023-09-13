//Constructors without parameters
namespace CSharp
{
    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            name = "likitha";
            age = 21;

        }
        public static void Main(String[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);

        }
    }
}

//Constructors  with parameters
namespace CSharp
{ 
    class Shape
    {
        public string Type;
        public int Sides;
        public int Sidelength;
        public double Area;
        public Shape(string type, int sides, int sidelength, double area)  //constructor
        {
            Type = type;
            Sides = sides;
            Sidelength = sidelength;
            Area = area;
        }
    }
    class MainClass
    {
        public static void Main()
        {
            Shape square = new Shape("square", 4, 1, 1);
            Shape bigsquare = new Shape("square", 4, 2, 4);
            Shape triangle = new Shape("triangle", 3, 3, 3.9);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", square.Type, square.Sides, square.Sidelength, square.Area);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", bigsquare.Type, bigsquare.Sides, bigsquare.Sidelength, bigsquare.Area);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", triangle.Type, triangle.Sides, triangle.Sidelength, triangle.Area);
        }
    }

}

//Example-3
using System;

public class Vehicle
        {
            public string Type;
            public int NumTires;
            public int year;
            public bool runs;
            public Vehicle(string Type,int NumTires,int year,bool runs)
            {
                this.Type = Type;
                this.NumTires = NumTires;
                this.year = year;
                this.runs = runs;
            }
}
    public class MainClass
    {
   
            static void Main(String[] args)
            {
                Vehicle car = new Vehicle("car",4,2000,true);
                Vehicle oldcar = new Vehicle("car",4,1980,false);
                Vehicle bike = new Vehicle("bike",2,2017,true);
                        
                Console.WriteLine(car.Type);
                Console.WriteLine(oldcar.runs);
                Console.WriteLine(bike.NumTires);
            }
    }

