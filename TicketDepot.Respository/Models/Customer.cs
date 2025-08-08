using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TicketDepot.TicketManagement.Repository
{
    /// <summary>
    /// The Customer class.
    /// </summary>
    public class Customer
    {
        public Customer(string id, string accountNumber, string firstName, string lastName)
        {
            Id = id;
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        [Required]
        [JsonProperty("id")]
        public string Id { get; set; }

        [Required]
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}
