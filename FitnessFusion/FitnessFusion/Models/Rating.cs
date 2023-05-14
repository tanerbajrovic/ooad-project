using System.ComponentModel.DataAnnotations;

namespace FitnessFusion.Models
{
    public class Rating
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        public double RatingValue { get; set; }
        public string Review { get; set; }

        #endregion

        #region Constructor

        public Rating(int id, double rating, string review)
        {
            ID = id;
            RatingValue = rating;
            Review = review;
        }

        public Rating () { }

        #endregion

        #region Methods

        // TODO

        #endregion 
    }
}
