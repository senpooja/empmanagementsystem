// See https://aka.ms/new-console-template for more information

Console.WriteLine("welcome to Employee Management app");
int IsFullTime = 1;
int IsPartTime = 2;
int EmpRatePerhr = 20;
int empHrs = 0;
int empWage = 0;

Random random = new Random();
int EmpCheck = random.Next(0, 2);
if (EmpCheck == IsFullTime)
{
    empHrs = 8;
}
else if (EmpCheck == IsPartTime)
{
    empHrs = 4;
}
else
{
    empHrs = 0;
}
empWage = empHrs * EmpRatePerhr;
Console.WriteLine("Emp Wage :" + empWage);