using _388.Models;

namespace _388.Controllers;

public class CinemaController : Controller
{
    private static readonly List<Movie> movies = new()
    {
        new Movie
        {
            MovieId = 1,
            MovieName = "Avengers",
            Genre = "Action",
            Language = "English",
            TicketPrice = 250,
            AvailableSeats = 100
        },

        new Movie
        {
            MovieId = 2,
            MovieName = "3 Idiots",
            Genre = "Comedy",
            Language = "Hindi",
            TicketPrice = 200,
            AvailableSeats = 80
        },

        new Movie
        {
            MovieId = 3,
            MovieName = "RRR",
            Genre = "Action",
            Language = "Telugu",
            TicketPrice = 300,
            AvailableSeats = 120
        }
    };

    private static readonly List<Booking> bookings = new();

    public IActionResult Index()
    {
        ViewBag.Movies = movies;
        return View(bookings);
    }

    [HttpGet]
    public IActionResult BookTicket()
    {
        ViewBag.Movies = movies;
        return View();
    }

    [HttpPost]
    public IActionResult BookTicket(Booking booking)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Movies = movies;
            return View(booking);
        }

        booking.BookingId = bookings.Count + 1;
        bookings.Add(booking);

        return RedirectToAction("Index");
    }

    public IActionResult MovieDetails(int id)
    {
        var booking = bookings.FirstOrDefault(
            b => b.BookingId == id);

        if (booking == null)
        {
            return NotFound();
        }

        var movie = movies.FirstOrDefault(
            m => m.MovieId == booking.MovieId);

        if (movie == null)
        {
            return NotFound();
        }

        ViewBag.Movie = movie;

        return View(booking);
    }

    public IActionResult About()
    {
        return View();
    }
}