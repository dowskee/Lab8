using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool AnotherBatter = true;
            while (AnotherBatter == true)
            {
                //application will calculate the batting average and slugging percentage for one or more baseball players
                //for each player, the application first asks for the number of at bats. For each at bat, the application asks for a result
                //To enter an at-bat result, the user enters the number of bases earned by the batter.
                //after all the at-bats are entered, the application displays the batting average and slugging percentage of the batter 

                Console.WriteLine("Welcome to the Batting Average Calculator!");
                Console.WriteLine("Enter a number of times at bat:");

                int BatTimes = int.Parse(Console.ReadLine());

                //if (!int.TryParse(BatTimes, out ))
                //{
                //    Console.WriteLine("That is not a number. Please try again");
                //    AnotherBatter = true;
                //}
                Console.WriteLine("Please enter batting score:");
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = tripple, 4 = homerun");

                //add validation where user can only enter 0-4 (in another method)
                //use an array to store the at-bat results for each player: 
                double[] AtBat = new double[BatTimes];
                for (int i = 0; i < AtBat.Length; i++)

                {
                    Console.WriteLine($"Result for at-bat {i + 1}");
                    AtBat[i] = ValidateNums();

                }
                double Avg;
                double NumofValuesNotZero = 0;
                foreach (double Element in AtBat)
                {
                    if (Element != 0) 
                        NumofValuesNotZero = NumofValuesNotZero + 1;
                }

                Avg = NumofValuesNotZero / AtBat.Length;

                Console.WriteLine($"The Batting Average is equal to {Avg}");

                double Sum = 0;
                double Percentage;

                for (int i = 0; i < AtBat.Length; i++)
                {
                    Sum = Sum + AtBat[i] / AtBat.Length; //sum is sumation of the array

                }

                Percentage = Sum / AtBat.Length; //percentage is sum/ number of at bats (Length)

                Console.WriteLine($"The Slugging Percentage is equal to {Sum}");
                AnotherBatter = false;
                //format the batting average and slugging percentages such that three decimal places are shown. 

                //validate the user's response to the quesiont "Another batter?" so that the user can only enter Y or N (To Lower), 
                //and if the user enters N, to end the program. 

                //Batting Average = number of values that are not 0 in BatTimes array/ number of AtBats
                //Slugging % = sum of number of values from BatTimes array/number of AtBats


                string BatAgain;
                Console.WriteLine("Another batter? Y/N?");
                BatAgain = Console.ReadLine();
                if (BatAgain == "n" || BatAgain == "N" || BatAgain == "no" || BatAgain == "No")
                {
                    Console.WriteLine("See you at the next game!");
                    AnotherBatter = false;
                }
                else
                {
                    AnotherBatter = true;
                }
            }
        }

        public static double ValidateNums ()
        {
            double Score = ValidateDoubles(); //replace with method reading valid doubles with TryParse.double
            double i = 0;
            // int Input = int.Parse(Console.ReadLine());


            //validate user has entered 0-4
            while (Score < 0 || Score > 4) 
            {

                Console.WriteLine("Please enter a valid score! Your options are 0, 1, 2, 3, or 4!");
                Console.WriteLine($"Result for at-bat {i + 1}");
                Score = ValidateDoubles(); //replace with valid double Method
                
            }
            return Score;
        }

        public static double ValidateDoubles ()
        {
            //use TryParse to validate valid doubles
            {

                // int Input = int.Parse(Console.ReadLine());
                double i = 0;
                double Input = 0;

                while (!double.TryParse(Console.ReadLine(), out Input))
                {

                    Console.WriteLine("Please enter a number!");
                    Console.WriteLine($"Result for at-bat {i + 1}" );
                }
                // after the while, you will have a valid number! 
                return Input;



            }
        }
    }
}
