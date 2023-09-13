namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
