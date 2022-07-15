
class program
{
    public const int IsPartTime = 1;
    public const int IsfullTime = 2;
    public const int EmpRatePerHr = 20;
    public const int NumOfWorkingDays = 20;
    static void Main(string[] args)
    {
        int empHrs = 0, empwage = 0, totalEmpWage = 0;
        for (int day = 0; day < NumOfWorkingDays; day++)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    empHrs = 4;
                    break;
                case IsfullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;


            }
            empwage = empHrs * EmpRatePerHr;
            totalEmpWage += empwage;
            Console.WriteLine("Emp Wage : " + empwage);
        }
        Console.WriteLine("Total emp Wage : " + totalEmpWage);
    }
}