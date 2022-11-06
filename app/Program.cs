using System;

namespace DormitoryManagement
{

    class Program
    {
        static void Main()
        {

            List<Human> humans = setHumans(12);
            Dormitory dormitory = new Dormitory();
            List<Human> forEmployee = new List<Human>();
            List<Director> directorlist = new List<Director>();
            List<AdminOffice> adminofficelist = new List<AdminOffice>();
            List<BedChanger> bedchangerlist = new List<BedChanger>();
            Console.WriteLine($"Welcome to {dormitory.Name}");
            Console.WriteLine($"{dormitory.Address}/{dormitory.Phone}");

            Random rnd = new Random();


            // for (int i = 1; i < 6; i++)
            // {
            //     int salary = rnd.Next(1, 1999);
            //     if(rnd.nex)
            //     Employee newEmp = new Employee(salary, humans[i].Name, humans[i].Phone, "");
            //     forEmployee.Add(newEmp);
            // }    

            int len = humans.Count;
            Console.WriteLine("Employee List:");
            for (int i = 0; i < humans.Count / 2; i++)
            {
                if (i == 0)
                {
                    directorlist.Add(new Director(rnd.Next(1, 1000), humans[0].Name, humans[0].Phone, "Director"));
                }
                else
                {
                    dormitory.hireEmployee(humans[i]);
                }
                Console.WriteLine(humans[i].Name);
            }




        }
        static List<Human> setHumans(int qty)
        {
            List<Human> humans = new List<Human>();
            for (int i = 0; i < qty / 2; i++)
            {
                string name = "Betty" + (i + 1).ToString();
                string phone = "12312434" + (i + 1).ToString();
                Human humannew = new Human(name, phone);
                humans.Add(humannew);
            }

            for (int i = qty / 2; i < qty; i++)
            {
                string name = "Michael" + (i + 1).ToString();
                string phone = "78945234" + (i + 1).ToString();
                Human humannew = new Human(name, phone);
                humans.Add(humannew);
            }
            return humans;
        }
    }
}
