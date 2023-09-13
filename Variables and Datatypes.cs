// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //Variables and Datatypes
                  byte number = 1;
                  int count = 10;
                  float price = 2.5f;
                  char character = 'A';
                   bool answer=false;
                   var num = 10;
                   var boolean = true;
                   var name = "Likitha";
                   Console.WriteLine(number); 
                   Console.WriteLine(count);
                   Console.WriteLine(price);
                    Console.WriteLine(character);
                    Console.WriteLine(answer);
                    Console.WriteLine(name);
                    Console.WriteLine(num);
                    Console.WriteLine(boolean);
              
                    const float Pi = 3.14f;
                    Console.WriteLine(Pi);       
              
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
              
                  //Arithmetic operations
                  int a = 18;
                  int b = 6;
                  int c = a+b;
                  Console.WriteLine(c);
                  int d = a-b;
                  Console.WriteLine(d);
                  int e = b*c;
                  Console.WriteLine(e);
                  int f = a/d;
                  Console.WriteLine(f);
                  
                  //order of operations
                  int g = 5;
                  int h = 4;
                  int i = 2;
                  int j= g + h * i;
                  Console.WriteLine(j);
                  
                  int k = 5;
                  int l = 4;
                  int m = 2;
                  int n = (k + l) * m;
                  Console.WriteLine(n);
                  
                  int s= (k + l) - 6 * m + (12 * 4) / 3 + 12;
                  Console.WriteLine(s);
                  
                  
                  //remainder and quotient
                  int p = 7;
                  int q = 4;
                  int r = 3;
                  int t = (a + b) / c;
                  int u = (a + b) % c;
                  Console.WriteLine($"quotient: {t}");
                  Console.WriteLine($"remainder: {u}");
                  
                  //Range of int 
                  int max = int.MaxValue;
                  int min = int.MinValue;
                  Console.WriteLine($"The range of integers is {min} to {max}");
                  
                  int over = max + 3;
                  Console.WriteLine($"An example of overflow: {over}");
                  
                  //doouble type
                  double x = 19;
                  double y = 23;
                  double z = 8;
                  double v = (x + y) / z;
                  Console.WriteLine(v);
                  
                  //range of double
                  double max1 = double.MaxValue;
                  double min1 = double.MinValue;
                  Console.WriteLine($"The range of double is {min1} to {max1}");
                  
                  double third = 1.0 / 3.0;
                  Console.WriteLine(third);
                  
                  
                  //decimal type
                  decimal c1 = 1.0M;
                  decimal d1 = 3.0M;
                  Console.WriteLine(c1 / d1);
                  
                  //range of decimal
                  decimal max2 = decimal.MaxValue;
                  decimal min2 = decimal.MinValue;
                  Console.WriteLine($"The range of double is {min2} to {max2}");
                  
                  //area of the circle
                  double radius = 2.50;
                  double area = Math.PI * radius * radius;
                  Console.WriteLine(area);
                  
                   //comparison operator
                   var a = 10;
                   var b = 20;
                   Console.WriteLine(a != b);
                   Console.WriteLine(b <= a);
                   Console.WriteLine(b > a);
                   Console.WriteLine(b == a);
                  
                   //logical operator
                   var a = 10;
                   var b = 20;
                   Console.WriteLine(a < b && a!=b);
                   Console.WriteLine(a < b && a==b);
                   Console.WriteLine(a == b || a<=b);
                   Console.WriteLine(a >= b || a==b);
                  //Assignment Operator
                  var a = 10;
                  Console.WriteLine(a+=5);
                  var b = 20;
                  Console.WriteLine(b-=2);
                  var c = 30;
                  Console.WriteLine(c*=3);
                  var d = 50;
                  Console.WriteLine(d/=2);
    
                //ternary operator
                int time = 20;
                string result = (time < 18) ? "Good day." : "Good evening.";
                Console.WriteLine(result);

            
        }
    }
}






