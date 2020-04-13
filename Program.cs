using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.NetAssignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- ASSIGNMENT 1 ----------");
            //1- Creat a struct Name is as BankAccount which has 2 fields
            //Type of Account(Enum)
            //Deposit Amount(Float)
            //2- Create an Enum -> 3 types
            //Checking
            //Saving
            //Line of credit
            // Struct BankAccount with Enum typeOfAccount
            BankAccount myBankAcc1 = new BankAccount(typeOfAccount.Saving, 500.01f);
            Console.WriteLine("My Bank Account has " + myBankAcc1.depositAmount);

            //3- Create an anonymous type that contains 3 fields and name it shape :
            //Color
            //Size
            //Model 
            var Shape = new
            {
                color = "red",
                size = "large",
                model = "square"
            };
            Console.WriteLine("My anonymous shape's color is " + Shape.color);

            //4- Explain difference between call by value and call by reference by an example

            /* When myBankAcc1 is being copied over to myBankAccount2, 
             * the information carries over but myBankAcc2 is a new object allocated with its own memory space.
             */
            BankAccount myBankAcc2 = myBankAcc1;
            myBankAcc2.depositAmount = 100.00f;
            Console.WriteLine("My Acc1 has: " + myBankAcc1.depositAmount);
            Console.WriteLine("My Acc2 has: " + myBankAcc2.depositAmount);

            /* When myCar1 is being copied over to myCar2,
             * no information has been carried over other than the reference pointer.
             * myCar2 is not a new object Car. It is still using the object created by myCar1.
             */
            Car myCar1 = new Car();
            myCar1.make = "honda";
            Console.WriteLine("My first car's make is: " + myCar1.make);
            Car myCar2 = myCar1; 
            myCar2.make = "toyota";
            Console.WriteLine("My first car's make after changing myCar2 is " + myCar1.make);
            Console.WriteLine("My second car's make is: " + myCar2.make);

            //5- Write a method to take 3 arguments and print them by using interpolation
            Console.WriteLine(stringInterpolation("Ap", "pl", "e"));

            //6- Write a method to calculate how many hours we have until next year.
            Console.WriteLine(hoursNowTillNextYear() + " hours until next year.");

            //7- using multi line to write your first name, last name and email
            Console.WriteLine(@"Chun Fei
Johnny
Tiu
john@gmail.com");

            //8- write your name and email in one String
            Console.WriteLine("Johnnyjohn@gmail.com");

            //9- what is the difference between var and dynamic
            /* Var type values are initialized during compile time, hence their type must be declared upon assigning a variable.
             * Dynamic type values are initialized during run time, they do not need their type declared before.
             */
            // var x;
            var x = 1;
            dynamic y;

            //10- send shape anonymous type that you created in 3 into a method to print them by using interpolation
            printShape(Shape);

            Console.WriteLine(@"
--------- ASSIGNMENT 2 ----------");

            //1-By using stringbuilder Append a sentence by using your fname,lastname and email
            StringBuilder sb = new StringBuilder("My name is John", 50);
            sb.Append(" and my email is");
            sb.Append(" john@gmail.com");
            Console.WriteLine(sb);

            //2-Create 2 partial class (optional structure)
            Partial p = new Partial();
            Console.WriteLine(p.i + p.y);

            //3- Use static methods and static fields in a static class to calculate the area of a circle.
            Console.WriteLine( "Area of a circle with a radius of 2 is " + circleArea.calcArea(2));

            //4-Create a 2D JaggedArray and 3D JaggedArray with optioanl type and fill them with values and print them in the console.
            int[][] intJArray = new int[2][]
            {
                new int[2] { 1, 2 },
                new int[2] { 3, 4 }
            };
            string[][][] stringJArray = new string[1][][]
            {
                new string[1][]
                {
                    new string[1] { "test" }
                }
            };
            for (int i = 0; i < intJArray.Length; i++)
            {
                for (int j = 0; j < intJArray[i].Length; j++)
                {
                    Console.WriteLine("From intJArray: " + intJArray[i][j]);
                }
            }

            for (int i = 0; i < stringJArray.Length; i++)
            {
                for (int j = 0; j < stringJArray[i].Length; j++)
                {
                    for (int k = 0; k < stringJArray[i][j].Length; k++)
                    {
                        Console.WriteLine("From stringJArray: " + stringJArray[i][j][k]);
                    }
                }
            }

            //5-Create indexer optional structure to have access to the private data in the class.(optional structure)
            IndexerExample ie = new IndexerExample();
            ie[0] = 10;
            ie[1] = 20;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(ie[i]);
            }

            //6-Create a method that takes tuple as an input and returns tuple as the output...(optional structure)
            Tuple<int, string, string> auto = new Tuple<int, string, string>(2020, "Honda", "Accord");
            printTuple(auto);
        }

        //5- Write a method to take 3 arguments and print them by using interpolation
        static string stringInterpolation(string s1, string s2, string s3)
        {
            return $"{s1}{s2}{s3}";
        }

        //6- Write a method to calculate how many hours we have until next year.
        static double hoursNowTillNextYear()
        {
            DateTime nextYear = new DateTime(DateTime.Now.Year + 1, 01, 01);
            var result = nextYear.Subtract(DateTime.Now);
            return result.TotalHours;
        }

        //10- send shape anonymous type that you created in 3 into a method to print them by using interpolation
        static void printShape(dynamic param)
        {
            Console.WriteLine($"{param.color} {param.size} {param.model}");
        }

        //6-Create a method that takes tuple as an input and returns tuple as the output...(optional structure)
        static void printTuple(Tuple<int, string, string> car)
        {
            Console.WriteLine($"My car is a {car.Item1} {car.Item2} {car.Item3}");
        }
    }
}
