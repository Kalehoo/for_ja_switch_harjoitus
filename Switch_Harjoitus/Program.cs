using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {

            double initialvalue = 12.00;

            for (int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        initialvalue = initialvalue + i;
                        Console.WriteLine(initialvalue);
                        break;
                    case 2:
                        initialvalue = initialvalue * i;
                        Console.WriteLine(initialvalue);
                        break;
                    case 3:
                        initialvalue = initialvalue / i;
                        Console.WriteLine(initialvalue);
                        break;
                    case 4:
                        initialvalue = initialvalue - i;
                        Console.WriteLine(initialvalue);
                        break;




                }



            }

                Console.WriteLine($"\nLopullinen initialvalue on: {initialvalue}");
                Console.ReadKey();

        }
    }
}
