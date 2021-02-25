using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStep
{
    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int Department_Id { get; set; } = 0;

        public Doctor[] Doctors { get; set; }
        public int DoctorCount { get; set; } = 0;


        public Department()
        {
            Id = ++Department_Id;
        }

        public void AddDoctor(ref Doctor doctor)
        {
            Doctor[] temp = new Doctor[++DoctorCount];
            if (Doctors != null)
            {
                Doctors.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = doctor;
            Doctors = temp;
        }

        public void ShowDoctors()
        {
            if (Doctors != null)
            {
                foreach (var item in Doctors)
                {
                    item.Show();
                }
            }
        }

        public Doctor getDoctorByNumber(int number)
        {
            if(Doctors !=null)
            {
                foreach (var item in Doctors)
                {
                    if(item.Id==number)
                    {
                        return item;
                    }
                }
            }
            return null;
        }


        public void Show()
        {
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Name:{Name}");
            ShowDoctors();
        }

       

    }
}
