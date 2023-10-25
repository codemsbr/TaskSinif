using System.Security;

namespace Deneme1111
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter User Company Name : ");
            Company userCompany = new Company(Console.ReadLine());
            Console.Clear();

            bool controller = true;
            do { 
                Console.WriteLine("1.Create a company");
                Console.WriteLine("2.Create an employee");
                Console.WriteLine("3.Delete employee");
                Console.WriteLine("4.Update employee");
                Console.WriteLine("5.See all employees");
                Console.WriteLine("6.See employee");
                Console.WriteLine("7.Exit");
                Console.Write("Enter User Vote : ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                switch (userAnswer)
                {
                    case 1:
                        Console.Write("Enter New User Company Name : ");
                        userCompany = new Company(Console.ReadLine());
                        break;

                    case 2:
                        Employee userEmployee = userCompany.CreateEmployee();
                        userCompany.AddUser(userEmployee);
                        break;

                    case 3:
                        Console.Write("Enter UserName : ");
                        userCompany.RemoveUser(Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Enter UserName : ");
                        userCompany.UpdateEmployee(Console.ReadLine());
                        break;

                    case 5:
                        userCompany.GetAllUsers();
                        break;

                    case 6:
                        Console.Write("Enter UserName : ");
                        userCompany.GetUser(Console.ReadLine());
                        break;
                    case 7:
                        controller = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis Secim");
                        break;
                }
            }while(controller);

        }
    }
}