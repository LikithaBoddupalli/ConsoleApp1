// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

String name = "Likitha";
Console.WriteLine("Hello " + name);

Console.WriteLine($"Hii {name}");

String n1 = "Varshu";
String n2 = "Likki";
Console.WriteLine($"My Friends are {n1},{n2}");
//Getting length of string
Console.WriteLine($"Length of n1 is {n1.Length}");

//Triming the spaces
String greet = "        Hello...        ";
Console.WriteLine($"[{greet}]");
Console.WriteLine($"[{greet.TrimStart()}");
Console.WriteLine($"[{greet.TrimStart()}]");
Console.WriteLine($"[{greet.TrimEnd()}]");

//Replace the String
string s1 = "Hello World";
Console.WriteLine(s1);
s1 = s1.Replace("World", "India");
Console.WriteLine(s1);

//Coverting to lowercase or Upppercase
Console.WriteLine(s1.ToLower());
Console.WriteLine(s1.ToUpper());

//Check if string present or not
string lyrics = "Rain Rain go away";
Console.WriteLine(lyrics.Contains("Rain"));
Console.WriteLine(lyrics.Contains("Come"));
Console.WriteLine(lyrics.StartsWith("rain"));
Console.WriteLine(lyrics.StartsWith("Rain"));
Console.WriteLine(lyrics.EndsWith("away"));
Console.WriteLine(lyrics.EndsWith("Away"));

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






