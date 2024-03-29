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


          
         }
    }
}
          
