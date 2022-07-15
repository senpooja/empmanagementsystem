class program
{
    public const int IsPartTime = 1;
    public const int IsfullTime = 2;
    public const int EmpRatePerHr = 20;
    public const int NumOfWorkingDays = 2;
    public const int MaxHrsInMonth = 10;
    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MaxHrsInMonth && totalWorkingDays < NumOfWorkingDays)
        {
            totalWorkingDays++;
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
            totalEmpHrs += empHrs;

            Console.WriteLine("Days :" + " Emp Hrs : " + empHrs);
        }
        int totalEmpWage = totalEmpHrs * EmpRatePerHr;
        Console.WriteLine("Total emp Wage : " + totalEmpWage);
    }
}
