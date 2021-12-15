using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int outronum = 5;


            Console.WriteLine(" Quanto é " + numero + "+" + outronum + "?");
            
            int resposta = Convert.ToInt32(Console.ReadLine());

            if(resposta == 15)
            {
                Console.WriteLine("Parabens Você Acertou!!");
            }
            else
            {
                Console.WriteLine(" Tente Novamente !!");
            }

        }
    }
}
