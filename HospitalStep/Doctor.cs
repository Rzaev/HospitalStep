using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStep
{
    class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public int Id { get; set; }
        public static int Doctor_Id { get; set; } = 0;

        public bool[] IsFull { get; set; } = { false, false, false };



        public Doctor()
        {
            Id = ++Doctor_Id;
        }


        public void Hour()
        {
            if(IsFull[0])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("09:00-11:00");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("09:00-11:00");
            }
            Console.ResetColor();

            if (IsFull[1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("12:00-14:00");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("12:00-14:00");
            }
            Console.ResetColor();

            if (IsFull[2])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("15:00-17:00");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("15:00-17:00");
            }
            Console.ResetColor();
        }

        public void Show()
        {
            Console.WriteLine("****Doctor****");
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"Experience:{Experience}");
            Hour();
        }
    }
}
