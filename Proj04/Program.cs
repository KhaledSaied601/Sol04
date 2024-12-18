using System.Text;

namespace Proj04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13 - Write a program to allow the user to enter a string and print the REVERSE of it

            // Console.WriteLine("Enter any string to reverse it");

            // string text =  Console.ReadLine();

            //StringBuilder reversedText = new StringBuilder();

            //for (int i = text.Length-1; i>=0; i --)
            // {
            //     reversedText.Append(text[i]);
            // }


            // Console.WriteLine(reversedText); 


            #endregion


            #region 14- Write a program to allow the user to enter int and print the REVERSED of it.



            //string flag ;

            //bool bol = false;

            //int number;

            //do
            //{
            //    Console.WriteLine("Enter any nubers to reverse it");

            //    flag = Console.ReadLine();

            //    bol = int.TryParse(flag, out number);

            //}
            //while (bol==false);


            //string reversedNumber = new string(flag.Reverse().ToArray());

            //Console.WriteLine(reversedNumber);



            #endregion




            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.





            //int num1;
            //bool bol1 = false;

            //int num2;
            //bool bol2 = false;



            //do
            //{
            //    Console.WriteLine("Enter Start Number for Range to get Prime numbers between ");

            //    bol1 = int.TryParse(Console.ReadLine(), out num1);
            //}
            //while (bol1 == false);

            //do
            //{
            //    Console.WriteLine("Enter End Number for Range to get Prime numbers between ");

            //    bol2 = int.TryParse(Console.ReadLine(), out num2);
            //}
            //while (bol2 == false);


            //for (int num = num1; num <= num2; num++)
            //{
            //    if (num <= 1)
            //    {
            //        continue;
            //    }

            //    bool isPrime = true;
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;

            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}







            #endregion





            #region 16- Write a program in C# Sharp to convert a decimal number into binary without using an array.



            //Console.Write("Enter a number: ");

            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binaryNumber = "";

            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;
            //    binaryNumber = remainder + binaryNumber;
            //    decimalNumber /= 2;
            //}


            //Console.WriteLine($"Binary Number of {decimalNumber} is: {binaryNumber}");





            #endregion



            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.Write("Enter x1: ");

            //double x1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y1: "); 
            //double y1 = double.Parse(Console.ReadLine());   


            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y2: "); 
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());

            //Console.Write("Enter y3: "); 
            //double y3 = double.Parse(Console.ReadLine());


            //double slope1 = (y2 - y1) / (x2 - x1); 
            //double slope2 = (y3 - y2) / (x3 - x2);

            //if (slope1 == slope2) 
            //{ 
            //    Console.WriteLine("The points lie on a single straight line"); 
            //}
            //else 
            //{ 
            //    Console.WriteLine("The points do not lie on a single straight line"); 
            //}


            #endregion



            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            // -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            // - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            // - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            // - If the worker takes more than 5 hours, they are required to leave the company.
            // To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            int time;
            bool bol = false;
            do
            {
                Console.WriteLine("Input Time Taken for the task");
                bol = int.TryParse(Console.ReadLine(), out time);
            }
            while (bol == false);


            if ( time >=2 && time<=3) Console.WriteLine("highly efficient");
           else if ( time >3 && time<=4) Console.WriteLine(" they are instructed to increase their speed");
           else  if ( time >4 && time<=5) Console.WriteLine("they are provided with training to enhance their speed");
           else if ( time > 5) Console.WriteLine("they are required to leave the company");


            #endregion
        }
    }
}
