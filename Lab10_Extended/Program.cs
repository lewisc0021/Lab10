using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Extended
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> Movies = new Dictionary<string, List<string>>();

            List<string> ScifiMovies = new List<string>();
            List<string> DramaMovies = new List<string>();
            List<string> AnimatMovies = new List<string>();
            List<string> HorrorMovies = new List<string>();
            List<Movie> AllMovies = new List<Movie>();

            ////////////////////////////////////////////////////////////////////////////////////////////
            AllMovies.Add(new Movie("Star Wars", "science fiction"));
            AllMovies.Add(new Movie("A Space Odyssey", "science fiction"));
            AllMovies.Add(new Movie("A Clockwork Orange", "science fiction"));
            AllMovies.Add(new Movie("Inception", "science fiction"));
            AllMovies.Add(new Movie("Saving Private Ryan", "drama"));
            AllMovies.Add(new Movie("The Prestige", "drama"));
            AllMovies.Add(new Movie("Friday Night Lights", "drama"));
            AllMovies.Add(new Movie("Forest Gump", "drama"));
            AllMovies.Add(new Movie("Finding Nemo", "animated"));
            AllMovies.Add(new Movie("Mulan", "animated"));
            AllMovies.Add(new Movie("Monsters Inc.", "animated"));
            AllMovies.Add(new Movie("The Incredibles", "animated"));
            AllMovies.Add(new Movie("The Witch", "horror"));
            AllMovies.Add(new Movie("IT", "horror"));
            AllMovies.Add(new Movie("The Ring", "horror"));
            AllMovies.Add(new Movie("", "horror"));
            ////////////////////////////////////////////////////////////////////////////////////////////

            foreach (Movie item in AllMovies)
            {
                if (item.CATEGORY == "science fiction")
                    ScifiMovies.Add(item.TITLE);
                if (item.CATEGORY == "drama")
                    DramaMovies.Add(item.TITLE);
                if (item.CATEGORY == "animated")
                    AnimatMovies.Add(item.TITLE);
                if (item.CATEGORY == "horror")
                    HorrorMovies.Add(item.TITLE);
            }

            /////////////////////////////////////////////////////////////////
            Movies["science fiction"] = ScifiMovies;
            Movies["drama"] = DramaMovies;
            Movies["animated"] = AnimatMovies;
            Movies["horror"] = HorrorMovies;
            /////////////////////////////////////////////////////////////////


            Console.WriteLine("Welcome to the Movie Directory");
            while (true)
            {
                Console.WriteLine("=========");
                Console.WriteLine("Please enter a movie category.");
                string answer = Console.ReadLine().ToLower();
                if (validateAnswer(answer))
                {
                    List<string> finalList = CategorySearch(answer.Trim(), Movies);
                    foreach (string item in finalList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Do you wish to continue? (y/n)");
                    string cont = Console.ReadLine();
                    if (cont == "n" || answer == "N")
                        break;
                }
            }

        }//MAIN---------------------

        //Returns cooresponding hashtable (dictionary) items for given key
        public static List<string> CategorySearch(string answer, Dictionary<string, List<string>> Movies)
        {
            List<string> finalList = new List<string>();
            finalList = Movies[answer];
            return finalList;
        }
        
        //Validation of input
        public static bool validateAnswer(string answer)
        {
            List<string> possibleAnsrs = new List<string>();
            possibleAnsrs.Add("science fiction");
            possibleAnsrs.Add("drama");
            possibleAnsrs.Add("animated");
            possibleAnsrs.Add("horror");
            answer = answer.Trim();
            if (answer == "")
            {
                Console.WriteLine("Please actually enter an input.");
                return false; //triggered if the user didn't enter any characters ie. spaces or tabs or nothing
            }
            if (!possibleAnsrs.Contains(answer))
            {
                Console.WriteLine("Category not found.");
                return false; //triggered if the user didn't enter anything that matched
            }
            else
                return true;
        }
  
}}//END----------------------
