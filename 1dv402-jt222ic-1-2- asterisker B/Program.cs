using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ic_1_2__asterisker_B
{
    class Program
    {
        static void Main(string[] args)
        {
             
            do
            {
                byte amount;
                Console.Write("Ange det udda antalet asterisker <max 79> i triangelns bas: ");
                amount = byte.Parse(Console.ReadLine());
           
                

                Console.BackgroundColor = ConsoleColor.DarkGreen;                                  /// avslutad text  
                Console.WriteLine("tryck tangent för att forsätta - ESC avslutar");           /// måste stoppas direkt 
                                                                                              /// när jag skriver in värden som är
                                                                                              /// över 79
                Console.ResetColor();

            }

            

            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

      

        static void ReadOddByte(byte oddOrEven)
        {
           

  
            try
            {
             if ( oddOrEven > 79)
	       {                                  
        throw new ArgumentException("Number is not allowed to be over 79");
	        } 
             else if ( oddOrEven % 2 == 0)
             {
                 Console.WriteLine("Hey babariba");

             }

            }
            catch(Exception e)                                                                          /// här ska jag använda mig av 
                                                                                           /// try catch formen
                                                                                           /// för att bestämma om värden är
                                                                                           /// udda eller lika, fel meddelandet
                                                                                           /// ska uppstå. 
            {
                Console.WriteLine("e.Message"); 
                    
            }
            return;
        }
       static void RenderTriangle(byte cols)
        {
            
           for (int i = 1; i <= cols; i++)                  ////Antal nr skrivs in = cols
           {

               for (int j = i; j <= cols; j++)         /////TRiangelns metods räkning
               {
                   Console.Write("  ");                ///// mellanrum

               }

               for (int k = 1; k <= 2 * i - 1; k++)
               {
                   Console.Write("*" + " ");
               }
               Console.WriteLine();
           }
           



           
                   

       }
    }
}
