using Newtonsoft.Json;

namespace TicketDepot.TicketManagement.Repository
{
    public class TicketAvailability
    {
        [JsonProperty("reservationStatus")]
        public ReservationStatus ReservationStatus { get; set; }

        [JsonProperty("seatingType")]
        public SeatingType SeatingType { get; set; }

        [JsonProperty("countOf")]
        public int CountOf { get; set; }
    }
}
