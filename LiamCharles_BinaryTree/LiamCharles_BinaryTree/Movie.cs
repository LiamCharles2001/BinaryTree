using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LiamCharles_BinaryTree
{
    public class Movie : IEquatable<Movie>, IComparable<Movie>
    {
        private decimal price;
        private int rating;

        public string Title { get; set; }
        public decimal Price 
        { 
            get { return price; } 
            set 
            { 
                if (value <= 0)
                    price = 0;
                else 
                    price = value; 
            }
        }
        public int Rating 
        {
            get { return rating; }
            set 
            {
                if (value < 0)
                    rating = 0;
                else if (value > 5)
                    rating = 5;
                else
                    rating = value;
            } 
        }
        public string Director { get; set; }

        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(string title, decimal price, int rating, string director)
        {
            Title = title;
            Price = price;
            Rating = rating;
            Director = director;
        }

        public override string ToString()
        {
            return $"({Title}, ${Price})";
        }

        public bool Equals(Movie other)
        {
            return (this.Price == other.Price);
        }

        public int CompareTo(Movie other)
        {
            // A null value means that this object is greater.
            if (other == null)
                return 1;
            else
                return this.Price.CompareTo(other.Price);
        }

        #region Operators

        public static bool operator !=(Movie movieOne, Movie movieTwo)
        {
            if (object.ReferenceEquals(movieOne, null))
                return !(object.ReferenceEquals(movieTwo, null));

            if (object.ReferenceEquals(movieTwo, null))
                return true;

            return !(movieOne.Title == movieTwo.Title && movieOne.Price == movieTwo.Price);
        }

        public static bool operator ==(Movie movieOne, Movie movieTwo)
        {
            if (object.ReferenceEquals(movieOne, null))
                return object.ReferenceEquals(movieTwo, null);

            if (object.ReferenceEquals(movieTwo, null))
                return false;

            return (movieOne.Title == movieTwo.Title && movieOne.Price == movieTwo.Price);

        }

        //More than
        public static bool operator >(Movie movieOne, Movie movieTwo)
        {
            if (movieOne == null || movieTwo == null)
                throw new ArgumentNullException();

            else if (movieOne.Price == movieTwo.Price)
                return movieOne.Title.CompareTo(movieTwo.Title) > 0;

            else return (movieOne.Price > movieTwo.Price);

        }

        //Less than
        public static bool operator <(Movie movieOne, Movie movieTwo)
        {
            if (movieOne == null || movieTwo == null)
                throw new ArgumentNullException();

            else if (movieOne.Price == movieTwo.Price)
                return movieOne.Title.CompareTo(movieTwo.Title) < 0;

            else return (movieOne.Price < movieTwo.Price);

        }

        //Less than or equal to
        public static bool operator <=(Movie movieOne, Movie movieTwo)
        {
            if (movieOne == null || movieTwo == null)
                return false; //throw new ArgumentNullException();

            else if (movieOne.Price == movieTwo.Price)
                return movieOne.Title.CompareTo(movieTwo.Title) < 0;

            else return (movieOne.Price <= movieTwo.Price);

        }
        //More than or equal to
        public static bool operator >=(Movie movieOne, Movie movieTwo)
        {
            if (movieOne == null || movieTwo == null)
                return false; //throw new ArgumentNullException();

            else if (movieOne.Price == movieTwo.Price)
                return movieOne.Title.CompareTo(movieTwo.Title) < 0;

            else return (movieOne.Price >= movieTwo.Price);

        }
        #endregion
    }
}
