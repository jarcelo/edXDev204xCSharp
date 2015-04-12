using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int colCount;
            for (colCount = 1; colCount <= 8; colCount++)
            {
                for (int rowCount = 1; rowCount <= 8; rowCount++)
                {
                    bool colIsOdd = !(colCount % 2 == 0);
                    bool rowIsOdd = !(rowCount%2 == 0);

                    switch (colIsOdd)
                    {
                        case true:
                            if (rowIsOdd)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                            break;

                        case false:
                            if (rowIsOdd)
                            {
                                Console.Write("O");
                            }
                            else
                            {
                                Console.Write("X");
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

/*
class Program
{
    static void Main(string[] args)
    {
        char[] xo = new char[] { 'X', 'O' };

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                // The key is the
                // (i+j)%2 as an index
                // and the xo array;
                // if i+j are even that statement will return with 0
                // so xo[0] --> X
                // if odd 
                // xo[1] --> O
                Console.Write(xo[(i + j) % 2]);
            }
            Console.WriteLine();
        }

    }
}
*/
