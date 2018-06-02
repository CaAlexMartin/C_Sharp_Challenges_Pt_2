using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyDVDCollection.Models
{
    public class Genres
    {
        public int GenresID { get; set; }
        public string GenreCategory { get; set; }

        public virtual ICollection<PurchaseDate> PurchaseDates { get; set; }
    }
}