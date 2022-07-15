class program
{ 
public const int IsFullTime = 1;
public const int IsPartTime = 2;
public const int EmpRatPerHr = 20;
    static void Main(string[] args)
    {


        int empHrs = 0;
        int EmpWage = 0;
        Random random = new Random();

        int EmpCheck = random.Next(0, 3);
        switch (EmpCheck)
        {
            case IsPartTime: //IsPartTime=2//
                empHrs = 4;
                break;
            case IsFullTime: //IsFullTime=1//
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }
        EmpWage = empHrs * EmpRatPerHr;
        Console.WriteLine("Employees wage is: " + EmpWage);
    }
    }