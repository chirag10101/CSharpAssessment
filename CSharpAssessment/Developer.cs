using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly JoiningDate { get; set; }
        public string Project_Assigned { get; set; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID is : {this.Id}");
            Console.WriteLine($"Developer Name is : {this.Name}");
            Console.WriteLine($"Joining Date is : {this.JoiningDate}");
            Console.WriteLine($"Project Assigned is : {this.Project_Assigned}");
        }

        public Developer()
        {
            Console.WriteLine("Enter Id");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Developer Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Joining Date");
            this.JoiningDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Project Assigned");
            this.Project_Assigned = Console.ReadLine();
        }

        public Developer(int id, string name, DateOnly joiningDate, string project_Assigned)
        {
            Id = id;
            Name = name;
            JoiningDate = joiningDate;
            Project_Assigned = project_Assigned;
        }
    }
}
