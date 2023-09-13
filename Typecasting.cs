namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //implicit type conversion
                     byte b = 1;
                     int i = b;
                     Console.WriteLine(i);
                     float f = i;
                     Console.WriteLine(f);
              
                    //expicit type conversion
                       byte by =(byte) i;
                      Console.WriteLine(by);
              
                    //non-compatible types
                      var number = "1234";
                      int i = Convert.ToInt32(number);
                      double d=Convert.ToInt64(number);
                      Console.WriteLine(i);
                      Console.WriteLine(d);
        }
    }
}
              
