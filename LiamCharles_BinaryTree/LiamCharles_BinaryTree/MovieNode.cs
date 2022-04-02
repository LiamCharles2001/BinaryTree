using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LiamCharles_BinaryTree
{
    public class MovieNode
    {
        //Data
        private Movie movie;

        //connections
        private MovieNode left;
        private MovieNode right;

        //incoming "left" must be smaller than this.val
        public MovieNode Left
        {
            get { return left; }
            set
            {
                if (value?.Movie >= this.Movie)
                    left = null;
                else
                    left = value;
            }
        }

        //incoming "right" must be greater than this.val
        public MovieNode Right
        {
            get { return right; }
            set
            {
                if (value?.Movie <= this.Movie)
                    right = null;
                else
                    right = value;
            }
        }

        public MovieNode(Movie movie)
        {
            this.movie = movie;
            left = null;
            right = null;
        }

        public Movie Movie
        {
            get { return movie; }
        }

        public override string ToString()
        {
            return $"{Movie.Title}, ${Movie.Price}";
        }
    }
}
