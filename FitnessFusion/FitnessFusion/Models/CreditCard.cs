using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Properties

        [Key]
        public int ID { get; set; }
        [ForeignKey("ApplicationUser")]
        public int IDUser { get; set; }
        public ApplicationUser User { get; set; }
        public string CardNumber { get; set;}
        public int CVC { get; set; }
        public string ExpirationDate { get; set; }

        #endregion

        #region Constructors

        public CreditCard(int id, string cardNumber, int cvc, string expirationDate)
        {
            ID = id;
            CardNumber = cardNumber;
            CVC = cvc;
            ExpirationDate = expirationDate;
        }

        public CreditCard() { }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
