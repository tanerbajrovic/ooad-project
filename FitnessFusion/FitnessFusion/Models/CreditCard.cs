using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Card Number")]
        public string CardNumber { get; set;}
        public int CVC { get; set; }
        [DisplayName("Expiration Date")]
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
