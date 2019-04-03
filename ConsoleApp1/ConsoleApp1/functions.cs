using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class functions
    {

        public double cnv(double d)
        {
            if (d <= 0) throw new Exception("Значения должны быть > 0");
            return (d * 2.54);
        }

        public bool chet(int n)
        {
            return (n % 2 == 0) ? true : false;
        }

        public int masTest(int[] mas)
        {
            if (mas.Length == 0) throw new Exception("Массив не должен быть пустым");
            int max = mas[0];
                for (int i = 0; i < mas.Length; i++)
                {
                    if (max < mas[i])
                        max = mas[i];
                }
            
          


            return max;

        }




        public int Ost(int l, int m)
        {
            if (m <= 0) throw new Exception("Значения должны быть > 0");

            return (l % m);
        }

    }
}



