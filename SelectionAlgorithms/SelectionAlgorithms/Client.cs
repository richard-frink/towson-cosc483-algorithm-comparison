using System;
using System.Diagnostics;
using System.Collections.Generic;

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
            int median = -1;


            //method to make new array with factory is newArray(size of array, range of array (0-integer input) )
            int[] test1, test2, test3;

            //averages for each test that will  be found after all testing
            long avg1, avg2, avg3, avg4, avg5, avg6, avg7, avg8, avg9;

            //These hold the values of the results for sets of tests
            //one for each tested size of array
            List<long> results1 = new List<long>();
            List<long> results2 = new List<long>();
            List<long> results3 = new List<long>();
            List<long> results4 = new List<long>();
            List<long> results5 = new List<long>();
            List<long> results6 = new List<long>();
            List<long> results7 = new List<long>();
            List<long> results8 = new List<long>();
            List<long> results9 = new List<long>();

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
                results1.Add(lastTestElapsed);
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
                results2.Add(lastTestElapsed);
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
                results3.Add(lastTestElapsed);
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
                results4.Add(lastTestElapsed);
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
                results5.Add(lastTestElapsed);
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
                results6.Add(lastTestElapsed);
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
                results7.Add(lastTestElapsed);
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
                results8.Add(lastTestElapsed);
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
                results9.Add(lastTestElapsed);
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

            //sum for finding averages
            int sum = 0;

            //
            // Finding averages
            //

            foreach (int r in results1)
            {
                sum += r;
            }
            avg1 = sum / results1.Count;
            sum = 0;

            foreach (int r in results2)
            {
                sum += r;
            }
            avg2 = sum / results2.Count;
            sum = 0;

            foreach (int r in results3)
            {
                sum += r;
            }
            avg3 = sum / results3.Count;
            sum = 0;

            foreach (int r in results4)
            {
                sum += r;
            }
            avg4 = sum / results4.Count;
            sum = 0;

            foreach (int r in results5)
            {
                sum += r;
            }
            avg5 = sum / results5.Count;
            sum = 0;

            foreach (int r in results6)
            {
                sum += r;
            }
            avg6 = sum / results6.Count;
            sum = 0;

            foreach (int r in results7)
            {
                sum += r;
            }
            avg7 = sum / results7.Count;
            sum = 0;

            foreach (int r in results8)
            {
                sum += r;
            }
            avg8 = sum / results8.Count;
            sum = 0;

            foreach (int r in results9)
            {
                sum += r;
            }
            avg9 = sum / results9.Count;
            sum = 0;

            Console.WriteLine(Environment.NewLine + "Results of test 1:");
            printArray(results1.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 2:");
            printArray(results2.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 3:");
            printArray(results3.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 4:");
            printArray(results4.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 5:");
            printArray(results5.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 6:");
            printArray(results6.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 7:");
            printArray(results7.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 8:");
            printArray(results8.ToArray());
            Console.WriteLine(Environment.NewLine + "Results of test 9:");
            printArray(results9.ToArray());

            Console.WriteLine(Environment.NewLine
                              + "Average of test1: " + avg1 + "ms" + Environment.NewLine
                              + "Average of test2: " + avg2 + "ms" + Environment.NewLine
                              + "Average of test3: " + avg3 + "ms" + Environment.NewLine
                              + "Average of test4: " + avg4 + "ms" + Environment.NewLine
                              + "Average of test5: " + avg5 + "ms" + Environment.NewLine
                              + "Average of test6: " + avg6 + "ms" + Environment.NewLine
                              + "Average of test7: " + avg7 + "ms" + Environment.NewLine
                              + "Average of test8: " + avg8 + "ms" + Environment.NewLine
                              + "Average of test9: " + avg9 + "ms" + Environment.NewLine);

            //This readline keeps the console from closing at the end
            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }




        //This is the Deterministic version of Selection sort
        public static int DetSelection(int[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            //  http://www.ics.uci.edu/~eppstein/161/960130.html
            //  http://www.columbia.edu/~cs2035/courses/csor4231.F11/dselect.pdf


            //1 if (n = 1)
            //2     return A[1]
            //3 p = median(A)
            //4
            //5
            //6 L = { x ∈ A: x ≤ p}
            //  H = { x ∈ A: x > p}
            //7 if i ≤ | L |
            //8     Select(L, i, | L |)
            //9 else Select(H, i − | L |, | H |)
            
            return DetSelect(array, array.Length/2, array.Length);
        }
        
        //actual method to do the deterministic selection
        //called by "DetSelection"
        public static int DetSelect(int[] array, int i, int size)
        {
            if (size == 1)
                return array[0];

            int p = findMedian(array);

            List<int> L = new List<int>();
            List<int> H = new List<int>();

            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] >= p)
                    H.Add(array[x]);
                else L.Add(array[x]);
            }

            if (i <= L.Count)
                return DetSelect(L.ToArray(), i, L.Count);
            else return DetSelect(H.ToArray(), i - L.Count, H.Count);
        }
        
        //starts the process of finding the median
        public static int findMedian(int[] array)
        {
            int median = -1;

            List<int> medians = new List<int>();

            for (int i = 0; i < array.Length; i = i + 5)
                getMedians(array, medians, i, i + 4);

            int[] temp = medians.ToArray();
            Array.Sort(temp);
            median = temp[temp.Length / 2];

            return median;
        }

        //handles the recursive calls to break the array down into lengths of 5 and returns a list of medians
        public static void getMedians(int[] array, List<int> medians, int start, int end)
        {
            int j = 0;
            int[] temp = new int[5];
            for (int i = start; i < end; i++)
            {
                temp[j] = array[i];
                j++;
            }
            Array.Sort(temp);
            medians.Add(temp[2]);
        }



        //This is the Randomized version of the selection
        public static int RandSelection(int[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            
            return -1;
        }



        //This is where we use randomized quicksort to do the sorting and then select the element we need
        public static int RandQuickSelection(int[] array)
        {
            Client.currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            Random rand = new Random();
            Quicksort(array, 0, array.Length - 1, rand);
            return array[(array.Length)/2];
        }

        //This is a working quicksort algorithm, need to implement the pivot as a random pivot and not the middle of the array
        public static void Quicksort(int[] elements, int left, int right, Random rand)
        {
            int i = left, j = right;
            int pivot = elements[rand.Next(left, right)];

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
                    int tmp = elements[i];
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
        public static void printArray(long[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
