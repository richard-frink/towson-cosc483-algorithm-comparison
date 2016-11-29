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
            int[] test1 = arrayCreator.newArray(10000, 10000);

            //here will be tons of running of all of the algorithms and outputs of times and such


            //example os stopwatch usage
            stopwatch.Start();
            DetSelection(test1, 117);
            stopwatch.Stop();
            lastTestElapsed = stopwatch.ElapsedMilliseconds;

        }

        //This is the Deterministic version of Selection sort
        public static void DetSelection(int[] array, int key)
        {

        }

        //This is the Randomized version of Selection sort
        public static void RandSelection(int[] array, int key)
        {

        }

        //This is where we use randomized quicksort to do the sorting and then select the element we need
        public static void RandQuickSelect(int[] array, int key)
        {
            
        }
    }
}
