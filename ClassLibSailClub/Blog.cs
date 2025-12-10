using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibSailClub
{
    public class Blog
    {
        List<BlogPost> BlogList { get; set; } = new List<BlogPost>();



        public void CreateBlogPost(Member member, string date, string time, string title, string body)
        {
            if(member.IsAdmin)
            {
                BlogPost tempPost = new BlogPost(date, time, title, body);
                BlogList.Add(tempPost);
               
            }
            else
            {
                throw new AccessViolationException($"ACCESS DENIED!\nThe member {member.Name} is not an admin");
            }
        }

       
    }
}
