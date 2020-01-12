using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorBaza
{
    class Program
    {
        public static int ConvertToBase10(int nr,int bazainitiala)
        {
            int s = 0;
            int i = 0;
            while (nr > 0)
            {
                s = s + (nr % 10) *(Convert.ToInt32( Math.Pow(bazainitiala, i)));
                nr = nr / 10;
                i++;
            }
            return s;
        }
        public static void ConvertFromBase10(int nr,int bazafinala)
        {
            int i = 0;
            int []v=new int[100];
            while (nr > 0)
            {
                v[i] = nr % bazafinala;
                i++;
                nr = nr / bazafinala;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.Write(v[j]);
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bazainitiala= int.Parse(Console.ReadLine());
            int bazafinala= int.Parse(Console.ReadLine());
            if(bazainitiala>bazafinala)
            {
                if (bazainitiala != 10)
                {
                    int nr = ConvertToBase10(n, bazainitiala);
                    ConvertFromBase10(nr, bazafinala);
                }
                else
                    ConvertFromBase10(n,bazafinala);
            }
            else
            {
                if(bazafinala!=10)
                {
                    int nr = ConvertToBase10(n, bazainitiala);
                    ConvertFromBase10(nr, bazafinala);
                }
                else
                Console.WriteLine(ConvertToBase10(n, bazainitiala));
            }
            Console.ReadKey();

        }
    }
}
