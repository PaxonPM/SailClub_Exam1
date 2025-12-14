using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BlogPost : IValidate
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

        //implemtering af IValidate
        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Date))
                throw new ArgumentException("Date is required.");
            if (string.IsNullOrWhiteSpace(Time))
                throw new ArgumentException("Time is required.");
            if (string.IsNullOrWhiteSpace(Title))
                throw new ArgumentException("Time is required.");
            if (string.IsNullOrWhiteSpace(Body))
                throw new ArgumentException("Body is required.");

        }

        public bool TryValidate()
        {
            if (Title.Length > 30) return false;
            if (Body.Length < 10) return false;

            return true;
        }


    }
}
