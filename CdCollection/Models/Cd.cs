using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CdCollection.Models
{
    public class Cd
    {
        //Properties
        public int CdID { get; set; }

        [DisplayName("Title")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Year")]
        public int ReleaseYear { get; set; }

        public int ArtistID { get; set; }
        public Artist Artist { get; set; }
    }
}