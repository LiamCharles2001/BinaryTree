using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LiamCharles_BinaryTree
{
    class MovieBinaryTree
    {
        private MovieNode root;

        public MovieNode Root
        {
            get { return root; }
        }

        public MovieBinaryTree(List<Movie> elementList)
        {
            elementList.Distinct();
            elementList.Sort();
            root = Build(elementList, 0, elementList.Count - 1);
        }

        static MovieNode Build(List<Movie> elementList, int startIndex, int endIndex)
        {
            if (startIndex > endIndex) return null;

            int middleIndex = (int)Math.Floor(((double)startIndex + (double)endIndex) / 2);  //Find Root

            MovieNode newNode = new MovieNode(elementList[middleIndex]);

            newNode.Left = Build(elementList, startIndex, middleIndex - 1);
            newNode.Right = Build(elementList, middleIndex + 1, endIndex);

            return newNode;
        }

        public string DisplayElements()
        {
            return DisplayElements(Root);
        }

        private static string DisplayElements(MovieNode root)
        {
            if (root == null) return "";

            string output = root.ToString() + "\n";

            output += (DisplayElements(root.Left) + DisplayElements(root.Right));
            return output;
        }

        public MovieNode SearchForMovie(Movie movieToFind)
        {
            MovieNode current = root;

            while (current != null)
            {
                if (movieToFind == current.Movie)
                    return current;
                else if (movieToFind < current.Movie)
                    current = current.Left;
                else 
                    current = current.Right;
            }
            return null;
        }

        public void Insert(Movie newMovie)
        {
            if (root == null)
            {
                root = new MovieNode(newMovie);
                return;
            }
            MovieNode current = root;

            while (current != null)
            {
                if (newMovie.Price < current.Movie.Price)
                {
                    if (current.Left == null)
                    {
                        current.Left = new MovieNode(newMovie);
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else if (newMovie.Price > current.Movie.Price)
                {
                    if (current.Right == null)
                    {
                        current.Right = new MovieNode(newMovie);
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
                else 
                {
                    Console.WriteLine("Duplicate movies are not permitted in a BST.");
                    break;
                }
            }
        }
    }
}