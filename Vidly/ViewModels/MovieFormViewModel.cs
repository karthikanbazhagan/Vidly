namespace Vidly.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Vidly.Models;

    public class MovieFormViewModel
    {
        public string Title { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
    }
}