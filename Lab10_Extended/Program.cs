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
            //Setting up the Hash Table/////////////////////////////////////////////////////////////////
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
            ////////////////////////////////////////////////////////////////////////////////////////////
            Movies["science fiction"] = ScifiMovies;
            Movies["drama"] = DramaMovies;
            Movies["animated"] = AnimatMovies;
            Movies["horror"] = HorrorMovies;
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            //Display and functionality
            Console.WriteLine("       Welcome to the Movie Directory       ");
            Console.WriteLine("============================================");
            Console.WriteLine("                    MENU                    ");
            Console.WriteLine("============================================");
            Console.WriteLine("Drama  | Science Fiction | Animated | Horror");
            Console.WriteLine();
            Console.WriteLine("   1   |        2        |    3     |    4  ");
            Console.WriteLine();
            Console.WriteLine("Directions");
            //================================
            Console.WriteLine("=========");
            Console.WriteLine("Please enter a number (1-4) for a movie category.");
            while (true)
            {
            int selection;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out selection))
                    {
                        Console.WriteLine("Please input a correct value.");
                    }
                    if (selection >= 1 && selection <= 4)
                        break;
                    else
                        Console.WriteLine("Value needs to be from 1 to 4.");
                        Console.WriteLine("Please enter another number (1-4) for a movie category.");
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////
                string answer="";
                switch (selection)
                {
                    case 1:
                        answer = "drama";
                        break;
                    case 2:
                        answer = "science fiction";
                        break;
                    case 3:
                        answer = "animated";
                        break;
                    case 4:
                        answer = "horror";
                        break;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////
                    List<string> finalList = CategorySearch(answer, Movies);
                    foreach (string item in finalList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Do you wish to continue? (y/n)");
                    string cont = Console.ReadLine();
                    if (cont == "n" || answer == "N")
                        break;
                Console.WriteLine("Please enter another number");
            }
        }//MAIN---------------------

        //Returns cooresponding hashtable (dictionary) items for given key
        public static List<string> CategorySearch(string answer, Dictionary<string, List<string>> Movies)
        {
            List<string> finalList = new List<string>();
            List<string> SortedfinalList = new List<string>();
            finalList = Movies[answer];
            finalList.Sort();
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
