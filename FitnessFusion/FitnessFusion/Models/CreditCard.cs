namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Properties

        public string CardNumber { get; set;}
        public int CVC { get; set; }
        public string ExpirationDate { get; set; }

        #endregion

        #region Constructors

        public CreditCard(string cardNumber, int cvc, string expirationDate)
        {
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
