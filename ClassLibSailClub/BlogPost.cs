using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BlogPost
    {
        public string Date { get; }
        public string Time { get; }
        public string Title { get; }
        public string Body { get; set; } 

        public BlogPost(string date, string time, string title, string body)
        {
            Date = date;
            Time = time;
            Title = title;
            Body = body;
        }


    }
}
