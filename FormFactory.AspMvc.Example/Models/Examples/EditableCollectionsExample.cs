using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormFactory.AspMvc.Example.Models.Examples
{
    public class EditableCollectionsExample
    {

        public EditableCollectionsExample()
        {
            TopMovies = new List<Movie>()
            {
                new Movie() {Title = "Fight Club"},
                new Movie() {Title = "The Silent Partner" },
                new Movie() {Title = "Bambi"},
            };

        }

        [Description("Writable ICollections get rendered as re-orderable lists")]
        public ICollection<Movie> TopMovies { get; set; }
    }

    public class Movie
    {
        [Required]
        [StringLength(64, MinimumLength = 2)]
        public string Title { get; set; }
    }
}