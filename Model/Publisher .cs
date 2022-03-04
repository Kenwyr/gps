using System.ComponentModel.DataAnnotations;

namespace NFTicket.Model
{
    public class Publisher
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [StringLength(200)]
        public string Password { get; set; } = string.Empty;
        [StringLength(100)]
        public string Company { get; set; } = string.Empty;
        [StringLength(30)]
        public string Fname { get; set; } = string.Empty;
        [StringLength(30)]
        public string Lname { get; set; } = string.Empty;
    }
}
