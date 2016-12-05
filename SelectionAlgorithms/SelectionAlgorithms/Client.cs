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
        //This is the current name of the test, used for convenience purposes
        //keeps track of the current test being tested
        public static string currentMethodName { get; private set; }

        static void Main(string[] args)
        {
            //will use this to easily generate new array objects of various sizes with random elements
            ArrayFactory arrayCreator = new ArrayFactory();
            
            //Stopwatch keeps track of times
            Stopwatch stopwatch = new Stopwatch();
            long lastTestElapsed = -1;

            //Median value for the tests, only used to check for a reasonable value,
            //actual outcome per test is not critical as much as the time is
            IComparable median = -1;


            //method to make new array with factory is newArray(size of array, range of array (0-integer input) )
            //IComparable[] is just an array of elements, it is convenient to use for comparing everything
            IComparable[] test1;
            IComparable[] test2;
            IComparable[] test3;


            //
            // Deterministic Select Algo Testing
            //
            // DetSelection()
            //
            for (int i = 0; i < 30; i++)
            {
                test1 = arrayCreator.newArray(10000, 10000); // 10,000
                test2 = arrayCreator.newArray(1000000, 1000000); // 1,000,000
                test3 = arrayCreator.newArray(10000000, 10000000); // 10,000,000

                stopwatch.Start();
                median = DetSelection(test1);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "A" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test1.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = DetSelection(test2);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "B" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test2.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = DetSelection(test3);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "C" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test3.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;
            }

            //
            // Randomized Select Algo Testing
            //
            // RandSelection()
            //
            for (int i = 0; i < 30; i++)
            {
                test1 = arrayCreator.newArray(10000, 10000); // 10,000
                test2 = arrayCreator.newArray(1000000, 1000000); // 1,000,000
                test3 = arrayCreator.newArray(10000000, 10000000); // 10,000,000

                stopwatch.Start();
                median = RandSelection(test1);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "A" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test1.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = RandSelection(test2);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "B" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test2.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = RandSelection(test3);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "C" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test3.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;
            }


            //
            // Randomized Quicksort Select Algo Testing
            //
            for (int i = 0; i < 30; i++)
            {
                test1 = arrayCreator.newArray(10000, 10000); // 10,000
                test2 = arrayCreator.newArray(1000000, 1000000); // 1,000,000
                test3 = arrayCreator.newArray(10000000, 10000000); // 10,000,000

                stopwatch.Start();
                median = RandQuickSelection(test1);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "A" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test1.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = RandQuickSelection(test2);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "B" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test2.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;

                stopwatch.Start();
                median = RandQuickSelection(test3);
                stopwatch.Stop();
                lastTestElapsed = stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
                Console.WriteLine(Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "           Test " + (i + 1) + "C" + Environment.NewLine
                                  + "---------------------------------------" + Environment.NewLine
                                  + "Median Value: " + median + Environment.NewLine
                                  + "Array Size: " + test3.Length + Environment.NewLine
                                  + "Elapsed Test Time: " + lastTestElapsed + " ms" + Environment.NewLine
                                  + "Test Name: " + Client.currentMethodName
                                  + Environment.NewLine);
                median = -1;
            }


            //This readline keeps the console from closing at the end
            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }




        //This is the Deterministic version of Selection sort
        public static IComparable DetSelection(IComparable[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

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

            return -1;
        }
        
        //actual method to do the deterministic selection
        //called by "DetSelection"
        public static IComparable DetSelect(IComparable[] array, int i)
        {
            return 1;
        }
        



        //This is the Randomized version of Selection sort
        public static IComparable RandSelection(IComparable[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            return -1;
        }



        //This is where we use randomized quicksort to do the sorting and then select the element we need
        public static IComparable RandQuickSelection(IComparable[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            Random rand = new Random();
            Quicksort(array, 0, array.Length - 1, rand);
            return array[(array.Length - 1)/2];
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
