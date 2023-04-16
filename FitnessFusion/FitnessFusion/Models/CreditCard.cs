namespace FitnessFusion.Models
{
    public class CreditCard
    {
        #region Attributes

        private string cardNumber;
        private int cvc;
        private string expirationDate;

        #endregion

        #region Properties

        public string CardNumber { get =>  cardNumber; set => cardNumber = value;}
        public int Cvc { get => cvc; set => cvc = value; }
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }

        #endregion

        #region Constructors

        public CreditCard(string cardNumber, int cvc, string expirationDate)
        {
            CardNumber = cardNumber;
            Cvc = cvc;
            ExpirationDate = expirationDate;
        }

        #endregion

        #region Methods

        // TODO

        #endregion
    }
}
