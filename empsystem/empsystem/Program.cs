Console.WriteLine("welcome to Employee Management app");
int IsFullTime = 1;
int EmpRatePerhr = 20;
int empHrs = 0;
int empWage = 0;

Random random = new Random();
int EmpCheck = random.Next(0, 2);
if (EmpCheck == IsFullTime)
{
    empHrs = 8;
}
else
{
    empHrs = 0;
}
empWage = empHrs * EmpRatePerhr;
Console.WriteLine("Emp Wage :" + empWage);