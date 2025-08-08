using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDepot.TicketManagement.Repository.Models.Base
{
    public class BaseReservation
    {
        /// <summary>
        /// Instantiates a new instance of <see cref="Reservation"/>.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="eventId"></param>
        /// <param name="ticketTypeId"></param>
        /// <param name="customerAccountNumber"></param>
        /// <param name="seatingType"></param>
        /// <param name="reserveMinutes"></param>
        /// <param name="quanity"></param>
        /// <param name="reservationStatus"></param>
        public BaseReservation(string transactionId, string eventId, string ticketTypeId, string customerAccountNumber, SeatingType seatingType, int reserveMinutes, int quanity, ReservationStatus reservationStatus)
        {
            this.TransactionId = transactionId;
            this.EventId = eventId;
            this.TicketTypeId = ticketTypeId;
            this.CustomerAccountNumber = customerAccountNumber;
            this.SeatingType = seatingType;
            this.Quantity = quanity;
            this.ReservationStatus = reservationStatus;
            if (reservationStatus == ReservationStatus.Reserved)
            {
                this.ReserveUntil = DateTimeOffset.UtcNow.AddMinutes(reserveMinutes);
            }
        }

        [Required]
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [Required]
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [Required]
        [JsonProperty("ticketTypeId")]
        public string TicketTypeId { get; set; }

        [Required]
        [JsonProperty("customerAccountNumber")]
        public string CustomerAccountNumber { get; set; }

        [Required]
        [JsonProperty("seatingType")]
        public SeatingType SeatingType { get; set; }

        [Required]
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("reserveUntil")]
        public DateTimeOffset? ReserveUntil { get; set; }

        [JsonProperty("ReservationStatus")]
        public ReservationStatus ReservationStatus { get; set; }

        [JsonProperty("sendTicketsByEmail")]
        public bool SendTicketsByEmail { get; set; }

        [JsonProperty("sendTicketsByMail")]
        public bool SendTicketsByMail { get; set; }
    }
}
