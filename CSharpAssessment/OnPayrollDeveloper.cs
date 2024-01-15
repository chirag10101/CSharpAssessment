

namespace CSharpAssessment
{
    internal class OnPayrollDeveloper : Developer
    {
        public string DepartmentManager { get; set; }
        public double NetSalary { get; set; }
        public float ExpInYears { get; set; }
        public double BasicSalary { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double LTA { get; set; }
        public double PF { get; set; }

        public OnPayrollDeveloper() : base()
        {
            Console.WriteLine("Enter Department Manager");
            this.DepartmentManager = Console.ReadLine();
            Console.WriteLine("Enter Exp in Years");
            this.ExpInYears = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Basic Salary");
            this.BasicSalary = double.Parse(Console.ReadLine());
            CalculateNetSalary();
        }
        public OnPayrollDeveloper(string departmentManager, float expInYears, double basicSalary, int id, string name, DateOnly joiningDate, string project_Assigned) : base(id, name, joiningDate, project_Assigned)
        {
            DepartmentManager = departmentManager;
            ExpInYears = expInYears;
            BasicSalary = basicSalary;
            CalculateNetSalary();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Dept Manager is : {this.DepartmentManager}");
            Console.WriteLine($"Basic Salary is : {this.BasicSalary}");
            Console.WriteLine($"Exp in years is : {this.ExpInYears}");
            Console.WriteLine($"DA is : {this.DA}");
            Console.WriteLine($"HRA is : {this.HRA}");
            Console.WriteLine($"LTA is : {this.LTA}");
            Console.WriteLine($"PF is : {this.PF}");
            Console.WriteLine($"Net Salary is : {this.NetSalary}");
        }
        public void CalculateNetSalary()
        {
            if (this.ExpInYears > 10)
            {
                this.DA = this.BasicSalary * (0.1);
                this.HRA = this.BasicSalary * (0.085);
                this.LTA = this.BasicSalary * (0.080);
                this.PF = 6200;
                this.NetSalary = this.DA + this.HRA + this.LTA + this.BasicSalary - this.PF;
            }
            else if (this.ExpInYears > 7)
            {
                this.DA = this.BasicSalary * (0.07);
                this.HRA = this.BasicSalary * (0.065);
                this.LTA = this.BasicSalary * (0.070);
                this.PF = 4100;
                this.NetSalary = this.DA + this.HRA + this.PF + this.LTA + this.BasicSalary - this.PF;
            }
            else if (this.ExpInYears > 5)
            {
                this.DA = this.BasicSalary * (0.041);
                this.HRA = this.BasicSalary * (0.038);
                this.LTA = this.BasicSalary * (0.060);
                this.PF = 1800;
                this.NetSalary = this.DA + this.HRA + this.LTA + this.BasicSalary - this.PF;
            }
            else
            {
                this.DA = this.BasicSalary * (0.019);
                this.HRA = this.BasicSalary * (0.020);
                this.LTA = this.BasicSalary * (0.050);
                this.PF = 1200;
                this.NetSalary = this.DA + this.HRA + this.PF + this.BasicSalary;
            }
        }
    }
}
