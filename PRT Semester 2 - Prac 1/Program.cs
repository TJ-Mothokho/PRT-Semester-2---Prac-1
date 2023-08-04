using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT_Semester_2___Prac_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Weather Report";

            int numberOfWeeks = 4;
            int numberOfDays = 7;

            int[,] temperatures = new int[numberOfDays, numberOfWeeks];
            double[] averageTemperatureForEachweek = new double[numberOfWeeks];
            double[] averageTemperatureForEachDay = new double[numberOfDays];
            string[] dayNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            // your code goes here
            for (int r = 0; r < temperatures.GetLength(0); r++)
            {
                Console.WriteLine();
                Console.WriteLine(dayNames[r]);
                Console.WriteLine();
                for (int c = 0; c < temperatures.GetLength(1); c++)
                {
                    GetInputForArray(temperatures, r, c);
                    
                }
                
            }

            CalculateAverage(temperatures, numberOfWeeks, numberOfDays, averageTemperatureForEachDay, averageTemperatureForEachweek);

            //foreach (var num in averageTemperatureForEachDay)
            //{
            //    Console.WriteLine("{0:f2}", num);
            //}

            Console.WriteLine("");

            Display(temperatures, numberOfWeeks, numberOfDays, averageTemperatureForEachDay, averageTemperatureForEachweek, dayNames);

            //foreach (var num in averageTemperatureForEachweek)
            //{
            //    Console.WriteLine("{0:f2}", num);
            //}

            Console.ReadLine();

        }
        static void GetInputForArray(int[,] temperatures, int r, int c)
        {
            Console.Write("Enter Temperature {0}: ", r+1);
            int temp = int.Parse(Console.ReadLine());
            temperatures[r, c] = temp;
        }

        static void CalculateAverage(int[,] temperatures, int numberOfWeeks, int numberOfDays, double[] averageTemperatureForEachDay, double[] averageTemperatureForEachweek)
        {
            double sum = 0;
            double average = 0;
            for (int r = 0; r < numberOfDays;r++)
            {
                
                for (int c = 0; c < numberOfWeeks; c++)
                {
                    sum += temperatures[r, c];


                }
                average = sum / numberOfWeeks;
                averageTemperatureForEachDay[r] = average;
                sum=0;
                average = 0;

            }

            //Now we get the average for each week

             sum = 0;
            average = 0;
            for (int c = 0; c < numberOfWeeks; c++)//eeks
            {

                for (int r = 0; r < numberOfDays; r++)//day
                {
                    sum += temperatures[r, c];


                }
                average = sum / numberOfDays;//days
                averageTemperatureForEachweek[c] = average;
                sum = 0;
                average = 0;

            }

        }
        static void Display(int[,] temperatures, int numberOfWeeks, int numberOfDays, double[] averageTemperatureForEachDay, double[] averageTemperatureForEachweek, string[] dayNames)
        {
            Console.Clear();

            Console.WriteLine("4 WEEK WEATHER REPORT");
            Console.WriteLine("=======================");
            Console.WriteLine("DAY\t\tWEEK 1\tWEEK 2\tWEEK 3\tWEEK 4\tAVERAGE");
            Console.WriteLine("");

            for(int r = 0; r < temperatures.GetLength(0); r++)
            {
                Console.Write($"{dayNames[r]}\t\t");

                for (int c = 0;c < temperatures.GetLength(1); c++)
                {
                    Console.Write($"{temperatures[r, c]}\t");
                }

                Console.Write($"{averageTemperatureForEachDay[r]}");
                Console.WriteLine();
            }
            for(int i=0;i < numberOfWeeks;i++)
            {
                Console.Write("\t\t" + averageTemperatureForEachweek[i]);
            }
        }
    }


}
