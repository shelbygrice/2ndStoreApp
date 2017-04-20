using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCStoreApp.Models;

namespace MVCStoreApp.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var books = new List<Book>
            {
            new Book{BookID=5278, AuthorID=0001, GenreID=6676, Title="The Billionaire and the Bellboy", AuthorLastName="Daniel", AuthorFirstName="Elijah"},
            new Book{BookID=7609, AuthorID=0002, GenreID=6676, Title="Handsome Sentient Food", AuthorLastName="Tingle", AuthorFirstName="Chuck"},
            new Book{BookID=8292, AuthorID=4820, GenreID=3298, Title="Oral Sadism and the Vegetarian Personality", AuthorLastName="Ellenbogen", AuthorFirstName="Glenn"},
            new Book{BookID=4215, AuthorID=2044, GenreID=5928, Title="Knitting with Dog Hair", AuthorLastName="Crolius", AuthorFirstName="Kendall"},
            new Book{BookID=2819, AuthorID=0294, GenreID=5928, Title="How to Survive a Garden Gnome Attack", AuthorLastName="Sambuchino", AuthorFirstName="Chuck"},
            new Book{BookID=0168, AuthorID=7392, GenreID=1344, Title="Does God Ever Speak Through Cats?", AuthorLastName="Evans", AuthorFirstName="David"},
            new Book{BookID=9261, AuthorID=1284, GenreID=5928, Title="Goblinproofing One's Chicken Coop", AuthorLastName="Bakeley", AuthorFirstName="Reginald" },
            new Book{BookID=4928, AuthorID=9031, GenreID=5729, Title="Teach Your Wife to be a Widow", AuthorLastName="Rogers", AuthorFirstName="Donald" }
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
            var authors = new List<Author>
            {
            new Author{AuthorID=0001,LastName="Daniel",FirstName="Elijah"},
            new Author{AuthorID=0002,LastName="Tingle",FirstName="Chuck"},
            new Author{AuthorID=4820,LastName="Ellenbogen",FirstName="Glenn"},
            new Author{AuthorID=2044,LastName="Crolius",FirstName="Kendall"},
            new Author{AuthorID=0294,LastName="Sambuchino",FirstName="Chuck"},
            new Author{AuthorID=7392,LastName="Evans",FirstName="David"},
            new Author{AuthorID=1284,LastName="Bakeley",FirstName="Reginald"},
            new Author{AuthorID=9031,LastName="Rogers",FirstName="Donald"}
            };
            authors.ForEach(s => context.Authors.Add(s));
            context.SaveChanges();
            var genre = new List<Genre>
            {
            new Genre{GenreID=6676, GenreType="Fiction"},
            new Genre{GenreID=5928, GenreType="How-To"},
            new Genre{GenreID=5729, GenreType="Self-Help"},
            new Genre{GenreID=1344, GenreType="Comedy"},
            new Genre{GenreID=3298, GenreType="Nonfiction"}
            };
            genre.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
        }
    }
}