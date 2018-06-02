using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDVDCollection.Models
{
    public class Titles
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual ICollection<Titles> DVDTitle { get; set; }

    }
}