using System;

namespace ISP._2_after
{
    public class Book
    {
         readonly string _title;

         readonly string _author;

         readonly int _yearOfPublished;

         int ratingCount = 0;

         float totalRating = 0;

        public Book(string author,string title,int yearOfPublished)
        {
            _title = title;
            _author = author;
            _yearOfPublished = yearOfPublished;

        }
        public string GetSummary()
        {
            return _title + "by" + _author + ", published" + _yearOfPublished;
        }
        public double GetRating()
        {
            return Math.Round(totalRating / ratingCount);
        }
        public void Rate(int scoreOutOfFive)
        {
            ratingCount++;
            totalRating += scoreOutOfFive;
        }
    }
}
