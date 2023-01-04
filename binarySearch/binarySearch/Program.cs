using System.Collections.Immutable;

namespace binarySearch
{
    public class Program
    {
        public static void Main()
        {
            //creating a list of 90 numbers

            int[] arr = new int[90];
            int[] arrSort = new int[90];
            Random rnd = new Random();
            for (int i=0;i<90;i++)
            {
                arr[i] = rnd.Next(1, 100);
            }

            //printing the list of numbers

            for (int i=0;i<arr.Length;i++)
            {
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();

            Array.Sort(arr);
            //array sorted
            Console.WriteLine("Array Sorted");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            //loking for a number
            Console.WriteLine("Type an integer between 1 and 100. We will looking for this number in the list");
            int number = int.Parse(Console.ReadLine());
            if (number == arr[(arr.Length)-1/2])
            {
                Console.WriteLine("Teh number " + number + "is in the " + (arr.Length - 1) / 2 + "th position");
            }
            else if (number > arr[(arr.Length-1)/2])
            {

            }
            else if (number < arr[(arr.Length - 1) / 2])
            {

            }


        }
    }
}