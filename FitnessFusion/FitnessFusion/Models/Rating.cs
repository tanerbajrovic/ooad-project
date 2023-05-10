namespace FitnessFusion.Models
{
    public class Rating
    {
        #region Attributes

        private double ratingValue;
        private string review;

        #endregion

        #region Properties

        public double RatingValue { get => ratingValue; set => ratingValue = value; }
        public string Review { get => review; set => review = value; }

        #endregion

        #region Constructor

        public Rating(double rating, string review)
        {
            RatingValue = rating;
            Review = review;
        }

        public Rating ()
        {

        }

        #endregion

        #region Methods

        // TODO

        #endregion 
    }
}
