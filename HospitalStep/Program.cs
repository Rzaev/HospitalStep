using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStep
{
    class Program
    {

        enum Departments
        {
            Pediatriya = 1, Travmatologiya, Stamotologiya
        }

        static void Main(string[] args)
        {

            Doctor doctor = new Doctor
            {
                Name = "Eli",
                Surname = "ELili",
                Experience = 3
            };

            Doctor doctor1 = new Doctor
            {
                Name = "Ali",
                Surname = "Alili",
                Experience = 4
            };

            Doctor doctor2 = new Doctor
            {
                Name = "John",
                Surname = "Johnlu",
                Experience = 4
            };

            Doctor doctor3 = new Doctor
            {
                Name = "Kamal",
                Surname = "Kamalli",
                Experience = 5
            };

            Doctor doctor4 = new Doctor
            {
                Name = "Ramin",
                Surname = "Raminli",
                Experience = 2
            };

            Doctor doctor5 = new Doctor
            {
                Name = "Reshad",
                Surname = "Reshadli",
                Experience = 6
            };

            Department pediatriya = new Department
            {
                Name = "Pediatriya",
            };

            pediatriya.AddDoctor(ref doctor);
            //pediatriya.Show();
            //Console.WriteLine("********");

            Department travmatologiya = new Department
            {
                Name = "Travmatologiya",
            };
            travmatologiya.AddDoctor(ref doctor1);
            travmatologiya.AddDoctor(ref doctor2);
            //travmatologiya.Show();
            //Console.WriteLine("********");
            Department stamotologiya = new Department
            {
                Name = "Stamotologiya",
            };
            stamotologiya.AddDoctor(ref doctor3);
            stamotologiya.AddDoctor(ref doctor4);
            stamotologiya.AddDoctor(ref doctor5);
            //stamotologiya.Show();
            //Console.WriteLine("********");

            Hospital hospital = new Hospital
            {
                Location = "Baku"
            };
            hospital.AddDepartment(ref pediatriya);
            hospital.AddDepartment(ref travmatologiya);
            hospital.AddDepartment(ref stamotologiya);



            int d = 0, h = 0;
            Doctor doc;

            while (true)
            {
                Console.WriteLine("Enter User");
                User user = new User();
                while (true)
                {
                    Console.WriteLine("1)Pediatriya\n2)Travmatologiya\n3)Stamotologiya\n4)Exit");
                    Console.WriteLine("Select Department or Exit");
                    int n = Convert.ToInt32(Console.ReadLine());
                    while (n<=0 || n>=5)
                    {
                        Console.WriteLine("Select again:");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    if ((Departments)n == Departments.Pediatriya)
                    {
                        pediatriya.ShowDoctors();
                        Console.WriteLine("Select Doctor");
                        d = Convert.ToInt32(Console.ReadLine());
                        while(d!=1)
                        {
                            Console.WriteLine("Select again pls");
                            d = Convert.ToInt32(Console.ReadLine());
                        }
                        doc = pediatriya.getDoctorByNumber(d);
                        Console.WriteLine("Select Hour");
                        h = Convert.ToInt32(Console.ReadLine());
                        while (h <= 0 || h >= 4)
                        {
                            Console.WriteLine("Select again:");
                            h = Convert.ToInt32(Console.ReadLine());
                        }
                        if (doc.IsFull[h - 1] == true)
                        {
                            Console.WriteLine("This doctor is full at that time range");
                            // break;
                            continue;
                        }
                        else
                        {
                            doc.IsFull[h - 1] = true;
                            Console.WriteLine("Succesfully");
                        }
                    }
                    else if ((Departments)n == Departments.Travmatologiya)
                    {
                        travmatologiya.ShowDoctors();
                        Console.WriteLine("Select Doctor");
                        d = Convert.ToInt32(Console.ReadLine());
                        while (d != 2 && d!=3)
                        {
                            Console.WriteLine("Select again pls");
                            d = Convert.ToInt32(Console.ReadLine());
                        }
                        doc = travmatologiya.getDoctorByNumber(d);
                        Console.WriteLine("Select Hour");
                        h = Convert.ToInt32(Console.ReadLine());
                        while (h <= 0 || h >= 4)
                        {
                            Console.WriteLine("Select again:");
                            h = Convert.ToInt32(Console.ReadLine());
                        }
                        if (doc.IsFull[h - 1] == true)
                        {
                            Console.WriteLine("This doctor is full at that time range");
                            //break;
                            continue;
                        }
                        else
                        {
                            doc.IsFull[h - 1] = true;
                            Console.WriteLine("Succesfully");
                        }
                    }
                    else if ((Departments)n == Departments.Stamotologiya)
                    {
                        stamotologiya.ShowDoctors();
                        Console.WriteLine("Select Doctor");
                        d = Convert.ToInt32(Console.ReadLine());
                        while (d != 4 && d!=5 && d!=6)
                        {
                            Console.WriteLine("Select again pls");
                            d = Convert.ToInt32(Console.ReadLine());
                        }
                        doc = stamotologiya.getDoctorByNumber(d);
                        Console.WriteLine("Select Hour");
                        h = Convert.ToInt32(Console.ReadLine());
                        while (h <= 0 || h >= 4)
                        {
                            Console.WriteLine("Select again:");
                            h = Convert.ToInt32(Console.ReadLine());
                        }
                        if (doc.IsFull[h - 1] == true)
                        {
                            Console.WriteLine("This doctor is full at that time range");
                            //break;
                            continue;
                        }
                        else
                        {
                            doc.IsFull[h - 1] = true;
                            Console.WriteLine("Succesfully");
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }


        }
    }
}
