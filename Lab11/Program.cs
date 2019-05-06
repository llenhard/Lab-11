using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies= new List<Movie>() {new Movie("Happy Gilmore", "Comedy"), new Movie("Star Wars", "Scifi"), new Movie("2001: A Space Odyssey", "Scifi"),
                new Movie("A Clockwork Orange", "Scifi"), /* it is at this moment i got bored searching movies*/new Movie("Movie 5", "Comedy"), new Movie("Movie 6", "Action"), new Movie("Movie 7", "Action")
            , new Movie("Movie 8", "Comedy"), new Movie("Movie 9", "Scifi"), new Movie("Movie 10", "Action")};//why 10 q-q
            string wantedCategory;
            
            do
            {
                Console.WriteLine("Welcome to the Movie List Application." +//kinda wanna put this line and the one below above the dowhile loop but ehhhhhh
                    $"\n\nThere are {movies.Count} movies in the list." +
                    $"\nWhat category are you interested in? (action, comedy, scifi)");//i was thinking about making it print distinct categories from the movies list
                wantedCategory = Console.ReadLine().ToLower();

                List<Movie> foundMovies = new List<Movie>();
                foreach(Movie movie in movies)
                {
                    if(movie.Category.ToLower() == wantedCategory)//most certainly a better way to go about this for line 34 purposes
                    {//probably just should have had a bool defaulted at false and set it to true if it finds one
                        foundMovies.Add(movie);
                        Console.WriteLine(movie.Title);
                    }
                }
                Console.WriteLine(foundMovies.Any() ? "That is all the movies matching your request.":"No movies could be found with that category.");

                Console.WriteLine("\nDo you want to continue? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
