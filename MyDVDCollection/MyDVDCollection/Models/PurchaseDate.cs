using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDVDCollection.Models
{
    public enum Rank
    {
        Five = 5, 
        Four = 4, 
        Three = 3, 
        Two = 2, 
        One = 1
    }

    public class PurchaseDate
    {
        public int PurchaseID { get; set; }
        public int GenreID { get; set; }
        public int TitleID { get; set; }
        public Rank? Rank { get; set; }

        public virtual Genres Genres { get; set; }
        public virtual Titles Titles { get; set; }
    }

}