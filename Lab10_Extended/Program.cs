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
            // 1.
            Display();

            // 2.
            Dictionary<string, List<string>> Movies = CreateDictionary(); 

            while (true)// Primary Functional Loop Start
            {
                //3.
                int selection = GetSelection();

                //4.
                string answer = GetAnswer(selection);

                //5.
                List<string> finalList = CategorySearch(answer, Movies);
                foreach (string item in finalList)
                {
                    Console.WriteLine(item);
                }


                //Continue?
                Console.WriteLine("Enter anything to continue, or no to exit");
                string cont = Console.ReadLine().Trim().ToLower();
                if (cont == "n" || cont == "no")
                    break;
                else 
                    Console.WriteLine("Please enter another number");

            }// Primary Functional Loop End


        }//MAIN---------------------

        // 1. Displaying the menu (an all string method)
        private static void Display()
        {
            Console.WriteLine("                  Welcome to the Movie Directory          ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("                           MENU                           ");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Scifi || Drama || Animated || Horror || Musical || Comedy ");
            Console.WriteLine();
            Console.WriteLine("   1  ||   2   ||    3     ||    4   ||    5    ||    6   ");
            Console.WriteLine();
            Console.WriteLine("Directions");
            Console.WriteLine("Enter the number cooresponding to your desired category");
            Console.WriteLine("=========");
            Console.WriteLine("Please enter a number (1-6) for a movie category.");
        }

        // 2. Returns the Dictionary that provides central functionality to the program
        private static Dictionary<string, List<string>> CreateDictionary()
        {
            //STEP 1: Initialize Hash Table (Dictionary), Category Lists and Master List
            Dictionary<string, List<string>> Movies = new Dictionary<string, List<string>>();
            List<string> ScifiMovies = new List<string>();
            List<string> DramaMovies = new List<string>();
            List<string> AnimatMovies = new List<string>();
            List<string> HorrorMovies = new List<string>();
            List<string> Musicals = new List<string>();
            List<string> Comedies = new List<string>();
            List<Movie> AllMovies = new List<Movie>();

            //STEP 2: Populate the Master List from MovieIO items
            for (int i = 1; i <= 100; i++)
            {
                AllMovies.Add(MovieIO.getMovie(i));
            }

            //STEP 3: Populate each Category List
            foreach (Movie item in AllMovies)
            {
                if (item.CATEGORY == "scifi")
                    ScifiMovies.Add(item.TITLE);

                if (item.CATEGORY == "drama")
                    DramaMovies.Add(item.TITLE);

                if (item.CATEGORY == "animated")
                    AnimatMovies.Add(item.TITLE);

                if (item.CATEGORY == "horror")
                    HorrorMovies.Add(item.TITLE);

                if (item.CATEGORY == "musical")
                    Musicals.Add(item.TITLE);

                if (item.CATEGORY == "comedy")
                    Comedies.Add(item.TITLE);
            }

            //STEP 4: Match Dictionary keys to category lists
            Movies["scifi"] = ScifiMovies;
            Movies["drama"] = DramaMovies;
            Movies["animated"] = AnimatMovies;
            Movies["horror"] = HorrorMovies;
            Movies["musical"] = Musicals;
            Movies["comedy"] = Comedies;

            return Movies;
        }

        // 3. Returns selection number
        private static int GetSelection()
        {
            int selection;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Please input a correct value.");
                }
                if (selection >= 1 && selection <= 6)
                    break;
                else
                    Console.WriteLine("Value needs to be from 1 to 6.");
                Console.WriteLine("Please enter another number (1-6) for a movie category.");
            }
            return selection;
        }

        // 4. Returns answer that is used for category identification
        private static string GetAnswer(int selection)
        {
            string answer = "";
            switch (selection)
            {
                case 1:
                   return answer = "scifi";
                 
                case 2:
                   return answer = "drama";
                   
                case 3:
                   return answer = "animated";
             
                case 4:
                    return answer = "horror";
                 
                case 5:
                   return answer = "musical";
                   
                case 6:
                   return answer = "comedy";

                default:
                    return answer = "nothing";
            }
        }

        // 5. Returns cooresponding hashtable (dictionary) items for given key
        public static List<string> CategorySearch(string answer, Dictionary<string, List<string>> Movies)
        {
            List<string> finalList = new List<string>();
            finalList = Movies[answer];
            finalList.Sort();

            return finalList;
        }
             
         
}}//END----------------------
