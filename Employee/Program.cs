using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont;
            int ch;
            register regtr = new register();
            login signin = new login();
            do
            {
                Console.WriteLine("Type 1 for registration and 2 for Login : ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        regtr.reg();
                        break;
                    case 2:
                        signin.log();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press 'c' to add more employee...");
                cont = char.Parse(Console.ReadLine());
                if(cont != 'c')
                {
                    break;
                }
            } while (cont == 'c');
        }
    }
}
