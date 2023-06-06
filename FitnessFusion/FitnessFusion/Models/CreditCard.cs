using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string CardNumber { get; set;}
        public int CVC { get; set; }
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
