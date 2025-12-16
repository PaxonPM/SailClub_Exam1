using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibSailClub
{
    public class BlogPost : IValidate
    {
        public DateTime Date { get; }
        public string Time { get; }
        public string Title { get; }
        public string Body { get; set; } 

        public BlogPost(string title, string body)
        {
            Date = DateTime.Now;
            Time = DateTime.Now.ToString("HH:mm");
            Title = title;
            Body = body;
        }

        public override string ToString()
        {
            return $"\n{Title} - Created at {Date}\n{Body}";
        }

        //implemtering af IValidate
        public void Validate()
        {
            if (Date == default)
                throw new ArgumentException("Date is required.");
            if (string.IsNullOrWhiteSpace(Title))
                throw new ArgumentException("Title is required.");
            if (string.IsNullOrWhiteSpace(Body))
                throw new ArgumentException("Body is required.");

        }

        public bool RoutineValidate()
        {
            if (Title.Length > 30) return false;
            if (Body.Length < 10) return false;

            return true;
        }


    }
}
