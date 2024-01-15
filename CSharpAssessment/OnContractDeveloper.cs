using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class OnContractDeveloper : Developer
    {
        public int Duration { get; set; }
        public double Charges_Per_Day { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Duration is : {this.Duration}");
            Console.WriteLine($"Charges per Day is : {this.Charges_Per_Day}");
        }
        public OnContractDeveloper() : base()
        {
            Console.WriteLine("Enter Duration");
            this.Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Charges per day");
            this.Charges_Per_Day = double.Parse(Console.ReadLine());
        }

        public OnContractDeveloper(int duration, double charges_Per_Day, int id, string name, DateOnly joiningDate, string project_Assigned) : base(id, name, joiningDate, project_Assigned)
        {
            Duration = duration;
            Charges_Per_Day = charges_Per_Day;
        }
    }
}
