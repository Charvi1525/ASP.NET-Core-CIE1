using System.ComponentModel.DataAnnotations;

namespace _388.Models;

public class Booking
{
    public int BookingId { get; set; }

    [Required]
    public string CustomerName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Phone { get; set; } = string.Empty;

    [Required]
    public int MovieId { get; set; }

    [Required]
    public DateTime BookingDate { get; set; }

    [Required]
    public DateTime ShowDate { get; set; }

    [Required]
    [Range(1, 10)]
    public int NumberOfTickets { get; set; }

    public DateTime? CancellationDate { get; set; }
}