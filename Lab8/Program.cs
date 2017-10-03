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
            //application will calculate the batting average and slugging percentage for one or more baseball players
            //for each player, the application first asks for the number of at bats. For each at bat, the application asks for a result
            //To enter an at-bat result, the user enters the number of bases earned by the batter.
            //after all the at-bats are entered, the application displays the batting average and slugging percentage of the batter 

            Console.WriteLine("Welcome to the Batting Average Calculator!");
            Console.WriteLine("Enter a number of times at bat:");

            int BatTimes = int.Parse(Console.ReadLine());

            ValidateNums();
            //add validation where user can only enter 0-4 (in another method)
            //use an array to store the at-bat results for each player: 
            double[] AtBat = new double[BatTimes];
            for (int i = 0; i < AtBat.Length; i++)

            {
                Console.WriteLine($"Result for at-bat {i + 1}");
                AtBat[i] = double.Parse(Console.ReadLine());
            }

            double NumofValuesNotZero = 0;
            double Avg;

            for (int i = 0; i < AtBat.Length; i++)
            {
                NumofValuesNotZero = (AtBat[i] = 1); //fix me! Needs to be values that are not zero!

            }

            Avg = NumofValuesNotZero / AtBat.Length;

            Console.WriteLine($"The Avg is equal to {Avg}");

            double Sum = 0;
            double Percentage;

            for (int i = 0; i < AtBat.Length; i++)
            {
                Sum = Sum + AtBat[i]; //sum is sumation of the array

            }

            Percentage = Sum / AtBat.Length; //percentage is sum/ number of at bats (Length)

            Console.WriteLine($"The Slugging Percentage is equal to {Sum}");

            //format the batting average and slugging percentages such that three decimal places are shown. 

            //validate the user's response to the quesiont "Another batter?" so that the user can only enter Y or N (To Lower), 
            //and if the user enters N, to end the program. 

            //Batting Average = number of values that are not 0 in BatTimes array/ number of AtBats
            //Slugging % = sum of number of values from BatTimes array/number of AtBats
        }

        public static int ValidateNums ()
        {
            Console.WriteLine("Please enter batting score:");
            Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = tripple, 4 = homerun");
            int Score = int.Parse(Console.ReadLine());

            // int Input = int.Parse(Console.ReadLine());


            while ((Score != 0) && (Score != 1) && (Score != 2) && (Score != 3) && (Score != 4))
            {

                Console.WriteLine("Please enter a valid score! Your options are 0, 1, 2, 3, or 4!");
                Score = int.Parse(Console.ReadLine());
                break;
            }
            // after the while, you will have a valid number! 
            return Score;
        }
    }
}
