using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStoreApp.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return LastName + ", " + FirstName;
        //    }
        //}
    }
}