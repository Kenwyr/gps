using System.ComponentModel.DataAnnotations;

namespace NFTicket.Model
{
    public class Event
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string Type { get; set; } = string.Empty;
        [StringLength(100)]
        public int  Money  { get; set; }
        [StringLength(30)]
        public int Avdmoney { get; set; }
        [StringLength(300)]
        public string Note { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int PublisherId { get; set; }

    }
}
