using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStoreApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
    }
}