using System;

namespace BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double your_height = 0;
            double your_weight = 0;

            if (args.Length < 1)
            {
                Wronge_Command(1);
            }
            else
            {

                if (args[0] == "bmi")
                {
                    switch (args[1])
                    {
                        case "help--":
                            help();
                            break;

                        case "version--":
                            Version();
                            break;

                        case "height--":
                            if (args.Length > 2)
                            {
                                your_height = Convert.ToDouble(args[2]);

                            }
                            else
                            {
                                Wronge_Command(2);
                            }
                            break;

                        case "weight--":

                            if (args.Length > 2)
                            {
                                your_weight = Convert.ToDouble(args[2]);

                            }
                            else
                            {
                                Wronge_Command(3);
                            }
                            break;

                        default:
                            Wronge_Command(4);
                            break;

                    }

                    switch (args[3])
                    {
                        case "height--":
                            if (args.Length > 4)
                            {
                                your_height = Convert.ToDouble(args[4]);

                            }
                            else { Wronge_Command(5); }
                            break;

                        case "weight--":
                            if (args.Length > 4)
                            {
                                your_weight = Convert.ToDouble(args[4]);

                            }
                            else { Wronge_Command(6); }
                            break;
                        default:
                            Wronge_Command(7);
                            break;


                    }

                    if (your_weight > 0 && your_height > 0)
                    {
                        Your_BMI(your_weight, your_height);
                    }
                    else { Wronge_Command(8); }
                }
                else { Wronge_Command(9); }

            }


        }
        private static void Your_BMI(double _weight, double _height)
        {
            var BMI = _weight / Math.Pow(_height, 2);
            System.Console.WriteLine($"your score is: {BMI} ");

            if (BMI < 16)
            {
                Console.WriteLine("Severely Under Weight!!!");

            }
            else if (BMI >= 16 && BMI <= 18.4)
            {
                Console.WriteLine("Under Wegiht!!");

            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("*NORMAL*");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("OverWeight!");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine("Moderately Obese!!");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine("Severely Obese!!!");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Morbidly Obese!!!");
            }


        }
       
        private static void Wronge_Command(int error)
        {
            System.Console.WriteLine(error);
            System.Console.WriteLine("you command is not vaild :( \nif ypu need help use (dotnet run bmi help--) command");
            Environment.Exit(0);
        }
        private static void help()
        {
            System.Console.WriteLine("Use this command to run the program:");
            System.Console.WriteLine("height--      Your height (meters)");
            System.Console.WriteLine("weight--      Your weight (kilograms)");
            System.Console.WriteLine("version--     Show current version");
            System.Console.WriteLine("help--        Show command list");
            Environment.Exit(0);

        }

        private static void Version()
        {
            System.Console.WriteLine("current version:   1.1");
            Environment.Exit(0);
        }








    }
}
