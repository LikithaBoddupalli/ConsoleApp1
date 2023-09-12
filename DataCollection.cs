namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings
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

            //Indexing
            string myString = "Hello";
            Console.WriteLine(myString[0]); 

            string myStr = "Hello";
            Console.WriteLine(myString.IndexOf("e"));
            Console.WriteLine(myStr.Substring(2));

            //special characters in String
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            string txt1 = "It\'s alright.";
            onsole.WriteLine(txt1);
            string txt2 = "The character \\ is called backslash.";
            onsole.WriteLine(txt2);


             //create Arrays
             String[] cars = { "volvo", "BMW", "Ford", "Mazda" };
             int[] numbers = new[] { 1, 2 ,8,-7};
             int[] num = new int[4]; 
            
             //accesing the array
             Console.WriteLine(cars[0]);
             Console.WriteLine(cars[3]);
            
            
             //length of array
             Console.WriteLine(cars.Length);
            Console.WriteLine(numbers.Length);
            
             //Changing the array elements
             cars[3] = "Maruthi";
            
             // for Loops in arrays
             for (int i=0;i<cars.Length;i++)
             {
                 Console.WriteLine(cars[i]);
             }
            
            //foreach loop in array
            foreach(int i in numbers)
             {
                 Console.WriteLine(i);
             }
            
            //sort an array
            Array.Sort(cars);
             foreach (var i in cars)
             {
                 Console.WriteLine(i);
             }
            
             // using Linq namespace 
             Console.WriteLine(numbers.Max());
             Console.WriteLine(numbers.Min());
             Console.WriteLine(numbers.Sum());

            //Multidimensional Array
            int[,] arrays = { { 1, 3, 5 }, { 2, 4, 6 } };
            Console.WriteLine(arrays[0,0]);
            Console.WriteLine(arrays[0,1]);
            Console.WriteLine(arrays[0,2]);
            Console.WriteLine(arrays[1,0]);
            Console.WriteLine(arrays[1,1]);
            Console.WriteLine(arrays[1,2]);
            
            //change element
            arrays[0, 0] = 0;
            
            // foreach loops
            foreach(int i in arrays)
            {
                Console.WriteLine(i);
            }
            
            //For loop
            for(int i = 0;i<arrays.GetLength(0);i++)
            {
                for (int j = 0; j <arrays.GetLength(1); j++)
                {
                    Console.WriteLine(arrays[i,j]);
                }
            }
         }
    }
}
          
