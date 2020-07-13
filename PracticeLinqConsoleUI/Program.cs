using System;
using System.Linq;


namespace PracticeLinqConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Practicing Linq";
            Console.WriteLine(phrase);
            Console.WriteLine();

            //Query Syntax
            //string cars = "Car List";
            string[] carList = { "Porche", "Tesla", "Land Rover", "Acura", "BMW", "Ferrari" };

            var cars = from car in carList
                      where car.Contains('r')
                      orderby car ascending
                      select car;

            foreach (var r in cars)
            {
                Console.WriteLine($"{r}");
            }
            Console.WriteLine();
        }
    }
}
