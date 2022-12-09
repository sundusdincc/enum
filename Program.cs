internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine((int)WeekDays.Saturday);

        Console.WriteLine(WeekDays.Friday); //output: Friday 
        int day = (int)WeekDays.Friday; // enum to int conversion
        Console.WriteLine(day); //output: 4

        var wd = (WeekDays)5; // int to enum conversion
        Console.WriteLine(wd);//output: Saturday 


        Console.WriteLine((int)Categories.Food);
        int art = (int)Categories.Arts;
        Console.WriteLine(art);
        int otmv = (int)Categories.Automotive;
        Console.WriteLine(otmv);

        Perimeter a1 = new Perimeter();
        a1.peri(3, Perimeter.shapes.circle);
        a1.peri(4, Perimeter.shapes.square);

        Console.WriteLine("Enter 0 or 1 to know the " +
                               "state of electric switch!");

        byte i = Convert.ToByte(Console.ReadLine());

        if (i == (byte)Button.OFF)
        {

            Console.WriteLine("The electric switch is Off");
        }

        else if (i == (byte)Button.ON)
        {
            Console.WriteLine("The electric switch is ON");
        }
        else
        {
            Console.WriteLine("byte cannot hold such" +
                                      " large value");
        }

        //Create a collection to store employees
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Name = "Anurag", Gender = 0 });
        empList.Add(new Employee() { Name = "Pranaya", Gender = 1 });
        empList.Add(new Employee() { Name = "Priyanka", Gender = 2 });
        empList.Add(new Employee() { Name = "Sambit", Gender = 3 });

        //Loop through each employees and print the Name and Gender
        foreach (var emp in empList)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", emp.Name, GetGender(emp.Gender));
        }

         Genderr gender = (Genderr)Season.Winter;
         Console.WriteLine(gender);

       
    }

    public static string GetGender(int gender)
    {
        // The switch here is less readable because of these integral numbers
        switch (gender)
        {
            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid Data for Gender";
        }
    }
}

public enum Genderr : int
    {
        Unknown = 1,
        Male = 2,
        Female = 3
    }
    public enum Season : int
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum Categories
{
    Electronics,    // 0
    Food,           // 1
    Automotive = 6, // 6
    Arts,           // 7
    BeautyCare,     // 8
    Fashion         // 9
}

class Perimeter
{

    // declaring enum
    public enum shapes
    {
        circle,
        square
    }

    public void peri(int val, shapes s1)
    {

        // checking for shape to be circle
        if (s1 == 0)
        {

            // Output the circumference
            Console.WriteLine("Circumference of the circle is " +
                                                  2 * 3.14 * val);
        }

        else
        {

            // else output the perimeter of the square
            Console.WriteLine("Perimeter of the square is " +
                                                     4 * val);
        }
    }
}

enum Button : byte
{

    // OFF denotes the Button is
    // switched Off... with value 0
    OFF,

    // ON denotes the Button is
    // switched on.. with value 1
    ON

}

public class Employee
{
    public string Name { get; set; }
    public int Gender { get; set; }
}

 