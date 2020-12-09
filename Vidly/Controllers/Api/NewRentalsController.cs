namespace Vidly.Controllers.Api
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using Vidly.Dtos;
    using Vidly.Models;

    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalsDto newRentalsDto)
        {
            var customer = _context.Customers.Single(c => c.Id == newRentalsDto.CustomerId);

            var movies = _context.Movies.Where(m => newRentalsDto.MovieIds.Contains(m.Id));

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest($"Movie: '{movie.Name}' is not available currently.!");

                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
