using _388.Models;

namespace _388.Extensions;

public static class CinemaExtensions
{
    public static string GetBookingStatus(this Booking booking)
    {
        if (booking.CancellationDate.HasValue)
        {
            return "Cancelled";
        }

        if (booking.ShowDate.Date < DateTime.Today)
        {
            return "Completed";
        }

        if (booking.ShowDate.Date == DateTime.Today)
        {
            return "Today";
        }

        return "Upcoming";
    }

    public static decimal CalculateTotalAmount(
        this Booking booking,
        Movie movie)
    {
        return booking.NumberOfTickets * movie.TicketPrice;
    }
}