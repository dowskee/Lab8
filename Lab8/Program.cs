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
            //add validation where user can only enter 0-4 (in another method)
            Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = tripple, 4 = homerun");
            //use an array to store the at-bat results for each player: 
            double[] AtBat = new double[BatTimes];

            for (int i = 0; i < AtBat.Length; i++)
            {
                Console.WriteLine($"Result for at-bat {i}");
                AtBat[i] = double.Parse(Console.ReadLine() + (i + 1));
            }
            //format the batting average and slugging percentages such that three decimal places are shown. 

            //validate the user's response to the quesiont "Another batter?" so that the user can only enter Y or N (To Lower), 
            //and if the user enters N, to end the program. 

            //Batting Average = number of values that are not 0 in BatTimes array/ number of AtBats
            //Slugging % = sum of number of values from BatTimes array/number of AtBats
        }
    }
}
