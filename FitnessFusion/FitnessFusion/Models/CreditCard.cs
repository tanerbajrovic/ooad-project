using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Properties

        // TODO: Add Regex annotations for CardNumber
        // and CVC

        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [Display(Name = "Card Number")]
        public string CardNumber { get; set;}
        public int CVC { get; set; }
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }

        #endregion

        #region Constructors

        public CreditCard() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
