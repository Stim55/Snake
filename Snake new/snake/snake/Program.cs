using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 5;
            char sym1 = 'O';

            Draw(x1, y1, sym1);

            int x2 = 7;
            int y2 = 3;
            char sym2 = '#';

            Draw(x2, y2, sym2);


            Console.ReadLine();

        }

        static void Draw(int x, int y, char sym)
    
    {
     Console.SetCursorPosition(a, b);
            Console.Write(sym);
        }


}
