using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyDVDCollection.Models;
  

namespace MyDVDCollection.DataAccess
{
    public class DVDInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            var titles = new List<Titles>
            {
                new Titles{Title="Titanic", PurchaseDate=DateTime.Parse("1997-7-5")},
                new Titles{Title="Super Troopers", PurchaseDate=DateTime.Parse("2004-5-3")},
                new Titles{Title="Babe", PurchaseDate=DateTime.Parse("1991-1-12")},
                new Titles{Title="Boondock Saints", PurchaseDate=DateTime.Parse("2002-7-3")},
                new Titles{Title="Moulin Rouge", PurchaseDate=DateTime.Parse("2003-1-12")},
                new Titles{Title="Carrie", PurchaseDate=DateTime.Parse("2005-11-23")}
                };

           

            var genres = new List<Genres>
            {
                new Genres{ GenresID=0101, GenreCategory="Comedy"},
                new Genres{ GenresID=0102, GenreCategory="Drama"},
                new Genres{ GenresID=0103, GenreCategory="Romance"},
                new Genres{ GenresID=0104, GenreCategory="Horror"},
                new Genres{ GenresID=0105, GenreCategory="Rom-Com"},
                new Genres{ GenresID=0106, GenreCategory="Suspense"},
            };

           

            var purchasedate = new List<PurchaseDate>
            {
                new PurchaseDate{TitleID=1, GenreID=0103},
                new PurchaseDate{TitleID=2, GenreID=0101},
                new PurchaseDate{TitleID=3, GenreID=0101},
                new PurchaseDate{TitleID=4, GenreID=0106},
                new PurchaseDate{TitleID=5, GenreID=0105},
                new PurchaseDate{TitleID=6, GenreID=0104},
            };

            
            context.SaveChanges();

            }
        }
    }