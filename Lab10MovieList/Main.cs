using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie("Kubo and the Two Strings", "animated");
            var movie2 = new Movie("Spiderman: Into the Spiderverse", "animated");
            var movie3 = new Movie("Princess Mononoke", "animated");
            var movie4 = new Movie("Million Dollar Baby", "drama");
            var movie5 = new Movie("The Pianist", "drama");
            var movie6 = new Movie("Goodfellas", "drama");
            var movie7 = new Movie("I, Frankenstein", "horror");
            var movie8 = new Movie("What We Do in the Shadows", "horror");
            var movie9 = new Movie("Arrival", "scifi");
            var movie10 = new Movie("I Am Legend", "scifi");

            List<Movie> myMovies = new List<Movie>
            {
                movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10
                            };

            var sortedList = myMovies.OrderBy(m => m.Title).ToList();

            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine("Which movies would you like to see?");
                Console.WriteLine($"\n #1 Animated \n #2 Drama \n #3 Horror \n #4 Scifi \n");
                string searching = Console.ReadLine().ToLower();
                if (searching == "1")
                {
                    searching = "animated";
                }
                else if (searching == "2")
                {
                    searching = "drama";
                }
                else if (searching == "3")
                {
                    searching = "horror";
                }
                else if (searching == "4")
                {
                    searching = "scifi";
                }

                bool notFound = true;

                foreach (var movie in sortedList)
                {
                    if (searching == movie.Category)
                    {
                        notFound = false;
                        Console.WriteLine($"\"{movie.Title}\"");
                    }
                }

                if (notFound)
                {
                    Console.Write($"\nSorry, \"{searching}\" wasn't a valid entry.");
                }
                Console.WriteLine($"\nWant to try a different category? Y/N");
                string again = Console.ReadLine().ToLower();

                if (again == "y")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                    Console.WriteLine("BYE!");
                }
            }
        }
    }
}

