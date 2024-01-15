using System.Xml.Linq;

namespace CSharpAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Developer> developers = new List<Developer>();
            List<OnPayrollDeveloper> onPayrollDevelopers = new List<OnPayrollDeveloper>();
            List<OnContractDeveloper> onContractDevelopers = new List<OnContractDeveloper>();

            Developer developer1 = new OnPayrollDeveloper("Ajay", 3.4f, 600000, 324, "Dharmesh", DateOnly.Parse("23/11/2010"), "gedu");
            Developer developer2 = new OnPayrollDeveloper("Suresh", 3.4f, 6000, 455, "Virat", DateOnly.Parse("12/01/2022"), "Csharp");
            Developer developer3 = new OnContractDeveloper(50, 4000, 666, "mahendra", DateOnly.Parse("20/05/2020"), "Facebook");
            Developer developer4 = new OnContractDeveloper(30, 40000, 866, "Sam", DateOnly.Parse("20/10/2023"), "Google");
            developers.Add(developer1);
            onPayrollDevelopers.Add((OnPayrollDeveloper)developer1);
            developers.Add(developer2);
            onPayrollDevelopers.Add((OnPayrollDeveloper)developer2);
            developers.Add(developer3);
            onContractDevelopers.Add((OnContractDeveloper)developer3);
            developers.Add(developer4);
            onContractDevelopers.Add((OnContractDeveloper)developer4);
            Developer developer = null;
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Enter choice \n" +
                    "1: Add Developer \n" +
                    "2: Display All Devlopers \n" + 
                    "3. Display all records where net salary is more than 20000 \n" +
                    "4. Display all records where DeveloperName contains 'D' \n"+
                    "5. Display all records where JoingDate is in between 01/01/2020 and 01/01/2022 \n" +
                    "6. Display all records where joining Date was 12 Jan 2022 \n" +
                    "7. Exit");
                byte c=0;
                try {
                    c = byte.Parse(Console.ReadLine());
                }catch (Exception e)
                {
                    Console.WriteLine("Enter valid choice");
                    continue;
                }
               

                switch (c)
                {
                    case 1:

                        Console.WriteLine("Which developer do you want to add ? 1: payroll developer 2 : Contract developer");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            try
                            {
                                developer = new OnPayrollDeveloper();
                                onPayrollDevelopers.Add((OnPayrollDeveloper)developer);
                                developers.Add(developer);
                            }
                            catch(Exception e) { 
                                Console.WriteLine(e.Message);
                            }
                        }
                        else if (choice == 2)
                        {
                            try
                            {
                                developer = new OnContractDeveloper();
                                onContractDevelopers.Add((OnContractDeveloper)developer);
                                developers.Add(developer);
                            }catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Employees in Payroll :");
                        foreach (var dev in onPayrollDevelopers)
                        {
                            dev.DisplayDetails();
                        }
                        Console.WriteLine();
                        Console.WriteLine("Employees in Contract :");
                        foreach (var dev in onContractDevelopers)
                        {
                            dev.DisplayDetails();
                        }
                        Console.WriteLine();
                        Console.WriteLine("All Employees:");
                        foreach (var dev in developers)
                        {
                            dev.DisplayDetails();
                        }
                        break;
                    case 3:
                        var devs = from dev in onPayrollDevelopers
                                   where dev.NetSalary > 20000
                                   select dev;
                        Console.WriteLine("Developers with net salary more than 20000 : ");
                        foreach (var dev in devs)
                        {
                            dev.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        var devs1 = from dev in developers
                                    where dev.Name.Contains('D')
                                    select dev;
                        Console.WriteLine("Developers with who has 'D' in name ");
                        foreach (var dev in devs1)
                        {
                            dev.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        var devs2 = from dev in developers
                                    where (dev.JoiningDate > DateOnly.Parse("01/01/2020") && dev.JoiningDate < DateOnly.Parse("01/01/2022"))
                                    select dev;
                        Console.WriteLine("Developers where JoingDate is in between 01/01/2020 and 01/01/2022");
                        foreach (var dev in devs2)
                        {
                            dev.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        var devs3 = from dev in developers
                                    where (dev.JoiningDate == DateOnly.Parse("12/01/2022"))
                                    select dev;
                        Console.WriteLine("Developers where JoingDate is 12 Jan 2022");
                        foreach (var dev in devs3)
                        {
                            dev.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        flag = false;
                        break;
                     default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }
        }
    }
}
