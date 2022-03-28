public class MyClass
{
    static void Main(string[] args)
    {
        string[] dates = {"3/29/2022","3/29/2001", "1/15/2007", "10/31/1995"};
        
        for(int i = 0; i < dates.Length; i++)
        {
            System.Console.WriteLine($"\t\tIteration {i+1}");
            System.Console.WriteLine($"ComputeAge1: {ComputeAge1(dates[i])}"); 
            System.Console.WriteLine($"ComputeAge2: {ComputeAge2(dates[i])}"); 
            System.Console.WriteLine("==========================================");
        }  
    }
    static int GetAge()
    {
        System.Console.Write("Enter your age: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // Date format: MM/DD/YYYY
    //              04/25/2001
    static int ComputeAge1(string dateOfBirth)
    {
        // 1. Get current date
        var currentDate = DateTime.Now;
        var dateSplit = dateOfBirth.Split("/");

        // dateSplit = 3 things: [month] [day] [year]
        //                       [  0  ] [ 1 ] [ 2  ]

        // 2. Convert dates to some #
        int birthYear = Convert.ToInt32(dateSplit[2]);
        int birthMonth = Convert.ToInt32(dateSplit[0]);
        int birthDay = Convert.ToInt32(dateSplit[1]);
        int currentYear = currentDate.Year;
        int currentMonth = currentDate.Month;
        int currentDay = currentDate.Day;

        int age = currentDate.Year - birthYear;


        // current month = 3
        // birth month = 3

        if(currentMonth > birthMonth && currentYear == birthYear)
        {
            return age-=1;
        }
        else if(currentMonth <= birthMonth)
        {
            // current day = 28
            // birth day = 29
            if(birthDay >= currentDay)
            {
                return age-=1;
            }
            else
            {
                return age;
            }
        }

        return age;
    }

    
    static int ComputeAge2(string dateOfBirth)
    {
                // 1. Get current date
            var currentDate = DateTime.Now;
            var dateSplit = dateOfBirth.Split("/");

            // dateSplit = 3 things: [month] [day] [year]
            //                       [  0  ] [ 1 ] [ 2  ]

            // 2. Convert dates to some #
            int birthYear = Convert.ToInt32(dateSplit[2]);
            int birthMonth = Convert.ToInt32(dateSplit[0]);
            int birthDay = Convert.ToInt32(dateSplit[1]);
            int currentYear = currentDate.Year;
            int currentMonth = currentDate.Month;
            int currentDay = currentDate.Day;

            int age = currentDate.Year - birthYear;

            if(currentMonth > birthMonth)
            {
                return age;
            }
            else if(currentDay > birthDay)
            {
                return age;
            }
            else
            {
                return age-=1;
            }
    }
}
