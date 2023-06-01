using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class Rating
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        [ForeignKey("GymProgram")]
        public int IDGymProgram { get; set; }
        public GymProgram GymProgram { get; set; }
        [ForeignKey("ApplicationUser")]
        public int? IDUser { get; set; }
        public ApplicationUser User { get; set; }
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
