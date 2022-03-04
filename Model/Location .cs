using System.ComponentModel.DataAnnotations;

namespace NFTicket.Model
{
    public class Location
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string Type { get; set; } = string.Empty;
        [StringLength(100)]
        public string Note { get; set; } = string.Empty;
        public int EventId { get; set; }
    }
}