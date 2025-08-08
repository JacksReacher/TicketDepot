

using Newtonsoft.Json;

namespace TicketDepot.TicketManagement.Repository
{
    /// <summary>
    /// BaseDocument class
    /// </summary>
    public class BaseDocument
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("_etag")]
        public string? Etag { get; set; }
    }
}
