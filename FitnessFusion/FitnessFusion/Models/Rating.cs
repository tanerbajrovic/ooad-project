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

        public Rating(double ratingValue, string review)
        {
            RatingValue = ratingValue;
            Review = review;
        }

        #endregion

        #region Methods

        // TODO

        #endregion 
    }
}
