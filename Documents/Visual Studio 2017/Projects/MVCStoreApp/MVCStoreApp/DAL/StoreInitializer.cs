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
            new Book{BookID=8292, AuthorID=0002, GenreID=3928, Title="Dr. Chuck Tingle's Complete Guide to the Void", AuthorLastName="Tingle", AuthorFirstName="Chuck"},
            new Book{BookID=4215, AuthorID=0002, GenreID=3928, Title="Dr. Chuck Tingle's Complete Guide to Romance", AuthorLastName="Tingle", AuthorFirstName="Chuck"},
            new Book{BookID=2819, AuthorID=0002, GenreID=3928, Title="Dr. Chuck Tingle's Complete Guide to Sport", AuthorLastName="Tingle", AuthorFirstName="Chuck"},
            new Book{BookID=0168,Title="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Book{BookID=9261,Title="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Book{BookID=4928,Title="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}