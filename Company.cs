using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Deneme1111
{
    internal class Company
    {
        public string Name { get; set; }
        public Employee[] myArray = new Employee[0];

        public Company(string name)
        {
            Name = name;
        }

        public Employee CreateEmployee()
        {
            Console.Write("Enter Employee Name : ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter Employee Surname : ");
            string employeeSurname = Console.ReadLine();

            Console.Write("Enter Employee Age : ");
            byte age = Convert.ToByte(Console.ReadLine());

            return new Employee(employeeName, employeeSurname, age);
        }

        public void UpdateEmployee(string userName)
        {
            int indexOf = Index(userName);
            if (indexOf != -1)
            {
                Console.WriteLine("1.Update Name");
                Console.WriteLine("2.Update Surname");
                Console.WriteLine("3.Update Age");
                Console.Write("Enter User Vote : ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                switch (userAnswer)
                {
                    case 1:
                        Console.Write("Enter New Name : ");
                        UpdateName(indexOf, Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Enter Surname Name : ");
                        UpdateSurname(indexOf, Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Enter New Name : ");
                        UpdateAge(indexOf, Convert.ToInt32(Console.ReadLine()));
                        break;
                }
            }else
                Console.WriteLine("Bele User Yoxdu");

        }

        public void AddUser(Employee user)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            myArray[myArray.Length - 1] = user;
        }

        public void RemoveUser(string userName)
        {
            int indexOf = Index(userName);
            if (indexOf != -1)
                myArray[indexOf] = null;
            else
                Console.WriteLine("Bele User Yoxdu");
        }

        public void GetUser(string userName)
        {
            int indexOf = Index(userName);
            if (indexOf != -1)
                Console.WriteLine(myArray[indexOf]);
            else
                Console.WriteLine("Bele User Yoxdu");
        }

        public void GetAllUsers()
        {
            foreach (Employee myItem in myArray)
            {
                Console.WriteLine(myItem);
            }
        }

        void UpdateName(int indexOf,string name)
        {
            myArray[indexOf].Name = name;
        }
        
        void UpdateSurname(int indexOf, string newSurname)
        {
            myArray[indexOf].Name = newSurname;
        }

        void UpdateAge(int indexOf, int newAge)
        {
            myArray[indexOf].Age = newAge;
        }
        
        int Index(string userName)
        {
            if(!string.IsNullOrWhiteSpace(userName))
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i].UserName == userName)
                        return i;
                }
            return -1;
        }
    }
}