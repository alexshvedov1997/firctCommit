using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = { 3, 8, 9, 3, 4, 0, 1, 23 };
            QuickSort(mass, 0, 7);
            foreach (int p in mass) Console.WriteLine(p);

        }
        static void QuickSort(int[] mass, int first, int last) {
            int f = first, l = last;
            int count;
            int mid = mass[(f + l) / 2];
            do
            {
                while (mass[f] > mid) f++;
                while (mass[l] < mid) l--;
                if (f <= l)
                {
                    count = mass[f];
                    mass[f] = mass[l];
                    mass[l] = count;
                    f++;
                    l--;
                }

            } while (f < l);
            if (first < l) QuickSort(mass, first, l);
            if (f < last) QuickSort(mass, f, last);

        }
    }
}
