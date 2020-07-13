using System;
using System.Collections.Generic;
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
            #region Query Syntax            
            string[] carList = { "Porsche", "Tesla", "Land Rover", "Acura", "BMW", "Ferrari" };

            var cars = from car in carList
                      where car.Contains('r')
                      orderby car descending
                      select car;

            foreach (var r in cars)
            {
                Console.WriteLine($"{r}");
            }
            Console.ReadLine();
            #endregion

            #region Method Syntax
            List<string> videogames = new List<string>() { "Doom", "WOW", "Diablo 3", "Mortal Kombat", "Final Fantasy" };
            IEnumerable<string> moreVideoGames = videogames.OrderByDescending(name => name.Length);

            foreach(var i in moreVideoGames)
            {
                Console.WriteLine(i);
            }
            #endregion
        }


    }
    }
