using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiamCharles_BinaryTree
{
    public partial class MainForm : Form
    {
        public string filePath = AppDomain.CurrentDomain.BaseDirectory + @"/Movies.txt";
        private MovieBinaryTree tree;
        private List<Movie> movies;

        public MainForm()
        {
            InitializeComponent();
            movies = GetMovies();
            tree = new MovieBinaryTree(movies);

            lblErrorMessageCreation.Text = "";
            lblErrorMessageSearch.Text = "";
            lblMovies.Text = "";
            lblMovies.Text = tree.DisplayElements();
        }

        private List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();

            try
            {
                // Create a new file if doesn't exist
                if (!File.Exists(filePath))
                {
                    using (StreamWriter file = File.CreateText(filePath))
                    {
                        //This is just here for some dummy data
                        file.WriteLine("Shrek 2, 1, 5, Jim\nSonic, 2, 6, Bill\nDetective Pikachu, 3, 8, Ken\nSaw, 4, 1, Larry\nBugs Life, 5, 4, Jarry\nCars 2, 6, 8, Ben\nDistrict 9, 7, 10, Sue\nCowboy beep bop, 8, 0, Jill\nBroke Back Mountain, 9, 0, Phil\nCloverfield, 10, 10, Narry\nIronman, 11, 6, Jeff\nIronman 2, 12, 6, Berry\nMario ft Chris, 13, 10, Starw\nET, 14, 2, Allen");
                        file.Close();
                    }
                }

                string line;

                // Read the file and display it line by line.
                using (StreamReader file = new StreamReader(filePath))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        movies.Add(new Movie(words[0], Convert.ToDecimal(words[1]), Convert.ToInt32(words[2]), words[3]));
                    }
                    file.Close();
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            return movies;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMessage = "Creation Issues:\n";
            lblErrorMessageCreation.Text = "";

            decimal price;
            int rating;
            bool isPriceNumeric = Decimal.TryParse(tbPrice.Text, out price);
            bool isRatingNumeric = Int32.TryParse(tbRating.Text, out rating);

            //Validation
            if(!isPriceNumeric)
            {
                errorMessage += "The Price has to be a number.\n";
                isValid = false;
            }
            if(!isRatingNumeric)
            {
                errorMessage += "The Rating has to be a number.\n";
                isValid = false;
            }
            if (tbTitle.Text == "")
            {
                errorMessage += "The Title cannot be left blank.\n";
                isValid = false;
            }
            if (tbDirector.Text == "")
            {
                errorMessage += "The Director cannot be left blank.\n";
                isValid = false;
            }
            if (tbPrice.Text == "" || price < 0 && isPriceNumeric)
            {
                errorMessage += "The Price has to be above 0 and not left blank.\n";
                isValid = false;
            }
            if (tbRating.Text == "" || rating > 5 || rating < 0 && isRatingNumeric)
            {
                errorMessage += "The Rating has to be between 0 and 5, also must not be left blank.\n";
                isValid = false;
            }


            if (isValid)
            {
                Movie movie = new Movie(tbTitle.Text, Convert.ToDecimal(tbPrice.Text), Convert.ToInt32(tbRating.Text), tbDirector.Text);
                //Save
                if (!movies.Contains(movie))
                {
                    SaveMovie(movie);
                    movies.Add(movie);
                    movies.Sort();
                    tree = new MovieBinaryTree(movies);

                    //Update visuals
                    lblErrorMessageCreation.Text = "";
                    tbTitle.Text = "";
                    tbDirector.Text = "";
                    tbPrice.Text = "";
                    tbRating.Text = "";
                    lblMovies.Text += $"{movie.Title}, {movie.Price}\n";
                    lblMovies.Text = tree.DisplayElements();
                    return;
                }

                lblErrorMessageCreation.Text = "The movie list cannot contain duplicate movies with the same prices";
            }
            else
            {
                lblErrorMessageCreation.Text = errorMessage;
            }
        }

        private void SaveMovie(Movie movie)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamWriter file = File.AppendText(filePath))
                    {
                        file.Write($"\n{movie.Title}, {movie.Price}, {movie.Rating}, {movie.Director}");
                        file.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMessage = "Search Issues:\n";
            lblErrorMessageSearch.Text = "";

            decimal price;
            bool isNumeric = Decimal.TryParse(tbSearchPrice.Text, out price);

            //Validation
            if (!isNumeric)
            {
                errorMessage += "The Price has to be a number.\n";
                isValid = false;
            }
            if (tbSearchTitle.Text == "")
            {
                errorMessage += "The Title cannot be left blank.\n";
                isValid = false;
            }
            if (tbSearchPrice.Text == "" || price < 0 && isNumeric)
            {
                errorMessage += "The Price has to be above 0 and not left blank.\n";
                isValid = false;
            }


            if (isValid)
            {
                Movie movie = new Movie(tbSearchTitle.Text, Convert.ToDecimal(tbSearchPrice.Text));

                //Search results
                if (tree.SearchForMovie(movie) != null)
                {
                    lblErrorMessageSearch.Text = tree.SearchForMovie(movie).ToString();
                }
                else
                {
                    lblErrorMessageSearch.Text = "No results we're found";
                }
            }
            else
            {
                lblErrorMessageSearch.Text = errorMessage;
            }
        }
    }
}