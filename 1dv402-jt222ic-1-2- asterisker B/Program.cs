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
                Console.Write("Ange det udda antalet asterisker <max 79> i triangelns bas: ");    ///anger variabeln
                amount = ReadOddbyte();                                  //// förstår inte varför det fungerar så
                RenderTriangle(amount);                                           /// refererar till en metod 
                //amount = byte.Parse(Console.ReadLine());
                
                //if (amount<= 79)
                //{ RenderTriangle(amount); }
                //if  (amount > 79)
                //{ ReadOddbyte(amount); }
                //if (amount % 1 == 0)
                if (amount > 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("tryck tangent för att forsätta - ESC avslutar");         /// avslutning av metods räkning
                    Console.ResetColor();

                }
                

            }

            

            while (Console.ReadKey(true).Key != ConsoleKey.Escape);   /// escape eller köra vidare med konsolen 

        }

        static byte ReadOddbyte()
        {
            byte amount;
            try
            {
                


                Console.ResetColor();
                amount = byte.Parse(Console.ReadLine());     //// skriva in icke udda tal 
                                                           //// execption kastar sig till argument
                                                           /// catchar andra fel utan tal
                if (amount % 2 == 0)
                { throw new ArgumentException(); }
                if (amount>79)
                { throw new ArgumentException(); }
                
                    return amount;
            }
            catch (ArgumentException)                    //// fångar fel från argumentationer
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! den inmatade värden är inte ett udda heltal mellan 1 och 79.");
                Console.ResetColor();
                return 0;
            }
            catch 
                
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel! den inmatade värden är inte ett udda heltal mellan 1 och 79. ");
                Console.ResetColor();
            return 0;
            }
        }     

        
       static void RenderTriangle(byte cols)
        {
            
           for (int i = 1; i <= cols; i++)      ///höjd               ////Antal nr skrivs in = cols
           {

               for (int j = i; j <= cols; j++)    ///pusha stjärnorna på toppen      /////TRiangelns metods räkning
               {
                   Console.Write("  ");                ///// mellanrum

               }

               for (int k = 1; k <= 2 * i - 1; k++)               //// basräkning
               {
                   Console.Write("*" + " ");
               }
               Console.WriteLine();
           }



           
                   

       }
    }
}
