using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
   
    public class MovieList
    {
        public static List<Movie> mlist { get; set; }
        public static List<Movie> GetAll()
        {
            mlist = new List<Movie>();
            Movie m1 = new Movie() { Id = 1, Img = "/Images/m1.jpg", Name = "Kohun ka Khilade" };
            mlist.Add(m1);
            Movie m2 = new Movie() { Id = 2, Img = "/Images/m2.jpg", Name = "Aag Lagi Chule me" };
            mlist.Add(m2);
            Movie m3 = new Movie() { Id = 3, Img = "/Images/m3.jpg", Name = "Makoda Manav" };
            mlist.Add(m3);
            Movie m4 = new Movie() { Id = 4, Img = "/Images/m4.jpg", Name = "Jasus Mainduk" };
            mlist.Add(m4);
            return mlist;
        }
    }
}