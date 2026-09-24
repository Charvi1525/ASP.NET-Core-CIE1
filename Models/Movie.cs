namespace _388.Models;

public class Movie
{
    public int MovieId { get; set; }

    public string MovieName { get; set; } = string.Empty;

    public string Genre { get; set; } = string.Empty;

    public string Language { get; set; } = string.Empty;

    public decimal TicketPrice { get; set; }

    public int AvailableSeats { get; set; }
}