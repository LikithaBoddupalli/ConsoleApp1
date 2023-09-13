namespace CSharp
{
    internal partial class Program
    {
        public class Methods
        {
            static void Main(string[] args) 
            {
                //Calling a Method
                MyMethod();
                Para1("likitha");
                Parameters("bunny", 21);
                Name("USA");
                Name();
                Console.WriteLine(Number(5));
                Console.WriteLine(Num(3, 5));
                Family(child3: "John", child1: "Marry", child2: "Joe");
                int myNum1 = PlusMethod(8, 5);
                double myNum2 = PlusMethod(4.3, 6.26);
                Console.WriteLine("Int: " + myNum1);
                Console.WriteLine("Double: " + myNum2);
            }
            //Creating method
            static void MyMethod()
            {
                Console.WriteLine("Hello");
            }

            //Method with 1 parameter
            static void Para1(string fname)
            {
                Console.WriteLine(fname);
            }

            //Method with multiple parameters
            static void Parameters(string fname, int age)
            {
                Console.WriteLine($"{fname} is {age} yrs");
            }

            //Default parameters
            static void Name(string country = "Norway")
            {
                Console.WriteLine(country);
            }

            //Return values
            static int Number(int a)
            {
                return a + 5;
            }
            static int Num(int a, int b)
            {
                return a + b;
            }

            //Named arguments
            static void Family(string child1, string child2, string child3)
            {
                Console.WriteLine("The youngest child is: " + child3);
            }

            //Method overloading
            static int PlusMethod(int x, int y)
            {
                return x + y;
            }

            static double PlusMethod(double x, double y)
            {
                return x + y;
            }
        }

    }

}
