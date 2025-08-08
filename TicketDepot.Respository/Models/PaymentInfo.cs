
namespace TicketDepot.TicketManagement.Repository
{
    /// <summary>
    /// Payment Info class.
    /// </summary>
    public class PaymentInfo
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PaymentInfo"/>.
        /// </summary>
        /// <param name="customerAccountNumber"></param>
        /// <param name="transactionId"></param>
        /// <param name="totalPrice"></param>
        /// <param name="cardNumber"></param>
        /// <param name="expiration"></param>
        /// <param name="securityCode"></param>
        /// <param name="bankAccount"></param>
        /// <param name="bankRoutingNumber"></param>
        public PaymentInfo(string customerAccountNumber, string transactionId, decimal totalPrice, string? cardNumber = null, string? expiration = null, string? securityCode = null, string? bankAccount = null, string? bankRoutingNumber = null)
        {
            this.CustomerAccountNumber = customerAccountNumber;
            this.TransactionId = transactionId;
            this.TotalPrice = totalPrice;
            this.CardNumber = cardNumber;
            this.Expiration = expiration;
            this.SecurityCode = securityCode;
            this.BankAccount = bankAccount;
            this.BankRoutingNumber = bankRoutingNumber;
        }

        public string CustomerAccountNumber { get; set; }

        public string TransactionId { get; set; }

        public decimal TotalPrice { get; set; }

        public string? CardNumber { get; set; }

        public string? Expiration { get; set; }

        public string? SecurityCode { get; set; }

        public string? BankAccount { get; set; }

        public string? BankRoutingNumber { get; set; }
    }
}
