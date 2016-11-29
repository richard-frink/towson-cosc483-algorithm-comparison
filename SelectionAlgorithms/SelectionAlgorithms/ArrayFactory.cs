using System;

namespace SelectionAlgorithms
{
    class ArrayFactory
    {
        Random rand;

        public ArrayFactory()
        {
            rand = new Random();
        }

        public IComparable[] newArray(int size, int max)
        {
            IComparable[] temp = new IComparable[size];
            for(int i = 0; i < size; i++)
            {
                temp[i] = rand.Next(max + 1); //number from 0 to the specified number
            }
            return temp;
        }
    }
}
