using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zones = { " Cardio, Weights, Pool, Classes, and Yoga" };
            int[,] days = {
                          { 15, 50  ,48 , 17 , 55 ,70 , 25},
                          {35 , 40 , 42 , 45 , 50 , 55 , 60 },
                          { 25 , 30 , 28 , 27 , 29 , 35 , 38},
                          { 20 , 22 , 25 , 30,  28 , 33 , 65,},
                          { 45  ,18,  20 , 22 , 24  ,26 , 30}
                          } ;

            int[] totalAttendance = CalculateDailyTotals(days);

            for (int i = 0; i < totalAttendance.Length; i++)
            {
                Console.Write( totalAttendance[i] + " ");
            }
            Console.WriteLine("\n");
            double[] totalAttendance_Zone = CalculateZoneAverages(days);

            for (int j = 0; j < totalAttendance_Zone.Length; j++)
            {
                Console.Write( totalAttendance_Zone[j]+ " ");
            }

            Console.Write("\n\nEnter index(0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            int day_highest_att_zone = FindBusiestDayForZone(days, index);
            Console.WriteLine("\nDay with highest attendance is: "+  day_highest_att_zone);
            Console.ReadKey();
        }
        static int [] CalculateDailyTotals(int[,] days)
        {
            int[] totalAttendance = new int[days.GetLength(1)];

            for (int i = 0; i < days.GetLength(1); i++)
            {
                for (int j = 0; j< days.GetLength(0); j++)
                {
                    totalAttendance[i] += days[j,i];
                }
                 
            }
            return totalAttendance;
        }
        static double[] CalculateZoneAverages(int[,] days)
        {
            int[] totalAttendance_Zone = new int[days.GetLength(0)];
            double[] avg_weekly_Zones = new double[days.GetLength(0)];
            for (int i = 0; i < days.GetLength(0); i++)
            {
                for (int j = 0; j < days.GetLength(1); j++)
                {
                    totalAttendance_Zone[i] += days[i,j];
                }
                 
                avg_weekly_Zones[i] = totalAttendance_Zone[i] / days.GetLength(0);
            }
            return  avg_weekly_Zones;
        }
        static int FindBusiestDayForZone(int[,] days, int index)
        {
            int day_with_highest_att_in_zone = days[index, 1];
             for (int i = 1; i < days.GetLength(1); i++)
             {
                if (day_with_highest_att_in_zone <= days[index, i])
                {
                    day_with_highest_att_in_zone = days[index, i];
                }
                
             }
            return day_with_highest_att_in_zone;
        }
    }
}
