using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CdCollection.Models
{
    public class Artist
    {
        //Properties
        public int ArtistID { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("CD's")]
        public ICollection<Cd> Cds { get; set; }
    }
}
