using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionAlgorithms
{
    class Client
    {
        static void Main(string[] args)
        {
            //will use this to easily generate new array objects of various sizes with random elements
            ArrayFactory arrayCreator = new ArrayFactory();

            //Stopwatch keeps track of times
            Stopwatch stopwatch = new Stopwatch();
            long lastTestElapsed = -1;


            //method is newArray(size of array, range of array (0-integer input) )
            //IComparable[] is just an array of elements, it is convenient to use for comparing everything
            IComparable[] test1 = arrayCreator.newArray(1000, 1000);

            //here will be tons of running of all of the algorithms and outputs of times and such


            //example of stopwatch usage
            stopwatch.Start();
            RandQuickSelection(test1, 117);
            stopwatch.Stop();
            lastTestElapsed = stopwatch.ElapsedMilliseconds;
            
            Console.WriteLine(Environment.NewLine + lastTestElapsed);

            //This readline keeps the console from closing at the end
            Console.ReadLine();
        }

        //This is the Deterministic version of Selection sort
        public static void DetSelection(IComparable[] array, IComparable key)
        {
            //  http://www.ics.uci.edu/~eppstein/161/960130.html
            //  http://www.columbia.edu/~cs2035/courses/csor4231.F11/dselect.pdf


            //1 if (n = 1)
            //2 return A[1]
            //3 p = median(A)
            //4
            //5
            //6 L = { x ∈ A: x ≤ p}
            //  H = { x ∈ A: x > p}
            //7 if i ≤ | L |
            //8 Select(L, i, | L |)
            //9 else Select(H, i − | L |, | H |)
        }

        //actual method to do the deterministic selection
        public static IComparable DetSelect(IComparable[], int i, IComparable n)
        {
            return 1;
        }

        //This is the Randomized version of Selection sort
        public static void RandSelection(IComparable[] array, IComparable key)
        {
            //  
        }

        //This is where we use randomized quicksort to do the sorting and then select the element we need
        public static void RandQuickSelection(IComparable[] array, IComparable key)
        {
            //Not complete, hecking together a way to check the validity of the sorting method
            printArray(array);

            Random rand = new Random();
            Quicksort(array, 0, array.Length - 1, rand);

            Console.WriteLine();
            printArray(array);
        }

        //This is a working quicksort algorithm, need to implement the pivot as a random pivot and not the middle of the array
        public static void Quicksort(IComparable[] elements, int left, int right, Random rand)
        {
            int i = left, j = right;
            IComparable pivot = elements[rand.Next(left, right)];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j, rand);
            }

            if (i < right)
            {
                Quicksort(elements, i, right, rand);
            }
        }


        //This is just a makeshift way to print the arrays, it is in no way clean at all
        //but i need to print stuff to make sure sorting is working
        public static void printArray(IComparable[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array.Length % array.Length == 50)
                {
                    Console.WriteLine(" " + array[i]);
                }
                else
                {
                    Console.Write(" " + array[i]);
                }
            }
        }
    }
}
