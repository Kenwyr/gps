using System.ComponentModel.DataAnnotations;

namespace NFTicket.Model
{
    public class Sale
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Selectedticket { get; set; } = string.Empty;
        public int EventId { get; set; }
        
    }
}
